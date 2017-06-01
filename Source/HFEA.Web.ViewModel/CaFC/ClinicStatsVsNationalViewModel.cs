using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public class ClinicStatsVsNationalViewModel
    {
        public StatsFullFilters StatsParameters { get; set; }
        public CaFCConstants.StatsTreatmentType CurrentTreatmentType { get; set; }
        public List<StatsDetailStatisticsItem> PerCycleDataList { get; set; }
        public List<StatsDetailStatisticsItem> PerEmbryoDataList { get; set; }
    }
}
