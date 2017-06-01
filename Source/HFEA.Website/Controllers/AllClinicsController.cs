using HFEA.Web.Utilities;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.CaFC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class AllClinicsController : RenderMvcController
    {
        private readonly ICaFCSearchResultsModelCreator searchUtility;
        public AllClinicsController(ICaFCSearchResultsModelCreator search)
        {
            this.searchUtility = search;
        }

        public ActionResult AllClinics(RenderModel model, string alpha)
        {
            var template = this.ControllerContext.RouteData.Values["action"].ToString();

            SearchParameters parameter = new SearchParameters()
            {
                FirstLetter = !string.IsNullOrEmpty(alpha) ? alpha[0] : 'a',
                PageSize = 100
            };

            CaFCSearchViewModel data = this.searchUtility.GetCaFCResultsViewModel(parameter);
            var modelData = new RenderModelAdapter<List<ClinicItem>>(model.Content, data?.ClinicList);
            return View(template, modelData);
        }
    }
}