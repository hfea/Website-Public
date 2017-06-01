using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.Constants;
using HFEA.Web.ViewModel.PGD;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class PgdListingSurfaceController : SurfaceController
    {
        private const string PgdListingView = "~/Views/PGD/PgdListing.cshtml";
        private const int PageSize = 20;
        private readonly IPgdListingModelCreator modelCreator;

        public PgdListingSurfaceController(IPgdListingModelCreator reader)
        {
            this.modelCreator = reader;
        }

        [ChildActionOnly]
        public ActionResult GetData()
        {
            string name = Constants.QueryString.QueryParams.condition.GetQryParamValueOrNull();
            string omoimm = Constants.QueryString.QueryParams.omoimm.GetQryParamValueOrNull();
            int status = Constants.QueryString.QueryParams.status.GetQryParamValueOrDefault<int>(0);
            int page = Constants.QueryString.QueryParams.page.GetQryParamValueOrDefault<int>(1);

            PgdConstants.Status pgdStatus = PgdConstants.Status.Unknown;
            if (status > 0
                && Enum.IsDefined(typeof(PgdConstants.Status), status))
            {
                pgdStatus = (PgdConstants.Status)status;
            }

            var filters = new PgdSearchFilters()
            {
                PageSize = PageSize,
                Condition = name,
                OMOIMM = omoimm,
                Page = page,
                Status = pgdStatus
            };
               
            var data = this.modelCreator.GetData(CurrentPage.Id, filters);

            return View(PgdListingView, data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult SubmitSearch(PgdSearchFilters filters)
        {
            var qry = new NameValueCollection();

            if (filters != null)
            {
                if (!string.IsNullOrEmpty(filters.Condition))
                {
                    qry.Add(Constants.QueryString.QueryParams.condition.ToString(), filters.Condition);
                }

                if (!string.IsNullOrEmpty(filters.OMOIMM))
                {
                    qry.Add(Constants.QueryString.QueryParams.omoimm.ToString(), filters.OMOIMM);
                }

                if (filters.Status != PgdConstants.Status.Unknown)
                {
                    qry.Add(Constants.QueryString.QueryParams.status.ToString(), ((int)filters.Status).ToString());
                }
            }

            return RedirectToCurrentUmbracoPage(qry);
        }

        private bool IsFormValid(ClinicFeedbackViewModel form)
        {
            return form != null && form.QuestionList.Any(x => x.Score > 0);
        }

        private string GetUserIP()
        {
            string ipList = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }

            return Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}