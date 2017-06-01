using HFEA.BL.Contracts.Constants;
using HFEA.BL.Contracts.Search;
using HFEA.Connector.Contracts.Clients.AccessControl;
using HFEA.Core.Extensions;
using HFEA.Web.ViewModel;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.COP;
using HFEA.Web.ViewModel.Search;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace HFEA.BL.ModelCreators
{
    public class SearchModelCreator : ISearchViewModelReader
    {
        private const string DateValueFormat = "MMyyyy"; // This value must be same as in the controller
        private const string DateLabelFormat = "MMMM";
        private const string SearchBoxLabel = "Search";
        private const string SearchButtonLabel = "Search"; 

        private readonly string[] separator = new string[] { "," };
        private readonly IHfeaSearcher searcher;
        private readonly ICOPUrlResolver urlResolver;
        private readonly Web.ViewModel.CaFC.ICafcProfileUrlHelper clinicProfileUrlResolver;
        private readonly ICmsUrlResolver cmsUrlResolver;

        private readonly List<Connector.Contracts.Api.ContentTag> tagsList;
        private readonly List<Connector.Contracts.Api.ContentTag> productTagsList;

        public SearchModelCreator(IHfeaSearcher searchUtility, ITagsReader contentTagsReader, ICOPUrlResolver refDataUrlResolver, Web.ViewModel.CaFC.ICafcProfileUrlHelper clinicPageUrlResolver, ICmsUrlResolver cmsContentUrlResolver)
        {
            if (searchUtility == null) throw new ArgumentNullException("Search utility is null");
            if (contentTagsReader == null) throw new ArgumentNullException("Tags reader is null");
            if (refDataUrlResolver == null) throw new ArgumentNullException("Url resolver is null");
            if (clinicPageUrlResolver == null) throw new ArgumentNullException("CaFC url resolver is null");
            if (cmsContentUrlResolver == null) throw new ArgumentNullException("Reference url resolver is null");
            this.searcher = searchUtility;
            this.urlResolver = refDataUrlResolver;
            this.clinicProfileUrlResolver = clinicPageUrlResolver;
            this.cmsUrlResolver = cmsContentUrlResolver;

            this.tagsList = contentTagsReader.GetContentTagList();
            this.productTagsList = contentTagsReader.GetWebsiteProductTagList();
        }

        public SearchBoxViewModel GetSearchBoxViewModel(SearchParameters searchParams)
        {
            var validContentTags = this.GetTagsList(searchParams.ContentTagsValue);
            var productTags = this.productTagsList != null
                ? this.productTagsList.Select(x => new ContentTagValue()
                {
                    Id = x.Id,
                    Value = x.Description,
                    IsChecked = searchParams.ProductFilters != null && searchParams.ProductFilters.Any(pt => pt.Id == x.Id && pt.IsChecked)
                }).ToList()
                : null;

            string contentTagValues = validContentTags != null && validContentTags.Any()
                ? string.Join(separator[0], validContentTags.Select(x => x.Id))
                : string.Empty;

            return new SearchBoxViewModel()
            {
                SearchParams = new SearchParameters()
                {
                    SearchKeywords = searchParams.SearchKeywords,
                    ProductFilters = productTags,
                    ContentTags = validContentTags,
                    ContentTagsValue = contentTagValues
                },
                SearchBoxLabel = SearchBoxLabel,
                SearchButtonLabel = SearchButtonLabel
            };
        }
        private bool TryGetFilterDate(string date, out DateTime parsedDate)
        {
            return DateTime.TryParseExact(date, DateValueFormat, null, DateTimeStyles.None, out parsedDate);
        }

        public SearchViewModel GetViewModel(SearchParameters searchParams, int page, int pageSize)
        {
            SearchViewModel viewModel = null;

            var productTags = searchParams?.ProductFilters != null ? searchParams.ProductFilters.Where(x => x.IsChecked) : null;
            var contentTags = this.GetTagsList(searchParams?.ContentTagsValue);
            var filters = new SearchFilters()
            {
                SearchKeywords = searchParams?.SearchKeywords,
                ProductTagIds = searchParams?.ProductFilters != null ? searchParams.ProductFilters.Where(x => x.IsChecked).Select(x => x.Id).ToList() : null,
                ContentTagIds = contentTags != null ? contentTags.Select(x => x.Id).ToList() : null
            };

            bool hasSearchParameters = !string.IsNullOrEmpty(filters.SearchKeywords)
                || !filters.ProductTagIds.IsNullOrEmpty()
                || !filters.ContentTagIds.IsNullOrEmpty();

            if (hasSearchParameters)
            {
                var searchResults = this.searcher.Search(filters);
                var mapped = this.MapToSearchResultItemList(searchResults);
                var dates = mapped.Select(x => x.PublishDate).ToList();

                DateTime filterDate;
                if (!string.IsNullOrEmpty(searchParams.FilterDate)
                    && this.TryGetFilterDate(searchParams.FilterDate, out filterDate)
                    && filterDate != DateTime.MinValue)
                {
                    mapped = mapped
                        .Where(x => x.PublishDate >= filterDate && x.PublishDate <= filterDate.AddMonths(1))
                        .ToList();
                }

                var paginatedList = mapped.ToPagedList(page, pageSize);

                // update URL
                for (int i = 0; i < paginatedList.Count; i++)
                {
                    paginatedList[i].Url = this.GetItemUrl(paginatedList[i].Id, paginatedList[i].Source);
                }


                viewModel = new SearchViewModel()
                {
                    ResultList = paginatedList,
                    SearchParameters = this.GetSearchBoxViewModel(searchParams),
                    DateFilters = this.GetDateFilterModel(dates)
                };
            }

            return viewModel;
        }
        private List<SearchResultItem> MapToSearchResultItemList(List<ISearchResultItem> data)
        {
            var result = new List<SearchResultItem>();

            if (data != null)
            {
                result = data.Select(x => new SearchResultItem()
                {
                    Id = x.Id.ToString(),
                    Title = x.Title,
                    Summary = x.Summary,
                    ContentTagList = this.GetContentTagsList(x.Tags),
                    ProductTagList = this.GetContentTagsList(x.ProductTags),
                    Source = x.SourceType,
                    PublishDate = x.PublishDate,
                    Url = x.Url
                }).ToList();
            }

            return result;
        }

        private List<SelectFilterGroup> GetDateFilterModel(List<DateTime> allDates)
        {
            List<SelectFilterGroup> result = new List<SelectFilterGroup>();

            if (allDates != null && allDates.Any(x => x.Date != DateTime.MinValue))
            {
                var years = allDates
                    .Where(x => x.Date != DateTime.MinValue)
                    .Select(x => x.Year).Distinct()
                    .OrderBy(x => x)
                    .ToList();

                foreach (int year in years)
                {
                    var yearMonthsList = allDates
                        .Where(x => x.Year == year)
                        .Select(x => new DateTime(year, x.Month, 1))
                        .Distinct()
                        .OrderBy(x => x)
                        .Select(x => new SelectFilterItem()
                        {
                            Value = x.ToString(DateValueFormat),
                            Text = x.ToString(DateLabelFormat)
                        })
                        .ToList();

                    var group = new SelectFilterGroup()
                    {
                        GroupTitle = year.ToString(),
                        FilterItemList = yearMonthsList
                    };

                    result.Add(group);
                }
            }

            return result;
        }

        private List<ContentTag> GetTagsListByStringOfIds(string tags)
        {
            return this.GetTagsList(tags);
        }

        private List<ContentTag> GetContentTagsList(List<int> idList)
        {
            List<ContentTag> result = null;

            if (idList != null)
            {
                result = idList
                    .Select(x => this.GetContentTagById(x))
                    .Where(x => x != null)
                    .ToList();
            }

            return result;
        }

        private List<ContentTag> GetProductTagsList(List<int> idList)
        {
            List<ContentTag> result = null;

            if (idList != null)
            {
                result = idList
                    .Select(x => this.GetProductTagById(x))
                    .Where(x => x != null)
                    .ToList();
            }

            return result;
        }

        private List<ContentTag> GetTagsList(string tags)
        {
            List<ContentTag> result = null;

            if (!string.IsNullOrEmpty(tags))
            {
                result = tags
                    .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => this.GetContentTagById(x))
                    .Where(x => x != null)
                    .ToList();
            }

            return result;
        }

        private ContentTag GetContentTagById(string tagId)
        {
            int id;
            if (int.TryParse(tagId, out id))
            {
                return this.GetContentTagById(id);
            }

            return null;
        }

        private ContentTag GetProductTagById(int tagId)
        {
            var tagObj = this.productTagsList != null
                ? this.productTagsList.FirstOrDefault(x => x.Id == tagId)
                : null;

            if (tagObj != null)
            {
                return new ContentTag() { Id = tagObj.Id, Value = tagObj.Description };
            }

            return null;
        }

        private ContentTag GetContentTagById(int tagId)
        {
            var tagObj = this.tagsList != null
                ? this.tagsList.FirstOrDefault(x => x.Id == tagId)
                : null;

            if (tagObj != null)
            {
                return new ContentTag() { Id = tagObj.Id, Value = tagObj.Description };
            }

            return null;
        }

        private string GetItemUrl(string itemId, Search.SearchSource sourceType)
        {
            string result = string.Empty;
            int id = itemId.ToNullableInt().GetValueOrDefault();
            switch (sourceType)
            {
                case Search.SearchSource.CMS:
                    result = this.cmsUrlResolver.GetCmsUrlByContentId(id);
                    break;
                case Search.SearchSource.COP:
                    result = this.urlResolver.GetSectionLink(id);
                    break;
                case Search.SearchSource.Clinic:
                    result = this.clinicProfileUrlResolver.GetPageUrl(id);
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
