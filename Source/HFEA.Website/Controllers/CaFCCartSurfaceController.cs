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
    public class CaFCCartSurfaceController : SurfaceController
    {
        public const int MaxClinics = 3; // when changing this don't forget the below error message
        public const string ErrorKey = "ActionError";
        public const string GenericErrorMessage = "Clinic couldn't be added to comparison list";
        public const string LimitExceededErrorMessage = "You cannot compare more than 3 clinics";
        public const string CartSession = "CompareCart";
        private const string CartView = "~/Views/CaFCShared/CartView.cshtml";
        private const string CartAddView = "~/Views/CaFCShared/CartAdd.cshtml";        
        private const string Separator = CaFCComparisonSurfaceController.Separator;
        private const Constants.QueryString.QueryParams IdQry = Constants.QueryString.QueryParams.id;

        public CaFCCartSurfaceController()
        {
        }

        public static void ClearCart()
        {
            System.Web.HttpContext.Current.Session[CartSession] = null;
        }
        
        public List<IdValuePairInt> SessionValues
        {
            get
            {
                return (Session[CartSession] as List<IdValuePairInt>) ?? new List<IdValuePairInt>();
            }
            set
            {
                Session[CartSession] = value;
            }
        }

        [ChildActionOnly]
        public ActionResult GetCartView()
        {
            return View(CartView, this.SessionValues);
        }

        [ChildActionOnly]
        public ActionResult GetAddButton(int id, string name)
        {
            return View(CartAddView, new IdValuePairInt() { Id = id, Value = name });
        }

        [HttpGet]
        public ActionResult Compare()
        {
            var values = SessionValues;
            NameValueCollection qry = null;
            if (values.Any())
            {
                qry = this.GetQuery(values.Select(x => x.Id));                
            }

            return RedirectToUmbracoPage(Core.Config.Settings.KeyPages.CompareClinics, qry);
        }

        [HttpPost]
        public ActionResult DeleteClinic(int id)
        {
            var values = this.SessionValues.Where(x => x.Id != id).ToList();
            this.SessionValues = values;

            return RedirectToCurrentUmbracoUrl();
        }

        [HttpPost]
        public ActionResult AddClinic(IdValuePairInt clinic)
        {
            var values = this.SessionValues;
            if (clinic != null && clinic.Id > 0 && !string.IsNullOrEmpty(clinic.Value))
            {
                if (values.Any(x => x.Id == clinic.Id))
                {
                    return RedirectToCurrentUmbracoUrl();
                }
                else if (values.Count < MaxClinics)
                {
                    values.Add(clinic);
                    this.SessionValues = values;
                    return RedirectToCurrentUmbracoUrl();
                }
                else
                {
                    ViewData.Add(ErrorKey, LimitExceededErrorMessage);
                }
            }
            else
            {
                ViewData.Add(ErrorKey, GenericErrorMessage);
            }

            return CurrentUmbracoPage();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Submit(List<int> clinicIds, int newId)
        {
            if (clinicIds == null)
            {
                clinicIds = new List<int>();
            }

            if (newId > 0)
            {
                clinicIds.Add(newId);
            }

            var qry = this.GetQuery(clinicIds);
            return RedirectToCurrentUmbracoPage(qry);
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
