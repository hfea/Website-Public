using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HFEA.Connector.Contracts.CaFC
{
    public class CentreSuccessRateSummary
    {
        public DateTime DataDateRangeStart { get; set; }
        public DateTime DataDateRangeEnd { get; set; }

        public string GenericTreatment { get; set; }
        public int GenericTreatmentClinicValue { get; set; }
        public int GenericTreatmentNationalValue { get; set; }
        public bool HasIvfData { get; set; }
        public bool HasIuiData { get; set; }
        public bool HasDiData { get; set; }

        public string fieldU38BetCaveat { get; set; }
        public string fieldO38BetCaveat { get; set; }
        public string fieldAllBetCaveat { get; set; }
        public string fieldU38BecCaveat { get; set; }
        public string fieldO38BecCaveat { get; set; }
        public string fieldAllBecCaveat { get; set; }
        public string fieldU38MlbCaveat { get; set; }
        public string fieldO38MlbCaveat { get; set; }
        public string fieldAllMlbCaveat { get; set; }
        public string fieldU38PregCaveat { get; set; }
        public string fieldO38PregCaveat { get; set; }
        public string fieldAllPregCaveat { get; set; }
        public string fieldU38DiCaveat { get; set; }
        public string fieldO38DiCaveat { get; set; }
        public string fieldAllDiCaveat { get; set; }

        public string GenericTreatmentTitle { get; set; }
        public List<PregnancyRateStats> PregnancyRates { get; set; }

        #region Births per embryo transferred (IVF & ICSI clinics)
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldU38OverallCountBet { get; set; }
        /// <summary>
        /// Under 38 age band births per embryo transferred (IVF & ICSI clinics)
        /// </summary>
        public int FieldU38Bet { get; set; }
        /// <summary>
        /// Under 38 age band births per embryo transferred (IVF & ICSI clinics) estimated chance
        /// </summary>
        public int FieldU38BetEst { get; set; }
        /// <summary>
        /// Under 38 age band births per embryo transferred (IVF & ICSI clinics) national rate
        /// </summary>
        public int FieldU38BetNational { get; set; }
        /// <summary>
        /// Under 38 age band births per embryo transferred (IVF & ICSI clinics) confidence interval lower value
        /// </summary>
        public int FieldU38BetChanceLower { get; set; }
        /// <summary>
        /// Under 38 age band births per embryo transferred (IVF & ICSI clinics) confidence interval higher value
        /// </summary>
        public int FieldU38BetChanceHigher { get; set; }
        /// <summary>
        /// Under 38 age band births per embryo transferred (IVF & ICSI clinics) under/above/consistant with national rate
        /// </summary>
        public string FieldU38BetCompareNat { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldO38OverallCountBet { get; set; }
        /// <summary>
        /// 38 and over age band births per embryo transferred (IVF & ICSI clinics)
        /// </summary>
        public int FieldO38Bet { get; set; }
        /// <summary>
        /// 38 and over age band births per embryo transferred (IVF & ICSI clinics) estimated chance
        /// </summary>
        public int FieldO38BetEst { get; set; }
        /// <summary>
        /// 38 and over age band births per embryo transferred (IVF & ICSI clinics) national rate
        /// </summary>
        public int FieldO38BetNational { get; set; }
        /// <summary>
        /// 38 and over age band births per embryo transferred (IVF & ICSI clinics) confidence interval lower value
        /// </summary>
        public int FieldO38BetChanceLower { get; set; }
        /// <summary>
        /// 38 and over age band births per embryo transferred (IVF & ICSI clinics) confidence interval higher value
        /// </summary>
        public int FieldO38BetChanceHigher { get; set; }
        /// <summary>
        /// 38 and over age band births per embryo transferred (IVF & ICSI clinics) under/above/consistant with national rate
        /// </summary>
        public string FieldO38BetCompareNat { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldAllOverallCountBet { get; set; }
        /// <summary>
        /// All ages age band births per embryo transferred (IVF & ICSI clinics)
        /// </summary>
        public int FieldAllBet { get; set; }
        /// <summary>
        /// All ages age band births per embryo transferred (IVF & ICSI clinics) estimated chance
        /// </summary>
        public int FieldAllBetEst { get; set; }
        /// <summary>
        /// All ages age band births per embryo transferred (IVF & ICSI clinics) national rate
        /// </summary>
        public int FieldAllBetNational { get; set; }
        /// <summary>
        /// All ages age band births per embryo transferred (IVF & ICSI clinics) confidence interval lower value
        /// </summary>
        public int FieldAllBetChanceLower { get; set; }
        /// <summary>
        /// All ages age band births per embryo transferred (IVF & ICSI clinics) confidence interval higher value
        /// </summary>
        public int FieldAllBetChanceHigher { get; set; }
        /// <summary>
        /// All ages age band births per embryo transferred (IVF & ICSI clinics) under/above/consistant with national rate
        /// </summary>
        public string FieldAllBetCompareNat { get; set; }
        #endregion
        #region Births per egg collection (cumulative) (IVF & ICSI clinics)
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldU38OverallCountBec { get; set; }
        /// <summary>
        /// Under 38 age band births per egg collection (cumulative) (IVF & ICSI clinics)
        /// </summary>
        public int FieldU38Bec { get; set; }
        /// <summary>
        /// Under 38 age band births per egg collection (cumulative) (IVF & ICSI clinics) estimated chance
        /// </summary>
        public int FieldU38BecEst { get; set; }
        /// <summary>
        /// Under 38 age band births per egg collection (cumulative) (IVF & ICSI clinics) national rate
        /// </summary>
        public int FieldU38BecNational { get; set; }
        /// <summary>
        /// Under 38 age band births per egg collection (cumulative) (IVF & ICSI clinics) confidence interval lower value
        /// </summary>
        public int FieldU38BecChanceLower { get; set; }
        /// <summary>
        /// Under 38 age band births per egg collection (cumulative) (IVF & ICSI clinics) confidence interval lower value
        /// </summary>
        public int FieldU38BecChanceHigher { get; set; }
        /// <summary>
        /// Under 38 age band births per egg collection (cumulative) (IVF & ICSI clinics) under/above/consistant with national rate
        /// </summary>
        public string FieldU38BecCompareNat { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldO38OverallCountBec { get; set; }
        /// <summary>
        /// 38 and over age band births per egg collection (cumulative) (IVF & ICSI clinics)
        /// </summary>
        public int FieldO38Bec { get; set; }
        /// <summary>
        /// 38 and over age band births per egg collection (cumulative) (IVF & ICSI clinics) estimated chance
        /// </summary>
        public int FieldO38BecEst { get; set; }
        /// <summary>
        /// 38 and over age band births per egg collection (cumulative) (IVF & ICSI clinics) national rate
        /// </summary>
        public int FieldO38BecNational { get; set; }
        /// <summary>
        /// 38 and over age band births per egg collection (cumulative) (IVF & ICSI clinics) confidence interval lower value
        /// </summary>
        public int FieldO38BecChanceLower { get; set; }
        /// <summary>
        /// 38 and over age band births per egg collection (cumulative) (IVF & ICSI clinics) confidence interval higher value
        /// </summary>
        public int FieldO38BecChanceHigher { get; set; }
        /// <summary>
        /// 38 and over age band births per egg collection (cumulative) (IVF & ICSI clinics) under/above/consistant with national rate
        /// </summary>
        public string FieldO38BecCompareNat { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldAllOverallCountBec { get; set; }
        /// <summary>
        /// All ages age band births per egg collection (cumulative) (IVF & ICSI clinics)
        /// </summary>
        public int FieldAllBec { get; set; }
        /// <summary>
        /// All ages age band births per egg collection (cumulative) (IVF & ICSI clinics) estimated chance
        /// </summary>
        public int FieldAllBecEst { get; set; }
        /// <summary>
        /// All ages age band births per egg collection (cumulative) (IVF & ICSI clinics) national rate
        /// </summary>
        public int FieldAllBecNational { get; set; }
        /// <summary>
        /// All ages age band births per egg collection (cumulative) (IVF & ICSI clinics) confidence interval lower value
        /// </summary>
        public int FieldAllBecChanceLower { get; set; }
        /// <summary>
        /// All ages age band births per egg collection (cumulative) (IVF & ICSI clinics) confidence interval higher value
        /// </summary>
        public int FieldAllBecChanceHigher { get; set; }
        /// <summary>
        /// All ages age band births per egg collection (cumulative) (IVF & ICSI clinics) under/above/consistant with national rate
        /// </summary>
        public string FieldAllBecCompareNat { get; set; }
        #endregion
        #region IVF Multiple births (IVF & ICSI clinics)
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldU38OverallCountMlb { get; set; }
        /// <summary>
        /// Under 38 age band IVF multiple births 
        /// </summary>
        public int FieldU38Mlb { get; set; }
        /// <summary>
        /// Under 38 age band IVF multiple births estimated chance
        /// </summary>
        public int FieldU38MlbEst { get; set; }
        /// <summary>
        /// Under 38 age band IVF multiple births national rate
        /// </summary>
        public int FieldU38MlbNational { get; set; }
        /// <summary>
        /// Under 38 age band IVF multiple births confidence interval lower value
        /// </summary>
        public int FieldU38MlbChanceLower { get; set; }
        /// <summary>
        /// Under 38 age band IVF multiple births confidence interval higher value
        /// </summary>
        public int FieldU38MlbChanceHigher { get; set; }
        /// <summary>
        /// Under 38 age band IVF multiple births under/above/consistant with national rate
        /// </summary>
        public string FieldU38MlbCompareNat { get; set; }
        /// <summary>
        /// Under 38 age band IVF multiple births target
        /// </summary>
        public int FieldU38MlbTar { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldO38OverallCountMlb { get; set; }
        /// <summary>
        /// 38 and over age band IVF multiple births births per embryo transferred
        /// </summary>
        public int FieldO38Mlb { get; set; }
        /// <summary>
        /// 38 and over age band IVF multiple births estimated chance
        /// </summary>
        public int FieldO38MlbEst { get; set; }
        /// <summary>
        /// 38 and over age band IVF multiple births national rate
        /// </summary>
        public int FieldO38MlbNational { get; set; }
        /// <summary>
        /// 38 and over age band IVF multiple births confidence interval lower value
        /// </summary>
        public int FieldO38MlbChanceLower { get; set; }
        /// <summary>
        /// 38 and over age band IVF multiple births confidence interval higher value
        /// </summary>
        public int FieldO38MlbChanceHigher { get; set; }
        /// <summary>
        /// 38 and over age band IVF multiple births under/above/consistant with national rate
        /// </summary>
        public string FieldO38MlbCompareNat { get; set; }
        /// <summary>
        /// Over 38 age band IVF multiple births target
        /// </summary>
        public int FieldO38MlbTar { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldAllOverallCountMlb { get; set; }
        /// <summary>
        /// All ages age band IVF multiple births 
        /// </summary>
        public int FieldAllMlb { get; set; }
        /// <summary>
        /// All ages age band IVF multiple births estimated chance
        /// </summary>
        public int FieldAllMlbEst { get; set; }
        /// <summary>
        /// All ages age band IVF multiple births national rate
        /// </summary>
        public int FieldAllMlbNational { get; set; }
        /// <summary>
        /// All ages age band IVF multiple births confidence interval lower value
        /// </summary>
        public int FieldAllMlbChanceLower { get; set; }
        /// <summary>
        /// All ages age band IVF multiple births confidence interval higher value
        /// </summary>
        public int FieldAllMlbChanceHigher { get; set; }
        /// <summary>
        /// All ages age band IVF multiple births under/above/consistant with national rate
        /// </summary>
        public string FieldAllMlbCompareNat { get; set; }
        /// <summary>
        /// All ages age band IVF multiple births target
        /// </summary>
        public int FieldAllMlbTar { get; set; }
        #endregion
        #region Pregnancies per treatment with partner (IUI)
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldU38OverallCountPreg { get; set; }
        /// <summary>
        /// Under 38 age band pregnancies per treatment with partner (IUI)
        /// </summary>
        public int FieldU38Preg { get; set; }
        /// <summary>
        /// Under 38 age band pregnancies per treatment with partner (IUI) estimated chance
        /// </summary>
        public int FieldU38PregEst { get; set; }
        /// <summary>
        /// Under 38 age band pregnancies per treatment with partner (IUI) national rate
        /// </summary>
        public int FieldU38PregNational { get; set; }
        /// <summary>
        /// Under 38 age band pregnancies per treatment with partner (IUI) confidence interval lower value
        /// </summary>
        public int FieldU38PregChanceLower { get; set; }
        /// <summary>
        /// Under 38 age band pregnancies per treatment with partner (IUI) confidence interval higher value
        /// </summary>
        public int FieldU38PregChanceHigher { get; set; }
        /// <summary>
        /// Under 38 age band pregnancies per treatment with partner (IUI) under/above/consistant with national rate
        /// </summary>
        public string FieldU38PregCompareNat { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldO38OverallCountPreg { get; set; }
        /// <summary>
        /// 38 and over age band pregnancies per treatment with partner (IUI)
        /// </summary>
        public int FieldO38Preg { get; set; }
        /// <summary>
        /// 38 and over age band pregnancies per treatment with partner (IUI) estimated chance
        /// </summary>
        public int FieldO38PregEst { get; set; }
        /// <summary>
        /// 38 and over age band pregnancies per treatment with partner (IUI) national rate
        /// </summary>
        public int FieldO38PregNational { get; set; }
        /// <summary>
        /// 38 and over age band pregnancies per treatment with partner (IUI) confidence interval lower value
        /// </summary>
        public int FieldO38PregChanceLower { get; set; }
        /// <summary>
        /// 38 and over age band pregnancies per treatment with partner (IUI) confidence interval higher value
        /// </summary>
        public int FieldO38PregChanceHigher { get; set; }
        /// <summary>
        /// 38 and over age band pregnancies per treatment with partner (IUI) under/above/consistant with national rate
        /// </summary>
        public string FieldO38PregCompareNat { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldAllOverallCountPreg { get; set; }
        /// <summary>
        /// All ages age band pregnancies per treatment with partner (IUI)
        /// </summary>
        public int FieldAllPreg { get; set; }
        /// <summary>
        /// All ages age band pregnancies per treatment with partner (IUI) estimated chance
        /// </summary>
        public int FieldAllPregEst { get; set; }
        /// <summary>
        /// All ages age band pregnancies per treatment with partner (IUI) national rate
        /// </summary>
        public int FieldAllPregNational { get; set; }
        /// <summary>
        /// All ages age band pregnancies per treatment with partner (IUI) confidence interval lower value
        /// </summary>
        public int FieldAllPregChanceLower { get; set; }
        /// <summary>
        /// All ages age band pregnancies per treatment with partner (IUI) confidence interval higher value
        /// </summary>
        public int FieldAllPregChanceHigher { get; set; }
        /// <summary>
        /// All ages age band pregnancies per treatment with partner (IUI) under/above/consistant with national rate
        /// </summary>
        public string FieldAllPregCompareNat { get; set; }
        #endregion
        #region Births per treatment(DI)
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldU38OverallCountDi { get; set; }
        /// <summary>
        /// Under 38 age band per treatment (DI)
        /// </summary>
        public int FieldU38Di { get; set; }
        /// <summary>
        /// Under 38 age band per treatment (DI) estimated chance
        /// </summary>
        public int FieldU38DiEst { get; set; }
        /// <summary>
        /// Under 38 age band per treatment (DI) national rate
        /// </summary>
        public int FieldU38DiNational { get; set; }
        /// <summary>
        /// Under 38 age band per treatment (DI) confidence interval lower value
        /// </summary>
        public int FieldU38DiChanceLower { get; set; }
        /// <summary>
        /// Under 38 age band per treatment (DI) confidence interval higher value
        /// </summary>
        public int FieldU38DiChanceHigher { get; set; }
        /// <summary>
        /// Under 38 age band per treatment (DI) under/above/consistant with national rate
        /// </summary>
        public string FieldU38DiCompareNat { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldO38OverallCountDi { get; set; }
        /// <summary>
        /// 38 and over age band per treatment (DI)
        /// </summary>
        public int FieldO38Di { get; set; }
        /// <summary>
        /// 38 and over age band per treatment (DI) estimated chance
        /// </summary>
        public int FieldO38DiEst { get; set; }
        /// <summary>
        /// 38 and over age band per treatment (DI) national rate
        /// </summary>
        public int FieldO38DiNational { get; set; }
        /// <summary>
        /// 38 and over age band per treatment (DI) confidence interval lower value
        /// </summary>
        public int FieldO38DiChanceLower { get; set; }
        /// <summary>
        /// 38 and over age band per treatment (DI) confidence interval higher value
        /// </summary>
        public int FieldO38DiChanceHigher { get; set; }
        /// <summary>
        /// 38 and over age band per treatment (DI) under/above/consistant with national rate
        /// </summary>
        public string FieldO38DiCompareNat { get; set; }
        /// <summary>
        /// Overall total number or cycles for age band
        /// </summary>
        public int FieldAllOverallCountDi { get; set; }
        /// <summary>
        /// All ages age band per treatment (DI)
        /// </summary>
        public int FieldAllDi { get; set; }
        /// <summary>
        /// All ages age band per treatment (DI) estimated chance
        /// </summary>
        public int FieldAllDiEst { get; set; }
        /// <summary>
        /// All ages age band per treatment (DI) national rate
        /// </summary>
        public int FieldAllDiNational { get; set; }
        /// <summary>
        /// All ages age band per treatment (DI) confidence interval lower value
        /// </summary>
        public int FieldAllDiChanceLower { get; set; }
        /// <summary>
        /// All ages age band per treatment (DI) confidence interval higher value
        /// </summary>
        public int FieldAllDiChanceHigher { get; set; }
        /// <summary>
        /// All ages age band per treatment (DI) under/above/consistant with national rate
        /// </summary>
        public string FieldAllDiCompareNat { get; set; }
        #endregion

        // Success Rate Date range
        public string Ivfemb_ivfmultb_dicyc_DataDateRangeStart { get; set; }
        public string Ivfemb_ivfmultb_dicyc_DataDateRangeEnd { get; set; }
        public string IvfeggcollCBR_DataDateRangeStart { get; set; }
        public string IvfeggcollCBR_DataDateRangeEnd { get; set; }
        public string Iui_DataDateRangeStart { get; set; }
        public string Iui_DataDateRangeEnd { get; set; }
    }
}