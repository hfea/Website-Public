using HFEA.Web.Constants;
using HFEA.Web.Helpers;
using HFEA.Web.Utilities;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.COP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class CaFCStatisticsController : RenderMvcController
    {
        private readonly IClinicStatsModelCreator modelUtility;

        public CaFCStatisticsController(IClinicStatsModelCreator modelCreator)
        {
            this.modelUtility = modelCreator;
        }

        public ActionResult CaFCStatistics(RenderModel model, int? clinicId, string year, string age, string treatment, string source, string type)
        {
             var template = this.ControllerContext.RouteData.Values["action"].ToString();

            if (clinicId == null || clinicId == 0)
            {
                return new HttpNotFoundResult();
            }

            var data = modelUtility.GetViewModel(clinicId.Value, year, age, treatment, source, ViewModel.Constants.CaFCConstants.StatsTreatmentType.PerEmbryoTransferred);
            if (data == null)
            {
                return new HttpNotFoundResult();
            }

            var adaptedData = new RenderModelAdapter<ClinicStatsViewModel>(model.Content, data);            
            return View(template, adaptedData);
        }
    }
}
