using HFEA.Connector.Global;
using HFEA.Core;
using HFEA.Web.Constants;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using umbraco.NodeFactory;
using Umbraco.Web.WebApi;

namespace HFEA.Web.Controllers
{
    /// <summary>
    /// This controller/action resolves to url: "/umbraco/api/clinicStatistics/[action]"
    /// </summary>
    public class ClinicStatisticsController : UmbracoApiController
    {
        private readonly IClinicStatsModelCreator modelUtility;

        public ClinicStatisticsController(IClinicStatsModelCreator modelCreator)
        {
            this.modelUtility = modelCreator;
        }

        [AcceptVerbs("GET")]
        public StatsSearchFilterValues GetFilters(int clinicId, string year = "", string treatment = "",
            string age = "", string source = "")
        {
            var data = this.modelUtility.GetAvailableFiltersByData(
                clinicId,
                year,
                treatment,
                age,
                source);

            return data;
        }
    }
}