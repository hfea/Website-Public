using HFEA.Connector.Contracts.CaFC.Stats;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Core.Extensions;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HFEA.BL.ModelCreators
{
    public class CaFCStatsModelCreator : IClinicStatsModelCreator
    {
        private readonly ICaFCStatsClient dataReader;
        private readonly ICafcProfileUrlHelper urlHelper;

        private const string EmbryoTransferNumberKey = "averageNumberOfEmbryosTransferredDuringAllCycles";

        private Dictionary<string, CaFCConstants.ComparableToAverage> StatsCompareDictionary = new Dictionary<string, CaFCConstants.ComparableToAverage>()
        {
            { "Consistent with" , CaFCConstants.ComparableToAverage.Consistent },
            { "Above", CaFCConstants.ComparableToAverage.Above },
            { "Below", CaFCConstants.ComparableToAverage.Below }
        };

        private List<string> StatsWithReverseNumbers = new List<string>()
        {
            "miscarriagesPerCycle", "multipleLiveBirthsPerCycle"
        };

        public CaFCStatsModelCreator(ICaFCStatsClient apiClient, ICafcProfileUrlHelper urlResolver)
        {
            if (apiClient == null) throw new ArgumentNullException("Stats client is null");
            if (urlResolver == null) throw new ArgumentNullException("CAFC url resolver is null");
            this.urlHelper = urlResolver;
            this.dataReader = apiClient;
        }

        public StatsSearchFilterValues GetAvailableFiltersByData(int clinicId, string year = "", string treatment = "", string age = "", string source = "")
        {
            StatsSearchFilterValues result = null;

            if (clinicId > 0)
            {
                IEnumerable<StatsApiSearchFilters> data = this.GetAvailableFilters(clinicId);

                if (!data.IsNullOrEmpty())
                {
                    bool isFinalStep = false;
                    result = new StatsSearchFilterValues();

                    result.ClinicId = clinicId;
                    // populate year dropdown values 
                    result.Years = data.Select(x => x.Year).DistinctBy(x => x.Id).ToList();
                    result.CurrentStep = 1;

                    // populate treatment dropdown values if year parameter is provided
                    if (!string.IsNullOrEmpty(year) && !result.Years.IsNullOrEmpty())
                    {
                        List<IdValuePair> tvalues;
                        data = this.GetFilter(data, x => x.Treatment, x => x.Year, year, out tvalues);
                        result.Treatments = tvalues;
                        result.CurrentStep++;

                        // populate age group dropdown values if treatmnet parameter is provided
                        if (!string.IsNullOrEmpty(treatment) && !data.IsNullOrEmpty() & !result.Treatments.IsNullOrEmpty())
                        {
                            List<IdValuePair> ageValues;
                            data = this.GetFilter(data, x => x.Age, x => x.Treatment, treatment, out ageValues);
                            result.Ages = ageValues;
                            result.CurrentStep++;

                            // populate source group dropdown values if age parameter is provided
                            if (!string.IsNullOrEmpty(age) && !data.IsNullOrEmpty() & !result.Ages.IsNullOrEmpty())
                            {
                                List<IdValuePair> sourceValues;
                                data = this.GetFilter(data, x => x.Source, x => x.Age, age, out sourceValues);
                                result.Sources = sourceValues;
                                result.CurrentStep++;

                                if (!string.IsNullOrEmpty(source) && !result.Sources.IsNullOrEmpty())
                                {
                                    isFinalStep = true;
                                }
                            }
                        }
                    }                    

                    result.ShowYearDropDown = result.CurrentStep == 1 || isFinalStep;
                    result.ShowTreatmentDropDown = result.CurrentStep == 2 || isFinalStep;
                    result.ShowAgeDropDown = result.CurrentStep == 3 || isFinalStep;
                    result.ShowSourceDropDown = result.CurrentStep == 4 || isFinalStep;

                }
            }            

            return result;
        }
        
        public ClinicStatsViewModel GetViewModel(int clinicId, string year, string age, string treatment, string source, CaFCConstants.StatsTreatmentType statsType)
        {
            ClinicStatsViewModel result = new ClinicStatsViewModel()
            {
                ClinicId = clinicId,
                ProfilePageUrl = this.urlHelper.GetPageUrl(clinicId)
            };

            if (clinicId > 0)
            {
                ClinicStatsDataSet data = this.dataReader.GetClinicStats(clinicId, year, age, treatment, source);
                result.ClinicName = data?.CentreName;
                if (data?.FullDataSet != null)
                {
                    result.StatsParameters = this.MapSearchFiltersData(data.Id, data.FullDataSet?.SuccessRateBreakdown, statsType);
                    result.GenericStatsData = this.GetGenericStatsViewModel(data.FullDataSet);
                    result.TreatmentStatsData = this.GetTreatmentStatsViewModel(data.FullDataSet);

                    result.ClinicVsNationalComparisonData = this.GetComparisonStatsViewModel(data.FullDataSet, statsType);
                    if (result.ClinicVsNationalComparisonData != null)
                    {
                        result.ClinicVsNationalComparisonData.StatsParameters = result.StatsParameters;
                    }

                    result.AgeStatsData = this.GetAgeStatsViewModel(data.FullDataSet);
                }
            }

            return result;
        }

        private List<StatsApiSearchFilters> GetAvailableFilters(int clinicId)
        {
            List<StatsApiSearchFilters> result = null;

            var data = this.dataReader.GetClinicSearchFilters(clinicId);
            if (data != null && data.AvailableDataCombinations != null)
            {
                result = data.AvailableDataCombinations
                        .Select(x => this.MapSearchFiltersData(clinicId, x))
                        .ToList();
            }

            return result;
        }

        private ClinicStatsGenericViewModel GetGenericStatsViewModel(FullStatsDataSet data)
        {
            ClinicStatsGenericViewModel result = null;

            if (data != null)
            {
                result = new ClinicStatsGenericViewModel();

                var allChartData = this.MapToGenericStatsItemList(data.ChartData);

                if (allChartData != null)
                {
                    result.EmbryoTransferredAverage = allChartData
                        .FirstOrDefault(x => x.Type == EmbryoTransferNumberKey);
                    result.ChartData = allChartData
                        .Where(x => x.Type != EmbryoTransferNumberKey)
                        .ToList();
                }

                
                result.TopRowDataList = this.MapToGenericStatsItemList(data.OverviewOfCycles);
            }

            return result;
        }

        private ClinicStatsTreatmentViewModel GetTreatmentStatsViewModel(FullStatsDataSet data)
        {
            ClinicStatsTreatmentViewModel result = null;

            if (data != null)
            {
                result = new ClinicStatsTreatmentViewModel();

                result.CancellationBeforeCollectionData = this.MapToGenericStatsItemList(data.NumberOfCyclesCancelledBeforeEggsWereCollected);
                result.CancellationBeforeTransferData = this.MapToGenericStatsItemList(data.NumberOfCyclesCancelledBetweenEggCollectionAndEmbryoTransfer);
                result.EmbryosTransferredData = this.MapToGenericStatsItemList(data.NumberOfEmbryosTransferred);
            }


            return result;
        }

        private ClinicStatsVsNationalViewModel GetComparisonStatsViewModel(FullStatsDataSet data, CaFCConstants.StatsTreatmentType statsType)
        {
            ClinicStatsVsNationalViewModel result = null;
            
            if (data != null)
            {
                result = new ClinicStatsVsNationalViewModel();
                result.CurrentTreatmentType = statsType;

                if (!data.PregnanciesAndLiveBirthsPerTreatmentCycle.IsNullOrEmpty())
                {
                    result.PerCycleDataList = new List<StatsDetailStatisticsItem>();
                    data.PregnanciesAndLiveBirthsPerTreatmentCycle
                        .ForEach(x => {
                            var tmp = this.MapToDetailsItemOrNull(x);
                            if (tmp != null) result.PerCycleDataList.Add(tmp);
                        });
                }

                if (!data.PregnanciesAndLiveBirthsPerEmbryoTransferred.IsNullOrEmpty())
                {
                    result.PerEmbryoDataList = new List<StatsDetailStatisticsItem>();
                    data.PregnanciesAndLiveBirthsPerEmbryoTransferred
                        .ForEach(x => {
                            var tmp = this.MapToDetailsItemOrNull(x);
                            if (tmp != null) result.PerEmbryoDataList.Add(tmp);
                        });
                }
            }

            return result;
        }

        private List<Tuple<string, string, string>> GetAgeStatsViewModel(FullStatsDataSet data)
        {
            List<Tuple<string, string, string>> result = null;

            if (data != null && !data.AgeSplitOfPatients.IsNullOrEmpty())
            {
                result = data.AgeSplitOfPatients
                    .Select(x =>
                        new Tuple<string, string, string>(x.DisplayLabel, x.ClinicPercentage, x.NationalPercentage))
                    .ToList();
            }

            return result;
        }

        private bool TryGetNumber(string input, out float num)
        {
            bool result = false;
            num = 0f;

            Match foundNumber = null;

            result = !string.IsNullOrEmpty(input)
                && (foundNumber = Regex.Match(input, @"\d+(\.\d+)?")).Success
                && float.TryParse(foundNumber.Value, out num);

            return result;
        }

        private List<GenericStatsItem> MapToGenericStatsItemList(IEnumerable<StatsDataItemShort> data)
        {
            List<GenericStatsItem> result = null;

            if (!data.IsNullOrEmpty())
            {
                result = new List<GenericStatsItem>();

                foreach (var item in data)
                {
                    float number;
                    this.TryGetNumber(item.Number, out number);
                    result.Add(new GenericStatsItem()
                    {
                        Type = item.Type,
                        Number = Math.Round(number, 2),
                        ValueOriginal = item.Number,
                        Text = item.DisplayLabel
                    });
                }
            }

            return result;
        }

        private StatsDetailStatisticsItem MapToDetailsItemOrNull(StatsDataItem x)
        {
            StatsDetailStatisticsItem result = null;

            float likeliness = 0, avg = 0, rangeMin = 0, rangeMax = 0;
                       
            var rangeMatches = Regex.Matches(x.PredictedSuccessChanceRange ?? string.Empty, @"\d+(?=%)");

            // boolean isSuccessConversion is no longer used but may be used in future
            // it can be removed 
            bool isSuccessConversion =
                this.TryGetNumber(x.PredictedSuccessMostLikely, out likeliness)
                & this.TryGetNumber(x.NationalPercentage, out avg)
                & rangeMatches.Count == 2
                && this.TryGetNumber(rangeMatches[0].Value, out rangeMin)
                && this.TryGetNumber(rangeMatches[1].Value, out rangeMax);
            
            result = new StatsDetailStatisticsItem()
            {
                NationalComparisonSuccessTitle = x.DisplayLabel,
                NationalComparisonSuccessCountString = x.SuccessNumber,
                ClinicSuccessLikelinessTitle = x.PredictedSuccessMostLikelyLabel,
                CompareToAverageString = x.NationalCompare,
                ClinicRate = (int)likeliness,
                ReliabilityRangeMin = (int)rangeMin,
                ReliabilityRangeMax = (int)rangeMax,
                NationalAverage = (int)avg,
                CompareToAverage = !string.IsNullOrEmpty(x.NationalCompare) && this.StatsCompareDictionary.ContainsKey(x.NationalCompare)
                        ? this.StatsCompareDictionary[x.NationalCompare]
                        : CaFCConstants.ComparableToAverage.Unknown
            };

            result.IsWorseThanAverage =
                (this.StatsWithReverseNumbers.Contains(x.Type)
                    && result.CompareToAverage == CaFCConstants.ComparableToAverage.Above
                    && result.ClinicRate > result.NationalAverage)
                || (result.CompareToAverage == CaFCConstants.ComparableToAverage.Below
                    && result.ClinicRate < result.NationalAverage);

            var successCountMatches = Regex.Matches(x.SuccessNumber ?? string.Empty, @"\d+");
            if (successCountMatches.Count == 2)
            {
                result.NationalComparisonSuccessCount = int.Parse(successCountMatches[0].Value);
                result.NationalComparisonTotalCount = int.Parse(successCountMatches[1].Value);
            }

            return result;
        }

        private IEnumerable<StatsApiSearchFilters> GetFilter(
                    IEnumerable<StatsApiSearchFilters> data,                    
                    Func<StatsApiSearchFilters, IdValuePair> propertySelector,
                    Func<StatsApiSearchFilters, IdValuePair> filterSelector,
                    string filterValue,
                    out List<IdValuePair> distictValues)
        {
            distictValues = null;
            if (data != null)
            {
                if (!string.IsNullOrEmpty(filterValue))
                {
                    data = data.Where(x => filterSelector(x).Id == filterValue);
                }

                distictValues = data
                        .Select(x => propertySelector(x))
                        .DistinctBy(x => x.Id)
                        .ToList();
            }

            return data;
        }  

        private StatsFullFilters MapSearchFiltersData(int clinicId, SearchFilterSet data, CaFCConstants.StatsTreatmentType statsType)
        {
            var mapped = (StatsFullFilters)this.MapSearchFiltersData(clinicId, data);
            if (mapped != null)
            {
                mapped.TreatmentType = statsType;
            }

            return mapped;
        }

        private StatsApiSearchFilters MapSearchFiltersData(int clinicId, SearchFilterSet rawData)
        {
            StatsFullFilters result = null;
            if (rawData != null)
            {
                result = new StatsFullFilters()
                {
                    ClinicId = clinicId,
                    Age = rawData.Age.ToIdValuePair(),
                    Source = rawData.Source.ToIdValuePair(),
                    Treatment = rawData.Treatment.ToIdValuePair(),
                    Year = rawData.Year.ToIdValuePair(),
                };
            }

            return result;
        }
    }
}
