
using HFEA.BL.Contracts;
using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace HFEA.BL.Readers
{
    public class CaFCSearchModelCreator : ICaFCSearchResultsModelCreator, ICaFCSearchFiltersModelCreator, ICaFCNameSearchModelCreator
    {
        // default sorting parameter is by Clinic Name in Ascending order which corresponds
        // to value "1" in the API
        private const int DefaultSortingParameter = 1;
        private const string DefaultDistance = "25";
        private const string Separator = ",";
        public const string SelectDistanceOption = "Within {0} mile{1}";
        private readonly KeyValuePair<string, string> SelectDistanceFirstValue = new KeyValuePair<string, string>("select distance" , "0");
        // private readonly KeyValuePair<string, string> SelectDistanceAll = new KeyValuePair<string, string>("Whole of mainland UK", string.Empty);

        private readonly ICaFCSearch cafcClient;
        private readonly ICafcProfileUrlHelper urlHelper;
        private readonly IJsonSerializer serializer;
        
       // private CaFCNameSearchViewModel cafcNameSearchViewModel;
        private CaFCSearchViewModel cafcResultsViewModel;
        private CaFCFiltersViewModel cafcFiltersViewModel;

        public CaFCSearchModelCreator(ICaFCSearch cafcSearchClient, ICafcProfileUrlHelper profileUrlHelper, IJsonSerializer jsonSerializer)
        {
            if (cafcSearchClient == null) throw new ArgumentNullException("Search client is not provided");
            if (profileUrlHelper == null) throw new ArgumentNullException("Url helper is not provided");
            if (jsonSerializer == null) throw new ArgumentNullException("JSON serializer is not provided");

            this.cafcClient = cafcSearchClient;
            this.urlHelper = profileUrlHelper;
            this.serializer = jsonSerializer;
        }

        public CaFCFiltersViewModel GetCaFCFiltersViewModel(SearchParameters filters)
        {
            this.cafcFiltersViewModel = this.GetFilterObject(filters);
            
            return this.cafcFiltersViewModel;
        }

        public List<IdValueDescription> GetClinicNameAutocompleteValues()
        {
            var result = new List<IdValueDescription>();
            var data = this.cafcClient.GetAllClinicList();

            if (data != null)
            {
                result = data.Select(x => new IdValueDescription()
                {
                     Id = x.Id.ToString(),
                     Value = x.CentreName,
                     Description = this.urlHelper.GetPageUrl(x.Id)
                }).ToList();
            }

            return result;
        }

        public CaFCSearchViewModel GetCaFCResultsViewModel(SearchParameters filters)
        {
            if (this.cafcResultsViewModel == null)
            {
                Func<string, int> getIntOrZero = (x) =>
                {
                    int tmp;
                    int.TryParse(x, out tmp);
                    return tmp;
                };

                SearchResults searchData = this.cafcClient.GetClinicList(filters.Source, filters.Distance, filters.FirstLetter, filters.Options, filters.PageSize, filters.PageNumber, filters.Sort);

                this.cafcResultsViewModel = new CaFCSearchViewModel()
                {
                    ClinicList = this.GetClinicList(searchData),
                    SortingParameter = DefaultSortingParameter,
                    Location = searchData.SubmittedSearchParameters.ShowingResultsFor,
                    Distance = getIntOrZero(searchData.SubmittedSearchParameters.Radius),
                    MapDataList = this.GetMapDataList(searchData)
                    
                };

                this.cafcResultsViewModel.MapDataJSON = this.serializer.Serialize(this.cafcResultsViewModel.MapDataList);

                if (!string.IsNullOrEmpty(searchData.SubmittedSearchParameters.Sort))
                {
                    this.cafcResultsViewModel.SortingParameter = getIntOrZero(searchData.SubmittedSearchParameters.Sort);
                }

                if (!string.IsNullOrEmpty(searchData.SubmittedSearchParameters.Options))
                {
                    List<int> idList = new List<int>();

                    searchData.SubmittedSearchParameters
                        .Options.Split(new string[] { Separator }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList()
                        .ForEach(x => idList.Add(getIntOrZero(x)));

                    var allParams = this.GetDynamicFilters();

                    var list = allParams
                        .SelectMany(x => x.ItemList)
                        .Where(x => idList.Contains(x.Id))
                        .Select(x => x.Label)
                        .ToList();

                    this.cafcResultsViewModel.FilterTreatmentList = list;
                }

                this.cafcResultsViewModel.PaginationData = new Web.ViewModel.PaginationModel()
                {
                    Page = getIntOrZero(searchData.SubmittedSearchParameters.PageNumber),
                    PageSize = getIntOrZero(searchData.SubmittedSearchParameters.PageSize),
                    TotalRecords = getIntOrZero(searchData.SubmittedSearchParameters.NumberOfResults)
                };
            }

            return this.cafcResultsViewModel;
        }

        private CaFCFiltersViewModel GetFilterObject(SearchParameters selectedOptions)
        {
            var filters = this.GetFilterObject();

            if (selectedOptions != null)
            {
                filters.Location = selectedOptions.Source;
                filters.Distance = selectedOptions.Distance?.ToString();
               
                var distanceObject = filters.DistanceOptionsList
                    .FirstOrDefault(x => x.Value == (string.IsNullOrEmpty(filters.Distance) ? DefaultDistance : filters.Distance));

                if (distanceObject != null)
                {
                    distanceObject.Selected = true;
                }

                if (selectedOptions.Options != null)
                {
                    foreach(int optionId in selectedOptions.Options)
                    {
                        foreach(var dynamicFilter in filters.DynamicFilters)
                        {
                            foreach(var item in dynamicFilter.ItemList)
                            {
                                if (item.Id == optionId)
                                {
                                    item.Value = true;
                                    goto ContinueMainLoop;
                                }
                            }
                        }

                        ContinueMainLoop: { }
                    }
                }
            }

            return filters;
        }

        private CaFCFiltersViewModel GetFilterObject()
        {
            var filters = new CaFCFiltersViewModel()
            {
                Location = string.Empty,
                Distance = string.Empty, // this.SelectDistanceAll.Value,
                DynamicFilters = this.GetDynamicFilters(),
                DistanceOptionsList = this.GetDistanceOptionList()                  
            };
            
            return filters;
        }

        private List<SelectListItem> GetDistanceOptionList()
        {
            var result = new List<SelectListItem>();
            var options = new int[] { 1, 2, 3, 4, 5, 10, 15, 25, 50, 100, 150, 250, 500 };

            result.Add(new SelectListItem() { Text = SelectDistanceFirstValue.Key, Value = SelectDistanceFirstValue.Value });
            foreach (int distance in options)
            {
                result.Add(new SelectListItem()
                {
                    Text = string.Format(SelectDistanceOption, distance, distance != 1 ? "s" : string.Empty),
                    Value = distance.ToString(),
                    Selected = false
                });
            }

            // result.Add(new SelectListItem() { Text = SelectDistanceAll.Key, Value = SelectDistanceAll.Value });
            
            return result;
        }

        private List<ClinicItem> GetClinicList(SearchResults data)
        {
            var result = new List<ClinicItem>();

            if (data != null && data.CentreSearchResultItems != null)
            {
                foreach (var clinic in data.CentreSearchResultItems)
                {
                    var clinicItem = new ClinicItem();

                    clinicItem.Id = clinic.Id;
                    clinicItem.CentreName = clinic.CentreName;
                    clinicItem.MainPhoneNumber = clinic.MainPhoneNumber;
                    clinicItem.CentreType = clinic.CentreType;
                    clinicItem.CentreTypeDescription = clinic.CentreTypeDescription;
                    clinicItem.DistanceFromSource = Math.Round(clinic.DistanceFromSource, 2);
                    clinicItem.IndicativeSuccessRate = clinic.IndicativeSuccessRate;
                    clinicItem.IndicativeSuccessRateCaveat = clinic.IndicativeSuccessRateCaveat;
                    clinicItem.NationalSuccessRate = clinic.NationalAverage;
                    clinicItem.InspectionRating = clinic.InspectionRating;
                    clinicItem.NumberOfUserReviews = clinic.NumberOfUserReviews;
                    clinicItem.UserRating = clinic.UserRating;
                    clinicItem.Town = clinic.Town;

                    int tmp;
                    Match match;
                    if (!string.IsNullOrEmpty(clinic.IndicativeSuccessRate)
                        && (match = Regex.Match(clinic.IndicativeSuccessRate, @"\d+")).Success
                        && int.TryParse(match.Value, out tmp))
                    {
                        clinicItem.ClinicSuccessRateValue = tmp;
                    }

                    if (clinic.Links != null && clinic.Links.Any())
                    {
                        clinicItem.IsSatelliteOrTransportClinic = true;
                        clinicItem.LinkItemList = clinic.Links
                            .Select(x => this.LinkToLinkItem(x))
                            .ToList();
                    }
                    else
                    {
                        clinicItem.ProfilePageUrl = this.urlHelper.GetPageUrl(clinic.Id);
                    }

                    clinicItem.ImageUrl = clinic.ProfileImageURL;
                    
                    if (clinic.EligibilityAndFunding != null && clinic.EligibilityAndFunding.Any())
                    {
                        clinicItem.IsNhsClinic = clinic.EligibilityAndFunding.Any(x => x.Id == (int)CaFCConstants.EligibilityAndFunding.NHS);
                        clinicItem.IsPrivateClinic = clinic.EligibilityAndFunding.Any(x => x.Id == (int)CaFCConstants.EligibilityAndFunding.Private);
                    }

                    clinicItem.TreatmentDictionary = clinic.TreatmentsOffered.ToDictionary(x => x.Id, x => x.Name);

                    if (clinic.Staffing != null && clinic.Staffing.Any())
                    {
                        clinicItem.IsFemaleDoctorAvailable = clinic.Staffing.Any(x => x.Id == (int)CaFCConstants.Staffing.FemaleDoctorAvailable);
                        clinicItem.HasNamedNurseSystem = clinic.Staffing.Any(x => x.Id == (int)CaFCConstants.Staffing.NamedNurseSystem);
                    }
                    clinicItem.GenericTreatmentTitle = clinic.IndicativeSuccessRateTitle;
                    result.Add(clinicItem);
                }
            }

            return result;
        }

        private List<MapInformation> GetMapDataList(SearchResults data)
        {
            var result = new List<MapInformation>();

            if (data != null && data.CentreSearchResultMapItems != null)
            {
                result = data.CentreSearchResultMapItems.Select(x => new MapInformation()
                {
                    Id = x.CentreId,
                    PinTitle = x.CentreName,
                    PinText = x.CentreType,
                    Lat = x.Lat.ToString(),
                    Long = x.Lng.ToString(),
                    ProfileUrl = x.CentreType != null ? this.urlHelper.GetPageUrl(x.CentreId) : string.Empty,
                    LinkList = x.Links.Select(l => this.LinkToMapPinLinkItem(l)).ToList()
                }).ToList();
            }

            return result;
        }

        private List<DynamicFilter> GetDynamicFilters()
        {
            var result = new List<DynamicFilter>();

            var allFilters = this.cafcClient.GetSearchTerms();

            if (allFilters != null && allFilters.CollectionNames != null && allFilters.CollectionNames.Any())
            {
                foreach(var filter in allFilters.CollectionNames)
                {
                    result.Add(this.GetDynamicFilterByType(filter.Key, allFilters));
                }
            }
            
            return result;
        }

        private DynamicFilter GetDynamicFilterByType(string filterType, SearchFilters data)
        {
            DynamicFilter result = null;

            var items = new List<FilterItem<bool>>();
            string title = string.Empty;

            CaFCConstants.DynamicFilterType type;

            if (Enum.TryParse<CaFCConstants.DynamicFilterType>(filterType, out type) 
                && data != null && data.CollectionNames.Any(x => x.Key == type.ToString()))
            {
                result = new DynamicFilter()
                {
                    Type = type,
                    Title = data.CollectionNames.First(x => x.Key == type.ToString()).Value                
                };
                
                switch (type)
                {
                    case CaFCConstants.DynamicFilterType.CounsellingAndSupport:
                        data.CounsellingAndSupport.ForEach(x => items.Add(new FilterItem<bool>() { Id = x.Id, Label = x.Name }));
                        break;
                    case CaFCConstants.DynamicFilterType.DonorRecruitment:
                        data.DonorRecruitment.ForEach(x => items.Add(new FilterItem<bool>() { Id = x.Id, Label = x.Name }));
                        break;
                    case CaFCConstants.DynamicFilterType.EligibilityAndFunding:
                        data.EligibilityAndFunding.ForEach(x => items.Add(new FilterItem<bool>() { Id = x.Id, Label = x.Name }));
                        break;
                    //case CaFCConstants.DynamicFilterType.NonLicensedTreatmentsAndServices:
                    //    data.NonLicensedTreatmentsAndServices.ForEach(x => items.Add(new FilterItem<bool>() { Id = x.Id, Label = x.Name }));
                    //    break;
                    case CaFCConstants.DynamicFilterType.ScreeningServices:
                        data.ScreeningServices.ForEach(x => items.Add(new FilterItem<bool>() { Id = x.Id, Label = x.Name, Description = x.Description }));
                        break;
                    case CaFCConstants.DynamicFilterType.Treatments:
                        data.Treatments.ForEach(x => items.Add(new FilterItem<bool>() { Id = x.Id, Label = x.Name, Description = x.Description }));
                        break;
                    default:
                        break;
                }

                result.ItemList = items;
            }

            return result;
        }   

        private LinkItem LinkToLinkItem(Link link)
        {
            if (link != null)
            {
                return new LinkItem()
                {
                    ClinicId = link.ParentCentreId,
                    ClinicName = link.ParentCentreName,
                    Url = this.urlHelper.GetPageUrl(link.ParentCentreId),
                    Type = (CaFCConstants.ClinicType)link.LinkType
                };
            }

            return null;
        }

        private MapPinLinkItem LinkToMapPinLinkItem(Link link)
        {
            if (link != null)
            {
                return new MapPinLinkItem()
                {
                    ClinicName = link.ParentCentreName,
                    Url = this.urlHelper.GetPageUrl(link.ParentCentreId),
                    Type = ((CaFCConstants.ClinicType)link.LinkType).ToString()
                };
            }

            return null;
        }
    }
}
