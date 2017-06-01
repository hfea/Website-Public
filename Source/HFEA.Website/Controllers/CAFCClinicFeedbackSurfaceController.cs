using HFEA.Web.ViewModel.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class CAFCClinicFeedbackSurfaceController : SurfaceController
    {
        private readonly IClinicFeedbackReader _iClient;
        private readonly IClinicFeedbackWriter _iClientPost;

        public CAFCClinicFeedbackSurfaceController(IClinicFeedbackReader client, IClinicFeedbackWriter dataSubmitter)
        {
            this._iClient = client;
            this._iClientPost = dataSubmitter;
        }

        public ActionResult FeedbackForm(int? clinicId)
        {
            return View("ClinicFeedback");
        }
        public ActionResult RenderFeedbackForm()
        {
            return PartialView("_CAFCFeedbackForm", _iClient.GetClinicFeedbackQuestions());
        }
        public string GetClinicName(int? clinicId)
        {
            string ClinicName = this._iClient.GetClinicName(clinicId.GetValueOrDefault());                

            return ClinicName;
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult SubmitForm(ClinicFeedbackViewModel form, int? clinicId)
        {
            form.CentreId = clinicId.GetValueOrDefault().ToString();
            form.IpAddress = GetUserIP();

            if (this.IsFormValid(form))
            {
                if (_iClientPost.SaveClinicFeedbackAnswers(form))
                {
                    TempData.Add("response", Umbraco.AssignedContentItem.GetProperty("postFormContents")?.Value);
                }
                else
                {
                    TempData.Add("error", "There was an error submitting your feedback data. Please try again");
                }
            }
            else
            {
                TempData.Add("error", "You must answer at least one of the questions");
            }

            return Redirect(Request.Url.ToString());
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