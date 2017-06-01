using HFEA.Connector.Contracts.Serialization.TypeConverters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.RiskPerformance
{
    public class GPIMonths
    {
        public string Period { get; set; }
        public int LowerPerformanceId { get; set; }
        public int UpperPerformanceId { get; set; }
    }
    public class ChartControl
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Constants.Charts.CusumChartControlType Type { get; set; }
        public string Colour { get; set; }
        public bool DisplayLegend { get; set; }
        public string Caption { get; set; }
        public string RGB { get; set; }
    }
    public class CycleValueItem
    {
        public int CycleId { get; set; }
        public double Value { get; set; }
    }

    public class GridData
    { 
        public int YearMonth { get; set; }
        public int Cycles { get; set; }
        public string Transfers { get; set; }
        public string MissingEO { get; set; }
        public string MissingEORate { get; set; }
        public string MissingReg { get; set; }
        public string MissingRegRate { get; set; }
        public string PosMissingTreatment { get; set; }
        public string Pregnancies { get; set; }
        public string GestSac { get; set; }
        public string MissingGestSac { get; set; }
        public string MissingGestSacRate { get; set; }
    }

    public class PerformanceGPIChart
    {
        public string ageRange { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string chartDescription { get; set; }
        public bool multipleBirth { get; set; }
        public double natAverage { get; set; }
        public double centreAverage { get; set; }
        public int cycleCount { get; set; }
        public double lowerLimit { get; set; }
        public double lowerLimitAlert { get; set; }
        public double lowerLimitControl { get; set; }
        public double upperLimit { get; set; }
        public double upperLimitAlert { get; set; }
        public double upperLimitControl { get; set; }
        public int anos { get; set; }
        public int anosAlert { get; set; }
        public string chartDataXml { get; set; }
        public string chartGridXml { get; set; }
        public string ragStatus { get; set; }
        public List<ChartControl> chartControl { get; set; }
        public List<CycleValueItem> lbkItems { get; set; }
        public List<CycleValueItem> lbkResetItems { get; set; }
        public List<CycleValueItem> ubkItems { get; set; }
        public List<CycleValueItem> ubkResetItems { get; set; }
        public List<GridData> gridData { get; set; }
        public string XAxis { get; set; }
    }

    public class PregnancyRate
    {
        public string date { get; set; }
        public int pregnancyRate { get; set; }
        public int multiplePregnancyRate { get; set; }
    }

    public class CentreSuccessRateSummary
    {
        public string dataDateRangeStart { get; set; }
        public string dataDateRangeEnd { get; set; }
        public string ivfemb_ivfmultb_dicyc_DataDateRangeStart { get; set; }
        public string ivfemb_ivfmultb_dicyc_DataDateRangeEnd { get; set; }
        public string ivfeggcollCBR_DataDateRangeStart { get; set; }
        public string ivfeggcollCBR_DataDateRangeEnd { get; set; }
        public string iui_DataDateRangeStart { get; set; }
        public string iui_DataDateRangeEnd { get; set; }
        public string genericTreatment { get; set; }
        public int genericTreatmentClinicValue { get; set; }
        public int genericTreatmentNationalValue { get; set; }
        public string genericTreatmentTitle { get; set; }
        public bool hasIvfData { get; set; }
        public bool hasIuiData { get; set; }
        public bool hasDiData { get; set; }
        public List<PregnancyRate> pregnancyRates { get; set; }
        public int fieldU38OverallCountBet { get; set; }
        public int fieldU38Bet { get; set; }
        public int fieldU38BetEst { get; set; }
        public int fieldU38BetNational { get; set; }
        public int fieldU38BetChanceLower { get; set; }
        public int fieldU38BetChanceHigher { get; set; }
        public string fieldU38BetCompareNat { get; set; }
        public string fieldU38BetCaveat { get; set; }
        public int fieldO38OverallCountBet { get; set; }
        public int fieldO38Bet { get; set; }
        public int fieldO38BetEst { get; set; }
        public int fieldO38BetNational { get; set; }
        public int fieldO38BetChanceLower { get; set; }
        public int fieldO38BetChanceHigher { get; set; }
        public string fieldO38BetCompareNat { get; set; }
        public string fieldO38BetCaveat { get; set; }
        public int fieldAllOverallCountBet { get; set; }
        public int fieldAllBet { get; set; }
        public int fieldAllBetEst { get; set; }
        public int fieldAllBetNational { get; set; }
        public int fieldAllBetChanceLower { get; set; }
        public int fieldAllBetChanceHigher { get; set; }
        public string fieldAllBetCompareNat { get; set; }
        public string fieldAllBetCaveat { get; set; }
        public int fieldU38OverallCountBec { get; set; }
        public int fieldU38Bec { get; set; }
        public int fieldU38BecEst { get; set; }
        public int fieldU38BecNational { get; set; }
        public int fieldU38BecChanceLower { get; set; }
        public int fieldU38BecChanceHigher { get; set; }
        public string fieldU38BecCompareNat { get; set; }
        public string fieldU38BecCaveat { get; set; }
        public int fieldO38OverallCountBec { get; set; }
        public int fieldO38Bec { get; set; }
        public int fieldO38BecEst { get; set; }
        public int fieldO38BecNational { get; set; }
        public int fieldO38BecChanceLower { get; set; }
        public int fieldO38BecChanceHigher { get; set; }
        public string fieldO38BecCompareNat { get; set; }
        public string fieldO38BecCaveat { get; set; }
        public int fieldAllOverallCountBec { get; set; }
        public int fieldAllBec { get; set; }
        public int fieldAllBecEst { get; set; }
        public int fieldAllBecNational { get; set; }
        public int fieldAllBecChanceLower { get; set; }
        public int fieldAllBecChanceHigher { get; set; }
        public string fieldAllBecCompareNat { get; set; }
        public string fieldAllBecCaveat { get; set; }
        public int fieldU38OverallCountMlb { get; set; }
        public int fieldU38Mlb { get; set; }
        public int fieldU38MlbEst { get; set; }
        public int fieldU38MlbNational { get; set; }
        public int fieldU38MlbChanceLower { get; set; }
        public int fieldU38MlbChanceHigher { get; set; }
        public string fieldU38MlbCompareNat { get; set; }
        public int fieldU38MlbTar { get; set; }
        public string fieldU38MlbCaveat { get; set; }
        public int fieldO38OverallCountMlb { get; set; }
        public int fieldO38Mlb { get; set; }
        public int fieldO38MlbEst { get; set; }
        public int fieldO38MlbNational { get; set; }
        public int fieldO38MlbChanceLower { get; set; }
        public int fieldO38MlbChanceHigher { get; set; }
        public string fieldO38MlbCompareNat { get; set; }
        public int fieldO38MlbTar { get; set; }
        public string fieldO38MlbCaveat { get; set; }
        public int fieldAllOverallCountMlb { get; set; }
        public int fieldAllMlb { get; set; }
        public int fieldAllMlbEst { get; set; }
        public int fieldAllMlbNational { get; set; }
        public int fieldAllMlbChanceLower { get; set; }
        public int fieldAllMlbChanceHigher { get; set; }
        public string fieldAllMlbCompareNat { get; set; }
        public int fieldAllMlbTar { get; set; }
        public string fieldAllMlbCaveat { get; set; }
        public int fieldU38OverallCountPreg { get; set; }
        public int fieldU38Preg { get; set; }
        public int fieldU38PregEst { get; set; }
        public int fieldU38PregNational { get; set; }
        public int fieldU38PregChanceLower { get; set; }
        public int fieldU38PregChanceHigher { get; set; }
        public string fieldU38PregCompareNat { get; set; }
        public string fieldU38PregCaveat { get; set; }
        public int fieldO38OverallCountPreg { get; set; }
        public int fieldO38Preg { get; set; }
        public int fieldO38PregEst { get; set; }
        public int fieldO38PregNational { get; set; }
        public int fieldO38PregChanceLower { get; set; }
        public int fieldO38PregChanceHigher { get; set; }
        public string fieldO38PregCompareNat { get; set; }
        public string fieldO38PregCaveat { get; set; }
        public int fieldAllOverallCountPreg { get; set; }
        public int fieldAllPreg { get; set; }
        public int fieldAllPregEst { get; set; }
        public int fieldAllPregNational { get; set; }
        public int fieldAllPregChanceLower { get; set; }
        public int fieldAllPregChanceHigher { get; set; }
        public string fieldAllPregCompareNat { get; set; }
        public string fieldAllPregCaveat { get; set; }
        public int fieldU38OverallCountDi { get; set; }
        public int fieldU38Di { get; set; }
        public int fieldU38DiEst { get; set; }
        public int fieldU38DiNational { get; set; }
        public int fieldU38DiChanceLower { get; set; }
        public int fieldU38DiChanceHigher { get; set; }
        public string fieldU38DiCompareNat { get; set; }
        public string fieldU38DiCaveat { get; set; }
        public int fieldO38OverallCountDi { get; set; }
        public int fieldO38Di { get; set; }
        public int fieldO38DiEst { get; set; }
        public int fieldO38DiNational { get; set; }
        public int fieldO38DiChanceLower { get; set; }
        public int fieldO38DiChanceHigher { get; set; }
        public string fieldO38DiCompareNat { get; set; }
        public string fieldO38DiCaveat { get; set; }
        public int fieldAllOverallCountDi { get; set; }
        public int fieldAllDi { get; set; }
        public int fieldAllDiEst { get; set; }
        public int fieldAllDiNational { get; set; }
        public int fieldAllDiChanceLower { get; set; }
        public int fieldAllDiChanceHigher { get; set; }
        public string fieldAllDiCompareNat { get; set; }
        public string fieldAllDiCaveat { get; set; }
    }

    public class PerformanceGPIChartModel
    {
        public List<GPIMonths> performanceGPIMonths { get; set; }
        public List<PerformanceGPIChart> performanceGPICharts { get; set; }
        public CentreSuccessRateSummary centreSuccessRateSummary { get; set; }
    }







    public class GPIPerformanceDataItems
    {
        public string title { get; set; }
        public string description { get; set; }
        public double? nationalAverage { get; set; }
        public double? centreAverage { get; set; }
        public string ragStatus { get; set; }
        public string url { get; set; }
    }
    public class KRIPerformanceData
    {
        public List<KRIPerformanceDataItems> KRIPerformanceDataItems { get; set; }
    }
    public class KRIPerformanceDataItems
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string RagStatus { get; set; }
    }
    public class PerformanceKRISectionModel
    {
        public string SectionName { get; set; }
        public string Score { get; set; }
        public List<PerformanceRating> PerformanceRatings { get; set; }
        public List<PerformanceKRISAQSection> PerformanceKRISAQSections { get; set; }
    }
    public class PerformanceKRISAQSection
    {
        public List<PerformanceKRISAQData> PerformanceKRISAQDatas { get; set; }
        public string SectionName { get; set; }
    }
    public class PerformanceKRISAQDatas
    {
        public List<PerformanceKRISAQData> PerformanceKRISAQData { get; set; }
    }
    public class PerformanceKRISAQData
    {
        public int? IPLevel { get; set; }
        public string QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string RagStatus { get; set; }
    }
    public class PerformanceRating
    {
        public string Calcualtion { get; set; }
        public string RagStatus { get; set; }
    }
}

