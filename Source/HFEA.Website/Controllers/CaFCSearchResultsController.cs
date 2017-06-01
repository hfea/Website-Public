using HFEA.Web.Constants;
using HFEA.Web.Helpers;
using HFEA.Web.Utilities;
using HFEA.Web.ViewModel.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class CaFCSearchResultsController : SurfaceController
    {
        private const string SearchResultsView = "~/Views/CaFCSearch/SearchResults.cshtml";

        private CaFC.QueryString LocationQry = CaFC.QueryString.location;
        private CaFC.QueryString DistanceQry = CaFC.QueryString.distance;
        private CaFC.QueryString PageQry = CaFC.QueryString.page;
        //private CaFC.QueryString PageSizeQry = CaFC.QueryString.pageSize;
        private CaFC.QueryString SortQry = CaFC.QueryString.sort;
        private CaFC.QueryString OptionsQry = CaFC.QueryString.options;

        private readonly ICaFCSearchResultsModelCreator modelUtility;
        private readonly ICafcQueryStringHelper qryHelper;

        public CaFCSearchResultsController(ICaFCSearchResultsModelCreator modelCreator, ICafcQueryStringHelper queryStringHelper)
        {
            this.modelUtility = modelCreator;
            this.qryHelper = queryStringHelper;
        }

        [ChildActionOnly]
        public ActionResult ShowSearchReasults()
        {
            SearchParameters filters = this.GetFiltersFromQuery();

            CaFCSearchViewModel model = this.modelUtility.GetCaFCResultsViewModel(filters);

            model.SearchPageUrl = UrlQueryHelper.AddUpdateQuery(
                CurrentPage.Parent.Url,
                Request.QueryString,
                new string[] { CaFC.QueryString.location.ToString(), CaFC.QueryString.distance.ToString(), CaFC.QueryString.options.ToString() });

            return PartialView(SearchResultsView, model);
        }


        [HttpPost]
        public ActionResult SubmitSortingOptions(int sortBy)
        {
            SearchParameters query = this.GetFiltersFromQuery();
            query.Sort = sortBy;
            string qry = this.qryHelper.GetQueryString(query);

            return RedirectToCurrentUmbracoPage(qry);
        }

        private SearchParameters GetFiltersFromQuery()
        {
            var location = Request.QueryString[LocationQry.ToString()];
            var distance = Request.QueryString[DistanceQry.ToString()];
            var options = Request.QueryString[OptionsQry.ToString()];
            var sort = Request.QueryString[SortQry.ToString()];
            var page = Request.QueryString[PageQry.ToString()];

            // pageSize is not required
            //var pageSize = Request.QueryString[PageSizeQry.ToString()];

            return this.qryHelper.GetFilterValuesFromString(location, distance, options, page, sort);
        }
    }
}
