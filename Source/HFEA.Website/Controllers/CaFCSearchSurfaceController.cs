using HFEA.Web.Constants;
using HFEA.Web.Helpers;
using HFEA.Web.Utilities;
using HFEA.Web.ViewModel.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class CaFCSearchSurfaceController : SurfaceController
    {
        private const string DynamicFiltersView = "~/Views/CaFCSearch/SearchFilters.cshtml";
        private const string DynamicResultsFiltersView = "~/Views/CaFCSearch/SearchResultsFilters.cshtml";

        private CaFC.QueryString LocationQry = CaFC.QueryString.location;
        private CaFC.QueryString DistanceQry = CaFC.QueryString.distance;
        private CaFC.QueryString PageQry = CaFC.QueryString.page;
        //private CaFC.QueryString PageSizeQry = CaFC.QueryString.pageSize;
        private CaFC.QueryString SortQry = CaFC.QueryString.sort;
        private CaFC.QueryString OptionsQry = CaFC.QueryString.options;

        private readonly ICaFCSearchFiltersModelCreator modelUtility;
        private readonly ICafcQueryStringHelper qryHelper;
        private readonly ICafcProfileUrlHelper profileUrlHelper;

        public CaFCSearchSurfaceController(ICaFCSearchFiltersModelCreator modelCreator, 
            ICafcQueryStringHelper queryStringHelper, 
            ICafcProfileUrlHelper profileUrlHelper)
        {
            this.modelUtility = modelCreator;
            this.qryHelper = queryStringHelper;
            this.profileUrlHelper = profileUrlHelper;
        }

        // GET: CaFCSearch
        public ActionResult Index()
        {    
            return View();
        }

        [ChildActionOnly]
        public ActionResult SearchFilters()
        {
            var filterValues = this.GetFiltersFromQuery();
            var filters = this.modelUtility.GetCaFCFiltersViewModel(filterValues);

            return PartialView(DynamicFiltersView, filters);
        }
        [ChildActionOnly]
        public ActionResult SearchResultFilters()
        {
            var filterValues = this.GetFiltersFromQuery();
            var filters = this.modelUtility.GetCaFCFiltersViewModel(filterValues);

            return PartialView(DynamicResultsFiltersView, filters);
        }

        [HttpPost]
        public ActionResult SearchFiltersSubmit(CaFCFiltersViewModel filter)
        {
            var resultsPage = CurrentPage.Children.Where(x => x.DocumentTypeAlias == Core.Config.Settings.KeyDocTypes.CaFCSearchResults).FirstOrDefault();
            return RedirectToUmbracoPage(resultsPage.Id, this.qryHelper.GetQueryString(filter));
        }
        [HttpPost]
        public ActionResult SearchResultsFiltersSubmit(CaFCFiltersViewModel filter)
        {
            return RedirectToUmbracoPage(CurrentPage.Id, this.qryHelper.GetQueryString(filter));
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
