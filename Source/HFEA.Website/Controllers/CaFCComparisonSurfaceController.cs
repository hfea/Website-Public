using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class CaFCComparisonSurfaceController : SurfaceController
    {
        public const string ErrorKey = CaFCCartSurfaceController.ErrorKey; // duplicate for a better readability
        public const int MaxClinics = CaFCCartSurfaceController.MaxClinics; // duplicate for a better readability
        public const string LimitExceededErrorMessage = "You cannot compare more than 3 clinics";
        public const string WrongClinicIdErrorMessage = "Please enter a valid clinic id in the search box";
        public const string Separator = ",";
        private const string StatsView = "~/Views/CaFCCompare/CompareClinics.cshtml";
        private const Constants.QueryString.QueryParams IdQry = Constants.QueryString.QueryParams.id;

        private readonly ICaFCComparisonModelCreator modelCreator;

        public CaFCComparisonSurfaceController(ICaFCComparisonModelCreator modelReader)
        {
            if (modelReader == null) throw new ArgumentNullException("Comparison model reader is null");
            this.modelCreator = modelReader;
        }

        [ChildActionOnly]
        public ActionResult GetData()
        {
            /// here we clear the comparison cart session 
            /// Comparison page relies on QueryString parameters rather than the session variable
            CaFCCartSurfaceController.ClearCart();

            var qry = Constants.QueryString.QueryParams.id.GetQryParamValueOrNull();
            ComparisonViewModel data = null;

            if (!string.IsNullOrEmpty(qry))
            {
                var values = qry
                    .Split(new string[] { Separator }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToNullableInt())
                    .Where(x => x != null)
                    .Select(x => x.Value)
                    .ToArray();

                data = this.modelCreator.GetData(values);
            }

            return View(StatsView, data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Submit(List<int> clinicIds, int? newId = null)
        {
            bool isError = false;
            if (clinicIds == null)
            {
                clinicIds = new List<int>();
            }

            if (clinicIds.Count < MaxClinics)
            {
                if (newId != null && newId > 0)
                {
                    clinicIds.Add(newId.Value);
                }
                else
                {
                    isError = true;
                    ViewData[ErrorKey] = WrongClinicIdErrorMessage;
                }
            }
            else
            {
                isError = true;
                ViewData[ErrorKey] = LimitExceededErrorMessage;
            }

            if (isError)
            {
                return CurrentUmbracoPage();
            }
            else
            {
                var qry = this.GetQuery(clinicIds.Distinct());
                return RedirectToCurrentUmbracoPage(qry);
            }
        }

        private NameValueCollection GetQuery(IEnumerable<int> clinicIds)
        {
            var qry = new NameValueCollection();
            if (clinicIds != null && clinicIds.Any())
            {
                qry.Add(IdQry.ToString(), string.Join(Separator, clinicIds));
            }

            return qry;
        }
    }
}
