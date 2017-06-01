using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class StatsDetailStatisticsItem : StatisticsItem
    {
        public string NationalComparisonSuccessTitle { get; set; }
        public string NationalComparisonSuccessCountString { get; set; }
        public int NationalComparisonSuccessCount { get; set; }
        public int NationalComparisonTotalCount { get; set; }
        public string ClinicSuccessLikelinessTitle { get; set; }        
        public bool IsWorseThanAverage { get; set; }          
    }
}
