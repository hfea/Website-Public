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
    public class CodeOfPracticeController : RenderMvcController
    {
        private const int DefaultSection = 1;
        private readonly ICOPModelCreator modelUtility;

        public CodeOfPracticeController(ICOPModelCreator modelCreator)
        {
            this.modelUtility = modelCreator;
        }

        public override ActionResult Index(RenderModel model)
        {
            return RedirectToAction("CodeOfPractice");
        }

        public ActionResult CodeOfPractice(RenderModel model, int? groupId)
        {
            var template = this.ControllerContext.RouteData.Values["action"].ToString();

            if (groupId == null)
            {
                groupId = DefaultSection;
            }

            var data = modelUtility.GetViewModel(groupId.ToString());

            if (data.IsValid)
            {
                var adaptedData = new RenderModelAdapter<COPViewModel>(model.Content, data);
                return View(template, adaptedData);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}
