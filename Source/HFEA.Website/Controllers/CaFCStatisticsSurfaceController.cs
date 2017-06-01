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

using HFEA.Web;
using System.Collections.Specialized;

namespace HFEA.Web.Controllers
{
    public class CaFCStatisticsSurfaceController : SurfaceController
    {
        private const string FiltersView = "~/Views/CaFCStatistics/Filters.cshtml";

        private readonly IClinicStatsModelCreator modelUtility;

        private QueryString.QueryParams TypeQry = QueryString.QueryParams.type;
        private QueryString.QueryParams AgeQry = QueryString.QueryParams.age;
        private QueryString.QueryParams TreatmentQry = QueryString.QueryParams.treatment;
        private QueryString.QueryParams SourceQry = QueryString.QueryParams.source;
        private QueryString.QueryParams YearQry = QueryString.QueryParams.year;

        public CaFCStatisticsSurfaceController(IClinicStatsModelCreator modelCreator)
        {
            this.modelUtility = modelCreator;
        }
        
        [ChildActionOnly]
        public ActionResult SearchFilters(int clinicId)
        {
            var data = this.modelUtility.GetAvailableFiltersByData(
                clinicId,
                YearQry.GetQryParamValueOrNull(),
                TreatmentQry.GetQryParamValueOrNull(),
                AgeQry.GetQryParamValueOrNull(),                
                SourceQry.GetQryParamValueOrNull());
            
            return PartialView(FiltersView, data);
        }
        
        [HttpPost]
        public ActionResult FiltersSubmit(int clinicId, string year, string treatment, 
            string age, string source, string type)
        {
            var qry = new NameValueCollection();
            
            if (!string.IsNullOrEmpty(age)) qry.Add(AgeQry.ToString(), age);
            if (!string.IsNullOrEmpty(treatment)) qry.Add(TreatmentQry.ToString(), treatment);
            if (!string.IsNullOrEmpty(year)) qry.Add(YearQry.ToString(), year);
            if (!string.IsNullOrEmpty(source)) qry.Add(SourceQry.ToString(), source);

            if (string.IsNullOrEmpty(type)) type = TypeQry.GetQryParamValueOrNull();
            if (!string.IsNullOrEmpty(type)) qry.Add(TypeQry.ToString(), type);

            string url = Request.RawUrl;

            if (qry.Count > 0)
            {
                url = UrlQueryHelper.AddUpdateQuery(Request.RawUrl, qry, qry.AllKeys);
            }
            
            return Redirect(url);
        }
    }
}
