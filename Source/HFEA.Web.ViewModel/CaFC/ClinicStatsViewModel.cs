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
    public class ClinicStatsViewModel
    {
        public int ClinicId { get; set; }
        public string ProfilePageUrl { get; set; }
        public string ClinicName { get; set; }        
        public StatsFullFilters StatsParameters { get; set; }
        public ClinicStatsGenericViewModel GenericStatsData { get; set; }
        public ClinicStatsTreatmentViewModel TreatmentStatsData { get; set; }
        public ClinicStatsVsNationalViewModel ClinicVsNationalComparisonData { get; set; }
        public List<Tuple<string, string, string>> AgeStatsData { get; set; }
    }
}
