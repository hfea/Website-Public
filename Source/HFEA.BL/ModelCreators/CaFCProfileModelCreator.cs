using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Contracts.CommonObjects;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.BL.ModelCreators
{
    public class CaFCProfileModelCreator : BaseCaFCModelCreator, ICaFCProfileModelCreator
    {
        private const string TreatsField = "eligibilityAndFundingLabel";
        private const string TreatmentsField = "treatmentsLabel";
        private const string CounsellingAndSupportField = "counsellingAndSupportLabel";
        private const string DonorServicesField = "donorServicesLabel";
        private const string ScreeningServicesField = "screeningServicesLabel";
        private const string StaffingField = "staffingLabel";
        private const string FacilitiesField = "facilitiesLabel";

        private const string ChartXLabelDateFormat = "MMM/yy";
        
        private readonly ICaFCProfileClient client;
        private readonly ICafcProfileUrlHelper urlHelper;
        private CaFCProfileViewModel viewModel;

        public CaFCProfileModelCreator(ICaFCProfileClient apiClient, ICafcProfileUrlHelper profileUrlHelper)
        {
            if (apiClient == null) throw new ArgumentNullException("CaFC profile API client is null");
            this.client = apiClient;
            this.urlHelper = profileUrlHelper;
        }

        public CaFCProfileViewModel GetViewModel(int clinicId)
        {
            if (this.viewModel == null || this.viewModel.GeneralInfo?.Id != clinicId)
            {
                ClinicProfile data = this.client.GetClinicProfile(clinicId);

                var model = new CaFCProfileViewModel();
                model.GeneralInfo = this.GetGeneralClinicData(data);
                model.PatientExperiences = this.GetPatientExperiencesData(data);
                model.InspectionRatings = this.GetInspectionRatingInfo(data);
                model.BirthStatsInfo = this.GetBirthStatisticsInfo(data);
                model.WaitingTimesInfo = this.GetWaitingTimesInfo(data);
                model.ClinicDetailsInfo = this.GetClinicDetailsInfo(data);

                if (model.GeneralInfo != null)
                {
                    model.GeneralInfo.HasInspectorRatingInfo = model.InspectionRatings != null;
                }

                this.viewModel = model;
            }

            return this.viewModel;
        }

        private InspectionRatingInfo GetInspectionRatingInfo(ClinicProfile data)
        {
            if (data?.InspectionRatingProfile != null)
            {
                return new InspectionRatingInfo()
                {
                    InspectorSummary = data.InspectionRatingProfile.InspectionSummary,
                    InspectorProfile = data.InspectionRatingProfile.CentreProfile,
                    OverallScore = data.InspectionRatingProfile.OverallScore,
                    LastInspectionDate = data.InspectionRatingProfile.LastInspected.ToNullableDate(),
                    LicensedUntil = data.InspectionRatingProfile.LicenceExpires.ToNullableDate()
                };
            }

            return null;
        }

        private BirthStatisticsInfo GetBirthStatisticsInfo(ClinicProfile data)
        {
            var result = new BirthStatisticsInfo();

            if (data != null && data.CentreSuccessRateSummary != null)
            {
                result.Year = data.CentreSuccessRateSummary.DataDateRangeEnd.Year;
                result.CaveatText = data.SuccessRateSummaryCaveat;
                result.HasDiData = data.CentreSuccessRateSummary.HasDiData;
                result.HasIuiData = data.CentreSuccessRateSummary.HasIuiData;
                result.HasIvfData = data.CentreSuccessRateSummary.HasIvfData;

                result.GenericTreatmentTitle = data.CentreSuccessRateSummary.GenericTreatmentTitle;
                result.GenericTreatmentClinicValue = data.CentreSuccessRateSummary.GenericTreatmentClinicValue;
                result.GenericTreatmentNationalValue = data.CentreSuccessRateSummary.GenericTreatmentNationalValue;

                CentreSuccessRateSummary summary = data.CentreSuccessRateSummary;

                int year = summary.DataDateRangeStart.Year;

                result.BirthsPerEmbryo = new StatisticsDataSet()
                {
                    Year = year,
                    All = this.GetStatisticsItem(summary.FieldAllBetNational, summary.FieldAllBetEst, summary.FieldAllBetChanceLower, summary.FieldAllBetChanceHigher, summary.FieldAllBetCompareNat, summary.FieldAllBet, summary.fieldAllBetCaveat),
                    Over38 = this.GetStatisticsItem(summary.FieldO38BetNational, summary.FieldO38BetEst, summary.FieldO38BetChanceLower, summary.FieldO38BetChanceHigher, summary.FieldO38BetCompareNat, summary.FieldO38Bet, summary.fieldO38BetCaveat),
                    Under38 = this.GetStatisticsItem(summary.FieldU38BetNational, summary.FieldU38BetEst, summary.FieldU38BetChanceLower, summary.FieldU38BetChanceHigher, summary.FieldU38BetCompareNat, summary.FieldU38Bet, summary.fieldU38BetCaveat),
                };
                result.BirthsPerEmbryo.HideStatDataSet = this.GetHideDataSetFlag(result.BirthsPerEmbryo);

                result.BirthsPerEggCollection = new StatisticsDataSet()
                {
                    Year = year,
                    All = this.GetStatisticsItem(summary.FieldAllBecNational, summary.FieldAllBecEst, summary.FieldAllBecChanceLower, summary.FieldAllBecChanceHigher, summary.FieldAllBecCompareNat, summary.FieldAllBec, summary.fieldAllBecCaveat),
                    Over38 = this.GetStatisticsItem(summary.FieldO38BecNational, summary.FieldO38BecEst, summary.FieldO38BecChanceLower, summary.FieldO38BecChanceHigher, summary.FieldO38BecCompareNat, summary.FieldO38Bec, summary.fieldO38BecCaveat),
                    Under38 = this.GetStatisticsItem(summary.FieldU38BecNational, summary.FieldU38BecEst, summary.FieldU38BecChanceLower, summary.FieldU38BecChanceHigher, summary.FieldU38BecCompareNat, summary.FieldU38Bec, summary.fieldU38BecCaveat),
                };
                result.BirthsPerEggCollection.HideStatDataSet = this.GetHideDataSetFlag(result.BirthsPerEggCollection);

                result.MultipleBirthsPerCycle = new StatisticsDataSet()
                {
                    Year = year,
                    All = this.GetStatisticsItem(summary.FieldAllMlbNational, summary.FieldAllMlbEst, summary.FieldAllMlbChanceLower, summary.FieldAllMlbChanceHigher, summary.FieldAllMlbCompareNat, summary.FieldAllMlb, summary.fieldAllMlbCaveat),
                    Over38 = this.GetStatisticsItem(summary.FieldO38MlbNational, summary.FieldO38MlbEst, summary.FieldO38MlbChanceLower, summary.FieldO38MlbChanceHigher, summary.FieldO38MlbCompareNat, summary.FieldO38Mlb, summary.fieldO38MlbCaveat),
                    Under38 = this.GetStatisticsItem(summary.FieldU38MlbNational, summary.FieldU38MlbEst, summary.FieldU38MlbChanceLower, summary.FieldU38MlbChanceHigher, summary.FieldU38MlbCompareNat, summary.FieldU38Mlb, summary.fieldU38MlbCaveat),
                };
                result.MultipleBirthsPerCycle.HideStatDataSet = this.GetHideDataSetFlag(result.MultipleBirthsPerCycle);

                result.IUIBirths = new StatisticsDataSet()
                {
                    Year = year,
                    All = this.GetStatisticsItem(summary.FieldAllPregNational, summary.FieldAllPregEst, summary.FieldAllPregChanceLower, summary.FieldAllPregChanceHigher, summary.FieldAllPregCompareNat, summary.FieldAllPreg, summary.fieldAllPregCaveat),
                    Over38 = this.GetStatisticsItem(summary.FieldO38PregNational, summary.FieldO38PregEst, summary.FieldO38PregChanceLower, summary.FieldO38PregChanceHigher, summary.FieldO38PregCompareNat, summary.FieldO38Preg, summary.fieldO38PregCaveat),
                    Under38 = this.GetStatisticsItem(summary.FieldU38PregNational, summary.FieldU38PregEst, summary.FieldU38PregChanceLower, summary.FieldU38PregChanceHigher, summary.FieldU38PregCompareNat, summary.FieldU38Preg, summary.fieldU38PregCaveat),
                };
                result.IUIBirths.HideStatDataSet = this.GetHideDataSetFlag(result.IUIBirths);

                result.DIBirths = new StatisticsDataSet()
                {
                    Year = year,
                    All = this.GetStatisticsItem(summary.FieldAllDiNational, summary.FieldAllDiEst, summary.FieldAllDiChanceLower, summary.FieldAllDiChanceHigher, summary.FieldAllDiCompareNat, summary.FieldAllDi, summary.fieldAllDiCaveat),
                    Over38 = this.GetStatisticsItem(summary.FieldO38DiNational, summary.FieldO38DiEst, summary.FieldO38DiChanceLower, summary.FieldO38DiChanceHigher, summary.FieldO38DiCompareNat, summary.FieldO38Di, summary.fieldO38DiCaveat),
                    Under38 = this.GetStatisticsItem(summary.FieldU38DiNational, summary.FieldU38DiEst, summary.FieldU38DiChanceLower, summary.FieldU38DiChanceHigher, summary.FieldU38DiCompareNat, summary.FieldU38Di, summary.fieldU38DiCaveat),
                };
                result.DIBirths.HideStatDataSet = this.GetHideDataSetFlag(result.DIBirths);
                result.ChartData = this.GetPregnancyRateChartData(data.CentreSuccessRateSummary.PregnancyRates);

                // Data date ranges
                // TODO: Alex 16/9/2016. Is current time suitable below? Also, we should use "ToHfeaShortDateString()"?
                DateTime tmpDate = DateTime.Today;
                DateTime.TryParse(data.CentreSuccessRateSummary.Ivfemb_ivfmultb_dicyc_DataDateRangeStart, out tmpDate);
                result.Ivfemb_ivfmultb_dicyc_DataDateRangeStart = tmpDate.ToShortDateString();
                DateTime.TryParse(data.CentreSuccessRateSummary.Ivfemb_ivfmultb_dicyc_DataDateRangeEnd, out tmpDate);
                result.Ivfemb_ivfmultb_dicyc_DataDateRangeEnd = tmpDate.ToShortDateString();
                DateTime.TryParse(data.CentreSuccessRateSummary.IvfeggcollCBR_DataDateRangeStart, out tmpDate);
                result.IvfeggcollCBR_DataDateRangeStart = tmpDate.ToShortDateString();
                DateTime.TryParse(data.CentreSuccessRateSummary.IvfeggcollCBR_DataDateRangeEnd, out tmpDate);
                result.IvfeggcollCBR_DataDateRangeEnd = tmpDate.ToShortDateString();
                DateTime.TryParse(data.CentreSuccessRateSummary.Iui_DataDateRangeStart, out tmpDate);
                result.Iui_DataDateRangeStart = tmpDate.ToShortDateString();
                DateTime.TryParse(data.CentreSuccessRateSummary.Iui_DataDateRangeEnd, out tmpDate);
                result.Iui_DataDateRangeEnd = tmpDate.ToShortDateString();

                if (data.HasDetailedStatistics)
                {
                    result.StatsPageUrl = this.urlHelper.GetStatsPageUrl(data.Id);
                }
            }

            return result;
        }

        private TimeSeries GetPregnancyRateChartData(List<PregnancyRateStats> data)
        {
            TimeSeries result = null;

            if (data != null)
            {
                var validData = data
                    .Where(x => x.Date > DateTime.MinValue && x.MultiplePregnancyRate >= 0 && x.PregnancyRate >= 0)
                    .OrderBy(x => x.Date)
                    .ToList();

                result = new TimeSeries()
                {
                    XAxisLabelList = validData.Select(x => x.Date.ToString(ChartXLabelDateFormat)).ToList(),
                    PregnancyRatesDataList = validData.Select(x => x.PregnancyRate).ToList(),
                    MultiRatesDataList = validData.Select(x => x.MultiplePregnancyRate).ToList()
                };
            }

            return result;
        }

        private WaitingTimesInfo GetWaitingTimesInfo(ClinicProfile data)
        {
            WaitingTimesInfo result = null;

            if (data != null)
            {
                result = new WaitingTimesInfo();

                if (data.EggDonorWaitingTimes != null)
                {
                    result.EggDonors = this.MapWithAutoMapper<Web.ViewModel.CaFC.Model.WaitingTimes>(data.EggDonorWaitingTimes);
                }

                if (data.SpermDonorWaitingTimes != null)
                {
                    result.SpermDonors = this.MapWithAutoMapper<Web.ViewModel.CaFC.Model.WaitingTimes>(data.SpermDonorWaitingTimes);
                }

                if (data.EmbryoDonorWaitingTimes != null)
                {
                    result.EmbryoDonors = this.MapWithAutoMapper<Web.ViewModel.CaFC.Model.WaitingTimes>(data.EmbryoDonorWaitingTimes);
                }

                if (data.DonorSource != null)
                {
                    result.DonorSource = data.DonorSource.Select(x => x.Name).ToList();
                }

                result.HasData = this.CheckWaitingTimesHasData(result);
            }

            return result;
        }

        public bool CheckWaitingTimesHasData(WaitingTimesInfo info)
        {
            bool result = this.CheckWatingTimeItemHasData(info?.EggDonors)
             && this.CheckWatingTimeItemHasData(info?.EmbryoDonors)
             && this.CheckWatingTimeItemHasData(info?.SpermDonors);
            

            return result;
        }

        public bool CheckWatingTimeItemHasData(Web.ViewModel.CaFC.Model.WaitingTimes waitingTimes)
        {
            string noDataCheck = Connector.Contracts.Constants.Centre.DonorAvailability.NoDataAvailable.GetDescriptionOrStringValue().ToString().ToLower();

            bool result = waitingTimes != null
                && (waitingTimes.White.ToLower() != noDataCheck
                    || waitingTimes.Black.ToLower() != noDataCheck
                    || waitingTimes.Asian.ToLower() != noDataCheck
                    || waitingTimes.Mixed.ToLower() != noDataCheck
                    || waitingTimes.Other.ToLower() != noDataCheck);
            
            return result;
        }

        private ClinicDetailsInfo GetClinicDetailsInfo(ClinicProfile data)
        {
            var result = new ClinicDetailsInfo();

            if (data != null)
            {
                result.CentreTypeDescription = data.CentreTypeDescription;
                result.CentreEmail = data.CentreEmail;
                result.CentrePhone = data.CentrePhone;
                result.OtherCentrePhone = data.OtherCentrePhone;
                result.Website = data.Website;
                result.WebsiteUri = this.GetUri(data.Website);
                result.Fax = data.Fax;
                result.ImageUrl = data.ProfileImageUrl;
                result.LicensePRRolesModel = MapWithAutoMapper<List<LicenseRoles>>(data.LicenceRoles);

                //result.AdditionalClinicInfo = data.ProfileCaveat;

                result.ClinicServiceList = this.GetClinicServices(data);

                if (data.MainAddress != null)
                {
                    result.AddressLinesList = this.GetAddressLines(data.MainAddress);
                }

                if (data.Coordinates != null && data.Coordinates.Lat != 0 && data.Coordinates.Lng != 0)
                {
                    var mapInfo = new MapInformation
                    {
                        Lat = data.Coordinates.Lat.ToString(),
                        Long = data.Coordinates.Lng.ToString(),
                    };

                    if (data.MapToolTip != null)
                    {
                        mapInfo.PinTitle = data.MapToolTip.Name;
                        mapInfo.PinText = data.MapToolTip.Type;
                    }

                    result.MapInfo = mapInfo;
                }

                result.OpeningHoursList = this.GetOpeningTimesList(data.OpeningTimes);

                if (data.SatelliteClinics != null)
                {
                    var satellites = data.SatelliteClinics.Where(x => x.LinkType == (int)CaFCConstants.ClinicType.Satellite).ToList();
                    result.SatelliteClinicList = this.GetAssociatedClinicInfoList(satellites);

                    var transport = data.SatelliteClinics.Where(x => x.LinkType == (int)CaFCConstants.ClinicType.Transport).ToList();
                    result.TransportClinicList = this.GetAssociatedClinicInfoList(transport);
                }
            }

            return result;
        }

        public string GetUri(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    return new UriBuilder(url).Uri.ToString();
                }
                catch 
                {
                    return string.Empty;
                }
            }

            return string.Empty;
        }
        

        private List<ClinicService> GetClinicServices(ClinicProfile data)
        {
            var result = new List<ClinicService>();

            if (data != null)
            {
                Action<CaFCConstants.ClinicServiceType, List<IdNameDescription>, string> addServiceIfValid = (type, collection, field) =>
                {
                    if (type != CaFCConstants.ClinicServiceType.Unknown && collection != null && collection.Any())
                    {
                        var service = new ClinicService()
                        {
                            ServiceType = type,
                            ServiceList = collection.Select(x => new ServiceList { Id = x.Id, Name = x.Name, Description = x.Description }).ToList(),
                            CmsFieldAlias = field
                        };

                        result.Add(service);
                    }
                };

                addServiceIfValid(CaFCConstants.ClinicServiceType.Treat, data.EligibilityAndFunding, TreatsField);
                addServiceIfValid(CaFCConstants.ClinicServiceType.Treatments, data.TreatmentsOffered, TreatmentsField);
                addServiceIfValid(CaFCConstants.ClinicServiceType.DonorServices, data.DonorServices, DonorServicesField);
                addServiceIfValid(CaFCConstants.ClinicServiceType.ScreeningServices, data.ScreeningServices, ScreeningServicesField);
                addServiceIfValid(CaFCConstants.ClinicServiceType.CounsellingAndSupport, data.CounsellingAndSupport, CounsellingAndSupportField);
                addServiceIfValid(CaFCConstants.ClinicServiceType.Staffing, data.Staff, StaffingField);
                addServiceIfValid(CaFCConstants.ClinicServiceType.Facilities, data.Facilities, FacilitiesField);
            }

            return result;
        }

        private PatientRatingInfo GetPatientExperiencesData(ClinicProfile data)
        {
            if (data != null && data.PatientExperiences != null)
            {
                var result = this.MapWithAutoMapper<PatientRatingInfo>(data.PatientExperiences);
                result.FeedBackLink = urlHelper.GetFeedBackUrl(data.Id);
                return result;
            }

            return null;
        }

        private ClinicGeneralInfo GetGeneralClinicData(ClinicProfile clinic)
        {
            var clinicItem = new ClinicGeneralInfo();

            if (clinic != null)
            {
                clinicItem.Id = clinic.Id;
                clinicItem.CentreName = clinic.CentreName;
                clinicItem.CentreDescription = clinic.InspectionRatingProfile?.CentreProfile;

                // TODO: double check if this is needed. This value is also conditionally set below in the code
                clinicItem.NationalSuccessRate = clinic.NationalAverage;
                clinicItem.InspectionRating = clinic.InspectionRatingProfile?.OverallScore ?? 0;
                clinicItem.NumberOfUserReviews = clinic.PatientExperiences?.NumberOfReviews ?? 0;

                if (clinic.CentreSuccessRateSummary != null)
                {
                    clinicItem.RatingType = clinic.CentreSuccessRateSummary.GenericTreatment;
                    clinicItem.IndicativeSuccessRate = clinic.CentreSuccessRateSummary.GenericTreatmentClinicValue.ToString() + "%";
                    clinicItem.NationalSuccessRate = clinic.CentreSuccessRateSummary.GenericTreatmentNationalValue.ToString() + "%";
                    clinicItem.ClinicSuccessRateValue = clinic.CentreSuccessRateSummary.GenericTreatmentClinicValue;
                    clinicItem.HasSuccessRateInfo = true;
                }
                clinicItem.GenericTreatmentTitle = clinic.CentreSuccessRateSummary.GenericTreatmentTitle;
                clinicItem.IndicativeSuccessRateCaveat = clinic.IndicativeSuccessRateCaveat;
                clinicItem.SuccessRateSummaryCaveat = clinicItem.SuccessRateSummaryCaveat;

                if (clinic.PatientExperiences != null)
                {
                    clinicItem.UserRating = clinic.PatientExperiences.OverallScore;
                    clinicItem.HasUserRatingInfo = true;
                }

                // a profile clinic is never satellite or transport
                clinicItem.IsSatelliteOrTransportClinic = false;

                clinicItem.ImageUrl = clinic.ProfileImageUrl;

                clinicItem.FeedBackLink = urlHelper.GetFeedBackUrl(clinic.Id);
            }

            return clinicItem;
        }

        private T MapWithAutoMapper<T>(object data)
        {
            T result = default(T);

            if (data != null)
            {
                result = AutoMapper.Mapper.Map<T>(data);
            }

            return result;
        }

        private bool GetHideDataSetFlag(StatisticsDataSet dataSet)
        {
            bool result = true;
            if (dataSet != null)
            {
                if (dataSet.All != null && !dataSet.All.HideStatItem)
                {
                    result = false;
                }
                else if (dataSet.Under38 != null && !dataSet.Under38.HideStatItem)
                {
                    result = false;
                }
                else if (dataSet.Over38 != null && !dataSet.Over38.HideStatItem)
                {
                    result = false;
                }
            }

            return result;
        }

    }
}
