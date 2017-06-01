using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC.Stats
{
    public class FullStatsDataSet
    {
        public SearchFilterSet SuccessRateBreakdown { get; set; }
        public List<StatsDataItemShort> OverviewOfCycles { get; set; }
        public List<StatsDataItemShort> NumberOfEmbryosTransferred { get; set; }
        public List<StatsDataItemShort> NumberOfCyclesCancelledBeforeEggsWereCollected { get; set; }
        public List<StatsDataItemShort> NumberOfCyclesCancelledBetweenEggCollectionAndEmbryoTransfer { get; set; }
        public List<StatsDataItemShort> ChartData { get; set; }
        public List<StatsDataItem> PregnanciesAndLiveBirthsPerTreatmentCycle { get; set; }
        public List<StatsDataItem> PregnanciesAndLiveBirthsPerEmbryoTransferred { get; set; }
        public List<AgeStatsDataItem> AgeSplitOfPatients { get; set; }
    }
}
