using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC.Stats
{
    public class AgeStatsDataItem
    {
        public string Type { get; set; }
        public string DisplayLabel { get; set; }
        public string ClinicPercentage { get; set; }
        public string NationalPercentage { get; set; }
    }
}
