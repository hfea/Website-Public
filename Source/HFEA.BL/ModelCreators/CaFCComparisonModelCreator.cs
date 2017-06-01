using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.CaFC.Comparison;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Contracts.CommonObjects;
using HFEA.Core.Extensions;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.CaFC.Model.Comparison;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WT = HFEA.Connector.Contracts.CaFC.WaitingTimes;

namespace HFEA.BL.ModelCreators
{
    public class CaFCComparisonModelCreator : BaseCaFCModelCreator, ICaFCComparisonModelCreator
    {
        private const string WaitingTimesNotAvailableString = "not available";
        private readonly ICaFCComparisonClient reader;
        public CaFCComparisonModelCreator(ICaFCComparisonClient apiClient)
        {
            if (apiClient == null) throw new ArgumentNullException("api data reader is null");
            this.reader = apiClient;
        }

        public ComparisonViewModel GetData(params int[] clinicIds)
        {
            ComparisonViewModel result = null;

            var data = this.reader.GetComparisonData(clinicIds);
            if (!data.IsNullOrEmpty())
            {
                result = new ComparisonViewModel()
                {
                    ClinicList = new List<ComparisonClinic>(),
                    CounsellingItems = this.GetValidComparisonTitles(data, (ComparisonClinicInfo x) => x.CounsellingAndSupport),                    
                    DonorServiceItems = this.GetValidComparisonTitles(data, (ComparisonClinicInfo x) => x.DonorServices),
                    EligibilityItems = this.GetValidComparisonTitles(data, (ComparisonClinicInfo x) => x.EligibilityAndFunding),
                    FacilitiesItems = this.GetValidComparisonTitles(data, (ComparisonClinicInfo x) => x.Facilities),
                    StaffingItems = this.GetValidComparisonTitles(data, (ComparisonClinicInfo x) => x.Staff),
                    TreatmentItems = this.GetValidComparisonTitles(data, (ComparisonClinicInfo x) => x.TreatmentsOffered),
                };

                foreach(var clinicInfo in data)
                {
                    ComparisonClinic clinic = this.MapBaseClinicInfo(clinicInfo);
                    if (clinic != null)
                    {
                        clinic.Eligibility = this.MapToComparisonBooleanList(clinicInfo.EligibilityAndFunding, result.EligibilityItems);
                        clinic.Treatments = this.MapToComparisonBooleanList(clinicInfo.TreatmentsOffered, result.TreatmentItems);
                        clinic.DonorServices = this.MapToComparisonBooleanList(clinicInfo.DonorServices, result.DonorServiceItems);
                        clinic.GameteAvailability = this.GetGameteAvailabilityInfo(clinicInfo.EggDonorWaitingTimes, clinicInfo.SpermDonorWaitingTimes, clinicInfo.EmbryoDonorWaitingTimes);
                        clinic.CounsellingAndSupport = this.MapToComparisonBooleanList(clinicInfo.CounsellingAndSupport, result.CounsellingItems);
                        clinic.Staffing = this.MapToComparisonBooleanList(clinicInfo.Staff, result.StaffingItems); ;
                        clinic.Facilities = this.MapToComparisonBooleanList(clinicInfo.Facilities, result.FacilitiesItems);                        
                        clinic.SatelliteClinicList = this.GetAssociatedClinicsByType(clinicInfo.SatelliteClinics, CaFCConstants.ClinicType.Satellite);
                        clinic.TransportClinicList = this.GetAssociatedClinicsByType(clinicInfo.SatelliteClinics, CaFCConstants.ClinicType.Transport);
                        result.ClinicList.Add(clinic);
                    }
                }
            }

            return result;
        }

        private List<SatelliteClinicInfo> GetAssociatedClinicsByType(List<Link> data, CaFCConstants.ClinicType clinicType)
        {
            List<SatelliteClinicInfo> result = null;

            if (!data.IsNullOrEmpty())
            {
                result = this.GetAssociatedClinicInfoList(data.Where(x => x.LinkType == (int)clinicType));
            }

            return result;
        }

        private List<IdValuePairInt> GetValidComparisonTitles(List<ComparisonClinicInfo> data, Func<ComparisonClinicInfo, List<IdNameDescription>> getClinicData)
        {
            List<IdValuePairInt> result = null;

            if (data != null)
            {
                result = data
                    .SelectMany(x => getClinicData(x))
                    .Where(x => x != null)
                    .DistinctBy(x => x.Id)
                    .Select(x => 
                        new IdValuePairInt()
                        {
                            Id = x.Id,
                            Value = x.Name
                        })
                    .ToList();
            }

            return result;
        }

        private ComparisonClinic MapBaseClinicInfo(ComparisonClinicInfo data)
        {
            ComparisonClinic result = null;

            if (data != null)
            {
                result = new ComparisonClinic()
                {
                    ClinicId = data.Id,
                    ClinicName = data.CentreName,
                    ClinicType = data.CentreTypeDescription,
                    ProfileImage = data.ProfileImageUrl,
                    AddressLines = this.GetAddressLines(data.MainAddress),
                    OpeningTimesList = this.GetOpeningTimesList(data.OpeningTimes),
                    OpeningTimesCaveat = "TODO Caveat text", // TODO
                    Ratings =  this.GetRatingData(data)                                     
                };
            }

            return result;
        }

        private RatingData GetRatingData(ComparisonClinicInfo data)
        {
            if (data == null) return null;

            return new RatingData()
            {
                InspectionRating = data.InspectionRating,
                InspectionRatingLicensedUntil = data.InspectionRatingLicensedUntil.ToNullableDate(),
                PatientRating = data.PatientRating.GetValueOrDefault(),
                PatientRatingCount = (int)data.PatientRatingNumberOfRatings.GetValueOrDefault(),
                // TODO: remove the below hard coded values. Waiting for the API to be updated
                IVF = data.IvfBirthRateAllAges != null ? this.GetStatisticsItem(0, data.IvfBirthRateAllAges.Value, 0, 0, "Consistent with", 99, null) : null,
                IUI = data.IuiBirthRateAllAges != null ? this.GetStatisticsItem(0, data.IuiBirthRateAllAges.Value, 0, 0, "Above", 88, null) : null,
                DI = data.DiBirthRateAllAges != null ? this.GetStatisticsItem(0, data.DiBirthRateAllAges.Value, 0, 0, "Below", 77, null) : null,
                MultipleRate = data.MultipleBirthRateAllAges != null ? this.GetStatisticsItem(0, data.MultipleBirthRateAllAges.Value, 0, 0, "Consistent with", 66, null) : null
            };
        }

        private ClinicGameteAvailability GetGameteAvailabilityInfo(WT eggData, WT spermData, WT embryoData)
        {
            Func<string, GameteAvailabilityItem> getStats = (data) =>
            {
                var res = new GameteAvailabilityItem();
                res.GameteAvailablityText = data;

                if (string.IsNullOrEmpty(data))
                {
                    res.IsAvailable = null;
                }
                else if (string.Equals(data, WaitingTimesNotAvailableString, StringComparison.InvariantCultureIgnoreCase))
                {
                    res.IsAvailable = false;
                }
                else
                {
                    res.IsAvailable = true;
                }

                return res;
            };

            var result = new ClinicGameteAvailability()
            {
                Asian = new GameteAvailabilityStats() { Egg = getStats(eggData.Asian), Embryo = getStats(embryoData.Asian), Sperm = getStats(spermData.Asian) },
                Black = new GameteAvailabilityStats() { Egg = getStats(eggData.Black), Embryo = getStats(embryoData.Black), Sperm = getStats(spermData.Black) },
                Mixed = new GameteAvailabilityStats() { Egg = getStats(eggData.Mixed), Embryo = getStats(embryoData.Mixed), Sperm = getStats(spermData.Mixed) },
                Other = new GameteAvailabilityStats() { Egg = getStats(eggData.Other), Embryo = getStats(embryoData.Other), Sperm = getStats(spermData.Other) },
                White = new GameteAvailabilityStats() { Egg = getStats(eggData.White), Embryo = getStats(embryoData.White), Sperm = getStats(spermData.White) },
            };
            
            return result;
        }

        private List<ComparisonDataItem> MapToComparisonBooleanList(List<IdNameDescription> data, List<IdValuePairInt> eligibleIds)
        {
            List<ComparisonDataItem> result = null;

            if (!eligibleIds.IsNullOrEmpty())
            {
                result = new List<ComparisonDataItem>();
                foreach(var idValuePair in eligibleIds)
                {
                    bool? val = null;
                    if (data != null && data.Any(x => x.Id == idValuePair.Id))
                    {
                        val = true;
                    }

                    result.Add(new ComparisonDataItem()
                    {
                        Id = idValuePair.Id,
                        Value = val
                    });
                }
            }

            return result;
        }
    }
}
