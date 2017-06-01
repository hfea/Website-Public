using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC.Stats
{
    public class ClinicStatsDataSet
    {
        public int Id { get; set; }
        public string CentreName { get; set; }
        [JsonProperty("successRates")]
        public FullStatsDataSet FullDataSet { get; set; }
    }
}
