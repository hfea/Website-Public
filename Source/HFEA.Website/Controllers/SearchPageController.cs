using HFEA.Web.Constants;
using HFEA.Web.ViewModel.Search;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class SearchPageController : SurfaceController
    {
        private const int PageSize = 10;
        private const string Separator = ",";
        private const QueryString.QueryParams SearchQry = QueryString.QueryParams.search;
        private const QueryString.QueryParams ProductTagQry = QueryString.QueryParams.type;
        private const QueryString.QueryParams ContentTagQry = QueryString.QueryParams.tags;
        private const QueryString.QueryParams PageQry = QueryString.QueryParams.page;
        private const QueryString.QueryParams DateQry = QueryString.QueryParams.date;

        private const string SearchFormView = "~/Views/SearchPage/SearchForm.cshtml";
        private const string PageView = "~/Views/SearchPage/SearchResultsPage.cshtml";

        private readonly int SearchPageId = Core.Config.Settings.KeyPages.Search;
        private readonly ISearchViewModelReader reader;

        public SearchPageController(ISearchViewModelReader searchReader)
        {
            if (searchReader == null) throw new ArgumentNullException("Search reader is null");

            this.reader = searchReader;
        }

        [ChildActionOnly]
        public ActionResult GetSearchView(string title)
        {
            var data = this.reader.GetSearchBoxViewModel(this.GetSearchParametersFromQuery());
            data.SearchBoxLabel = title;
            return PartialView(SearchFormView, data);
        }

        [ChildActionOnly]
        public ActionResult GetSearchResults()
        {
            int page = PageQry.GetQryParamValueOrDefault<int>(1);
            SearchViewModel data = this.reader.GetViewModel(this.GetSearchParametersFromQuery(), page, PageSize);
            return PartialView(PageView, data);
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchSubmit(SearchBoxViewModel filter)
        {
            var qry = this.GetSearchQuery(filter?.SearchParams);
            return RedirectToUmbracoPage(SearchPageId, qry);
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DateFilterSubmit([FromBody]string date = "")
        {
            var parameters = this.GetSearchParametersFromQuery();

            parameters.FilterDate = date;

            var query = this.GetSearchQuery(parameters);

            return RedirectToCurrentUmbracoPage(query);
        }

        private SearchParameters GetSearchParametersFromQuery()
        {
            string searchString = SearchQry.GetQryParamValueOrNull();
            string contentTags = ContentTagQry.GetQryParamValueOrNull();
            string productTags = ProductTagQry.GetQryParamValueOrNull();
            string date = DateQry.GetQryParamValueOrNull();

            List<ContentTagValue> selectedProductTags = null;
            if (!string.IsNullOrEmpty(productTags))
            {
                var lst = productTags.Split(new string[] { Separator }, StringSplitOptions.RemoveEmptyEntries);
                if (lst != null && lst.Length > 0)
                {
                    selectedProductTags = new List<ContentTagValue>();

                    int id;
                    foreach (string val in lst)
                    {
                        if (int.TryParse(val, out id))
                        {
                            selectedProductTags.Add(new ContentTagValue() { Id = id, IsChecked = true });
                        }
                    }
                }
            }

            var result = new SearchParameters()
            {
                SearchKeywords = searchString,
                ContentTagsValue = contentTags,
                ProductFilters = selectedProductTags,
                FilterDate = date
            };

            return result;
        }

        private NameValueCollection GetSearchQuery(SearchParameters filter)
        {
            var result = new NameValueCollection();

            if (filter != null)
            {
                result.Add(SearchQry.ToString(), filter.SearchKeywords);

                if (filter.ProductFilters != null && filter.ProductFilters.Where(x => x.IsChecked).Any())
                {
                    var values = filter.ProductFilters.Where(x => x.IsChecked).Select(x => x.Id);
                    result.Add(ProductTagQry.ToString(), string.Join(Separator, values));
                }

                if (!string.IsNullOrEmpty(filter.FilterDate))
                {
                    result.Add(DateQry.ToString(), filter.FilterDate);
                }

                if (!string.IsNullOrEmpty(filter.ContentTagsValue))
                {
                    result.Add(ContentTagQry.ToString(), filter.ContentTagsValue);
                }
            }

            return result;
        }
    }
}