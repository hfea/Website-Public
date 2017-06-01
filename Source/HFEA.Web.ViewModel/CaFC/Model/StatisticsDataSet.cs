using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class StatisticsDataSet
    {
        public int Year { get; set; }

        public StatisticsItem All { get; set; }

        public StatisticsItem Over38 { get; set; }

        public StatisticsItem Under38 { get; set; }
        public bool HideStatDataSet { get; set; }
    }
}
