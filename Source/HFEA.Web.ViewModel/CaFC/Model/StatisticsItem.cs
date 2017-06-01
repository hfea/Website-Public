using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class StatisticsItem
    {
        public int Count { get; set; }

        public int NationalAverage { get; set; }

        public int ClinicRate { get; set; }

        public int ReliabilityRangeMin { get; set; }

        public int ReliabilityRangeMax { get; set; }

        public string CaveatText { get; set; }

        public CaFCConstants.ComparableToAverage CompareToAverage { get; set; }
        public string CompareToAverageString { get; set; }
        public bool HideStatItem { get; set; }
    }
}
