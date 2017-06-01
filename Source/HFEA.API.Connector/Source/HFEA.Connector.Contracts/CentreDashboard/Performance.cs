using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CentreDashboard
{
    public class Performance
    {
        public int CentreId { get; set; }
        public int RiskRunId { get; set; }
        public string LastUpdated { get; set; }
        public bool HasIvfDetailData { get; set; }
        public bool HasDiDetailData { get; set; }
        public bool HasIcsiDetailData { get; set; }
        public bool HasIvfIcsiDetailData { get; set; }
        public double AllCyclesMultiplePregRate16to70Centre { get; set; }
        public double AllCyclesMultiplePregRate16to70National { get; set; }
        public double? AllCyclesMultiplePregRate16to70RiskLevel { get; set; }
        public string AllCyclesMultiplePregRate16to70RiskLevelDescription { get; set; }
        public double IcsiPregRateFreshStimU38Centre { get; set; }
        public double IcsiPregRateFreshStimU38National { get; set; }
        public double IcsiPregRateFreshStimU38GpiId { get; set; }
        public double? IcsiPregRateFreshStimU38RiskLevel { get; set; }
        public string IcsiPregRateFreshStimU38RiskLevelDescription { get; set; }
        public double IcsiPregRateFreshStimO38Centre { get; set; }
        public double IcsiPregRateFreshStimO38National { get; set; }
        public double IcsiPregRateFreshStimO38GpiId { get; set; }
        public double? IcsiPregRateFreshStimO38RiskLevel { get; set; }
        public string IcsiPregRateFreshStimO38RiskLevelDescription { get; set; }
        public double IvfPregRateFreshStimU38Centre { get; set; }
        public double IvfPregRateFreshStimU38National { get; set; }
        public double IvfPregRateFreshStimU38GpiId { get; set; }
        public double? IvfPregRateFreshStimU38RiskLevel { get; set; }
        public string IvfPregRateFreshStimU38RiskLevelDescription { get; set; }
        public double IvfPregRateFreshStimO38Centre { get; set; }
        public double IvfPregRateFreshStimO38National { get; set; }
        public double IvfPregRateFreshStimO38GpiId { get; set; }
        public double? IvfPregRateFreshStimO38RiskLevel { get; set; }
        public string IvfPregRateFreshStimO38RiskLevelDescription { get; set; }
        public double IvfIcsiPregRateFrozenU40Centre { get; set; }
        public double IvfIcsiPregRateFrozenU40National { get; set; }
        public double IvfIcsiPregRateFrozenStimU40GpiId { get; set; }
        public double? IvfIcsiPregRateFrozenStimU40RiskLevel { get; set; }
        public string IvfIcsiPregRateFrozenStimU40RiskLevelDescription { get; set; }
        public double IvfIcsiPregRateFrozenO40Centre { get; set; }
        public double IvfIcsiPregRateFrozenO40National { get; set; }
        public double IvfIcsiPregRateFrozenStimO40GpiId { get; set; }
        public double? IvfIcsiPregRateFrozenStimO40RiskLevel { get; set; }
        public string IvfIcsiPregRateFrozenStimO40RiskLevelDescription { get; set; }
        public double DiPregRateU35Centre { get; set; }
        public double DiPregRateU35National { get; set; }

        // IR
        public int allCyclesMultiplePregRate16to70PerformanceId { get; set; }
        public int icsiPregRateFreshStimU38PerformanceId { get; set; }
        public int icsiPregRateFreshStimO38PerformanceId { get; set; }
        public int ivfPregRateFreshStimU38PerformanceId { get; set; }
        public int ivfPregRateFreshStimO38PerformanceId { get; set; }
        public int ivfIcsiPregRateFrozenStimU40PerformanceId { get; set; }
        public int ivfIcsiPregRateFrozenStimO40PerformanceId { get; set; }
        public int diPregRateU35PerformanceId { get; set; }

    }
}
