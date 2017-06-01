using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC.Stats
{
    public class StatsDataItem
    {
        public string Type { get; set; }
        public string DisplayLabel { get; set; }
        public string SuccessNumber { get; set; }
        public string PredictedSuccessChanceRange { get; set; }
        public string PredictedSuccessMostLikely { get; set; }
        public string PredictedSuccessMostLikelyLabel { get; set; }
        public string NationalPercentage { get; set; }
        public string NationalCompare { get; set; }
    }
}
