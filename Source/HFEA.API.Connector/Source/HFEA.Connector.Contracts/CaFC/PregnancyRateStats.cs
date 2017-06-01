using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class PregnancyRateStats
    {
        public DateTime Date { get; set; }

        public int PregnancyRate { get; set; }

        public int MultiplePregnancyRate { get; set; }
    }
}
