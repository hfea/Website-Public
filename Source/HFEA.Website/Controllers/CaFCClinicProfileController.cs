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
    public class CaFCClinicProfileController : RenderMvcController
    {
        private readonly ICaFCProfileModelCreator modelUtility;

        public CaFCClinicProfileController(ICaFCProfileModelCreator modelCreator)
        {
            this.modelUtility = modelCreator;
        }

        public ActionResult CaFCClinicProfile(RenderModel model, int? clinicId)
        {
             var template = this.ControllerContext.RouteData.Values["action"].ToString();

            if (clinicId == null || clinicId == 0)
            {
                return new HttpNotFoundResult();
            }


            var data = modelUtility.GetViewModel(clinicId.Value);
            if (!data.IsValidModel)
            {
                return new HttpNotFoundResult();
            }

            var adaptedData = new RenderModelAdapter<CaFCProfileViewModel>(model.Content, data);            
            return View(template, adaptedData);
        }
    }
}
