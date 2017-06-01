using HFEA.Connector.Contracts.CaFC.Stats;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.CaFCStats.Data
{
    public class Stats
    {
        public static ClinicStatsDataSet Data
        {
            get
            {
                return JsonConvert.DeserializeObject<ClinicStatsDataSet>(JSON);
            }
        }

        public static ClinicStatsDataSet Data321
        {
            get
            {
                return JsonConvert.DeserializeObject<ClinicStatsDataSet>(JSON321);
            }
        }

        public static string JSON
        {
            get
            {
                return @"
{
  ""id"": 4,
  ""centreName"": ""Ninewells Hospital"",
  ""successRates"": {
                    ""successRateBreakdown"": {
                        ""year"": {
                            ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
                        },
      ""age"": {
                            ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
                            ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
                            ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
                    },
    ""overviewOfCycles"": [
      {
        ""type"": ""numberOfCyclesStarted"",
        ""displayLabel"": ""Number of cycles started"",
        ""number"": ""346""
      },
      {
        ""type"": ""numberOfCyclesReachingEggCollectionStage"",
        ""displayLabel"": ""Number of cycles reaching egg collection stage"",
        ""number"": ""318""
      },
      {
        ""type"": ""numberOfCyclesReachingEmbryoTransferStage"",
        ""displayLabel"": ""Number of cycles reaching embryo transfer stage"",
        ""number"": ""251""
      },
      {
        ""type"": ""numberOfEmbryosTransferredDuringAllCycles"",
        ""displayLabel"": ""Total number of embryos transferred during all cycles"",
        ""number"": ""325""
      }
    ],
    ""numberOfEmbryosTransferred"": [
      {
        ""type"": ""averageNumberOfEmbryosTransferredDuringAllCycles"",
        ""displayLabel"": ""Average number of embryos transferred during all cycles"",
        ""number"": ""1.29""
      },
      {
        ""type"": ""proportionSingleEmbryoTransfersElective"",
        ""displayLabel"": ""Proportion single embryo transfers (elective)"",
        ""number"": ""51%""
      },
      {
        ""type"": ""proportionOfSingleEmbryoTransfersNonElective"",
        ""displayLabel"": ""Proportion of single embryo transfers (non elective)"",
        ""number"": ""19%""
      },
      {
        ""type"": ""proportionOfTwoEmbryoTransfers"",
        ""displayLabel"": ""Proportion of two embryo transfers"",
        ""number"": ""29%""
      },
      {
        ""type"": ""proportionOfThreeEmbryoTransfers"",
        ""displayLabel"": ""Proportion of three embryo transfers"",
        ""number"": ""0%""
      },
      {
        ""type"": ""proportionOfAllEmbryoTransfersThatWereBlastocysts"",
        ""displayLabel"": ""Proportion of all embryos transfers that were blastocysts"",
        ""number"": ""78%""
      }
    ],
    ""numberOfCyclesCancelledBeforeEggsWereCollected"": [
      {
        ""type"": ""abandonedBeforeEggCollectionUnderResponse"",
        ""displayLabel"": ""Patient had not produced enough eggs to collect after taking fertility drugs"",
        ""number"": ""24""
      },
      {
        ""type"": ""abandonedBeforeEggCollectionOverResponse"",
        ""displayLabel"": ""Patient had an adverse reaction to fertility drugs – unsafe to continue cycle"",
        ""number"": ""2""
      },
      {
        ""type"": ""abandonedBeforeEggCollectionOther"",
        ""displayLabel"": ""Other"",
        ""number"": ""2""
      },
      {
        ""type"": ""AbandonedBeforeEggCollectionNoReason"",
        ""displayLabel"": ""Reason not supplied"",
        ""number"": ""0""
      }
    ],
    ""numberOfCyclesCancelledBetweenEggCollectionAndEmbryoTransfer"": [
      {
        ""type"": ""abandonedBeforeEmbryoTransferOverResponse"",
        ""displayLabel"": ""Over response (Patient has produced too many eggs after taking fertility drugs and it would not be safe to continue the cycle)"",
        ""number"": ""22""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferAbnormal"",
        ""displayLabel"": ""Embryos did not develop normally"",
        ""number"": ""10""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferFailedThaw"",
        ""displayLabel"": ""Embryos did not thaw properly (when cycle was using frozen embryos)"",
        ""number"": ""0""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferGenetic"",
        ""displayLabel"": ""Embryos tested positive for a genetic test"",
        ""number"": ""0""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferOther"",
        ""displayLabel"": ""Other"",
        ""number"": ""6""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferNoEmbryoDeveloped"",
        ""displayLabel"": ""No embryos developed"",
        ""number"": ""29""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferNoReason"",
        ""displayLabel"": ""Reason not supplied"",
        ""number"": ""0""
      }
    ],
    ""chartData"": [
      {
        ""type"": ""averageNumberOfEmbryosTransferredDuringAllCycles"",
        ""displayLabel"": ""Average number of embryos transferred during all cycles"",
        ""number"": ""1.29""
      },
      {
        ""type"": ""proportionSingleEmbryoTransfersElective"",
        ""displayLabel"": ""Proportion single embryo transfers (elective)"",
        ""number"": ""51%""
      },
      {
        ""type"": ""proportionOfSingleEmbryoTransfersNonElective"",
        ""displayLabel"": ""Proportion of single embryo transfers (non elective)"",
        ""number"": ""19%""
      },
      {
        ""type"": ""proportionOfTwoEmbryoTransfers"",
        ""displayLabel"": ""Proportion of two embryo transfers"",
        ""number"": ""29%""
      },
      {
        ""type"": ""proportionOfThreeEmbryoTransfers"",
        ""displayLabel"": ""Proportion of three embryo transfers"",
        ""number"": ""0%""
      }
    ],
    ""pregnanciesAndLiveBirthsPerTreatmentCycle"": [
      {
        ""type"": ""pregnanciesPerCycle"",
        ""displayLabel"": ""Pregnancies per cycle"",
        ""successNumber"": ""105 out of 346"",
        ""predictedSuccessChanceRange"": ""23% - 38%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient becoming pregnant"",
        ""predictedSuccessMostLikely"": ""30%"",
        ""nationalPercentage"": ""37%"",
        ""nationalCompare"": ""Consistent with""
      },
      {
        ""type"": ""liveBirthsPerCycle"",
        ""displayLabel"": ""Live births per cycle"",
        ""successNumber"": ""101 out of 346"",
        ""predictedSuccessChanceRange"": ""22% - 37%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""29%"",
        ""nationalPercentage"": ""34%"",
        ""nationalCompare"": ""Consistent with""
      },
      {
        ""type"": ""singletonLiveBirthsPerCycle"",
        ""displayLabel"": ""Singleton live births per cycle"",
        ""successNumber"": ""92 out of 346"",
        ""predictedSuccessChanceRange"": ""20% - 34%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""27%"",
        ""nationalPercentage"": ""29%"",
        ""nationalCompare"": ""Consistent with""
      },
      {
        ""type"": ""multipleLiveBirthsPerCycle"",
        ""displayLabel"": ""Multiple births per cycle"",
        ""successNumber"": ""9 out of 346"",
        ""predictedSuccessChanceRange"": ""1% - 7%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""3%"",
        ""nationalPercentage"": ""5%"",
        ""nationalCompare"": ""Consistent with""
      },
      {
        ""type"": ""liveBirthsPerEggCollection"",
        ""displayLabel"": ""Live births per egg collection"",
        ""successNumber"": ""101 out of 318"",
        ""predictedSuccessChanceRange"": ""24% - 40%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""32%"",
        ""nationalPercentage"": ""35%"",
        ""nationalCompare"": ""Consistent with""
      },
      {
        ""type"": ""liveBirthsPerEmbryoTransfer"",
        ""displayLabel"": ""Live births per embryo transfer"",
        ""successNumber"": ""101 out of 251"",
        ""predictedSuccessChanceRange"": ""31% - 50%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""40%"",
        ""nationalPercentage"": ""39%"",
        ""nationalCompare"": ""Consistent with""
      },
      {
        ""type"": ""miscarriagesPerCycle"",
        ""displayLabel"": ""Miscarriages per cycle"",
        ""successNumber"": ""4 out of 346"",
        ""predictedSuccessChanceRange"": ""0% - 5%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""1%"",
        ""nationalPercentage"": ""3%"",
        ""nationalCompare"": ""Consistent with""
      }
    ],
    ""pregnanciesAndLiveBirthsPerEmbryoTransferred"": [
      {
        ""type"": ""pregnanciesPerCycle"",
        ""displayLabel"": ""Pregnancies per cycle"",
        ""successNumber"": ""105 out of 325"",
        ""predictedSuccessChanceRange"": ""25% - 41%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient becoming pregnant"",
        ""predictedSuccessMostLikely"": ""32%"",
        ""nationalPercentage"": ""30%"",
        ""nationalCompare"": ""Consistent with""
      },
      {
        ""type"": ""liveBirthsPerCycle"",
        ""displayLabel"": ""Live births per cycle"",
        ""successNumber"": ""101 out of 325"",
        ""predictedSuccessChanceRange"": ""24% - 39%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""31%"",
        ""nationalPercentage"": ""27%"",
        ""nationalCompare"": ""Consistent with""
      },
      {
        ""type"": ""singletonLiveBirthsPerCycle"",
        ""displayLabel"": ""Singleton live births per cycle"",
        ""successNumber"": ""92 out of 325"",
        ""predictedSuccessChanceRange"": ""21% - 37%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""28%"",
        ""nationalPercentage"": ""23%"",
        ""nationalCompare"": ""Consistent with""
      },
      {
        ""type"": ""multipleLiveBirthsPerCycle"",
        ""displayLabel"": ""Multiple births per cycle"",
        ""successNumber"": ""9 out of 325"",
        ""predictedSuccessChanceRange"": ""1% - 7%"",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""3%"",
        ""nationalPercentage"": ""4%"",
        ""nationalCompare"": ""Consistent with""
      }
    ],
    ""ageSplitOfPatients"": [
      {
        ""type"": ""under35"",
        ""displayLabel"": ""Under 35"",
        ""clinicPercentage"": ""0%"",
        ""nationalPercentage"": ""0%""
      },
      {
        ""type"": ""35to37"",
        ""displayLabel"": ""35-37"",
        ""clinicPercentage"": ""0%"",
        ""nationalPercentage"": ""0%""
      },
      {
        ""type"": ""38to39"",
        ""displayLabel"": ""38-39"",
        ""clinicPercentage"": ""0%"",
        ""nationalPercentage"": ""0%""
      },
      {
        ""type"": ""40to42"",
        ""displayLabel"": ""40-42"",
        ""clinicPercentage"": ""0%"",
        ""nationalPercentage"": ""0%""
      },
      {
        ""type"": ""43to44"",
        ""displayLabel"": ""43-44"",
        ""clinicPercentage"": ""0%"",
        ""nationalPercentage"": ""0%""
      },
      {
        ""type"": ""over44"",
        ""displayLabel"": ""Over 44"",
        ""clinicPercentage"": ""0%"",
        ""nationalPercentage"": ""0%""
      },
      {
        ""type"": ""unknownAge"",
        ""displayLabel"": ""Unknown age"",
        ""clinicPercentage"": ""0%"",
        ""nationalPercentage"": ""0%""
      },
      {
        ""type"": ""averageLengthOfInfertility"",
        ""displayLabel"": ""Average length of infertility of patients treated"",
        ""clinicPercentage"": ""0%"",
        ""nationalPercentage"": ""0%""
      }
    ]
  }
}
";


      

            }
        }


        private const string JSON321 = @"
{
  ""id"": 321,
  ""centreName"": ""NewLife Fertility Centre"",
  ""successRates"": {
    ""successRateBreakdown"": {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 3 year aggregate data (01/07/2011 - 30/06/2014)""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    ""overviewOfCycles"": [
      {
        ""type"": ""numberOfCyclesStarted"",
        ""displayLabel"": ""Number of cycles started"",
        ""number"": ""0""
      },
      {
        ""type"": ""numberOfCyclesReachingEggCollectionStage"",
        ""displayLabel"": ""Number of cycles reaching egg collection stage"",
        ""number"": ""N/A""
      },
      {
        ""type"": ""numberOfCyclesReachingEmbryoTransferStage"",
        ""displayLabel"": ""Number of cycles reaching embryo transfer stage"",
        ""number"": ""0""
      }
    ],
    ""numberOfEmbryosTransferred"": [
      {
        ""type"": ""numberOfEmbryosTransferredDuringAllCycles"",
        ""displayLabel"": ""Total number of embryos transferred during all cycles"",
        ""number"": ""0""
      },
      {
        ""type"": ""proportionOfAllEmbryoTransfersThatWereBlastocysts"",
        ""displayLabel"": ""Proportion of all embryos transfers that were blastocysts"",
        ""number"": ""0%""
      }
    ],
    ""numberOfCyclesCancelledBeforeEggsWereCollected"": [
      {
        ""type"": ""abandonedBeforeEggCollectionUnderResponse"",
        ""displayLabel"": ""Patient had not produced enough eggs to collect after taking fertility drugs"",
        ""number"": ""N/A""
      },
      {
        ""type"": ""abandonedBeforeEggCollectionOverResponse"",
        ""displayLabel"": ""Patient had an adverse reaction to fertility drugs – unsafe to continue cycle"",
        ""number"": ""N/A""
      },
      {
        ""type"": ""abandonedBeforeEggCollectionOther"",
        ""displayLabel"": ""Other"",
        ""number"": ""N/A""
      },
      {
        ""type"": ""AbandonedBeforeEggCollectionNoReason"",
        ""displayLabel"": ""Reason not supplied"",
        ""number"": ""N/A""
      }
    ],
    ""numberOfCyclesCancelledBetweenEggCollectionAndEmbryoTransfer"": [
      {
        ""type"": ""abandonedBeforeEmbryoTransferOverResponse"",
        ""displayLabel"": ""Over response (Patient has produced too many eggs after taking fertility drugs and it would not be safe to continue the cycle)"",
        ""number"": ""0""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferAbnormal"",
        ""displayLabel"": ""Embryos did not develop normally"",
        ""number"": ""0""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferFailedThaw"",
        ""displayLabel"": ""Embryos did not thaw properly (when cycle was using frozen embryos)"",
        ""number"": ""0""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferGenetic"",
        ""displayLabel"": ""Embryos tested positive for a genetic test"",
        ""number"": ""0""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferOther"",
        ""displayLabel"": ""Other"",
        ""number"": ""0""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferNoEmbryoDeveloped"",
        ""displayLabel"": ""No embryos developed"",
        ""number"": ""0""
      },
      {
        ""type"": ""abandonedBeforeEmbryoTransferNoReason"",
        ""displayLabel"": ""Reason not supplied"",
        ""number"": ""0""
      }
    ],
    ""chartData"": [
      {
        ""type"": ""averageNumberOfEmbryosTransferredDuringAllCycles"",
        ""displayLabel"": ""Average number of embryos transferred during all cycles"",
        ""number"": ""0""
      },
      {
        ""type"": ""proportionSingleEmbryoTransfersElective"",
        ""displayLabel"": ""Proportion single embryo transfers (elective)"",
        ""number"": ""0%""
      },
      {
        ""type"": ""proportionOfSingleEmbryoTransfersNonElective"",
        ""displayLabel"": ""Proportion of single embryo transfers (non elective)"",
        ""number"": ""0%""
      },
      {
        ""type"": ""proportionOfTwoEmbryoTransfers"",
        ""displayLabel"": ""Proportion of two embryo transfers"",
        ""number"": ""0%""
      },
      {
        ""type"": ""proportionOfThreeEmbryoTransfers"",
        ""displayLabel"": ""Proportion of three embryo transfers"",
        ""number"": ""0%""
      }
    ],
    ""pregnanciesAndLiveBirthsPerTreatmentCycle"": [
      {
        ""type"": ""pregnanciesPerCycle"",
        ""displayLabel"": ""Pregnancies per cycle"",
        ""successNumber"": ""0 out of 0"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient becoming pregnant"",
        ""predictedSuccessMostLikely"": ""**"",
        ""nationalPercentage"": ""38%"",
        ""nationalCompare"": """"
      },
      {
        ""type"": ""liveBirthsPerCycle"",
        ""displayLabel"": ""Live births per cycle"",
        ""successNumber"": ""0 out of 0"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""**"",
        ""nationalPercentage"": ""34%"",
        ""nationalCompare"": """"
      },
      {
        ""type"": ""singletonLiveBirthsPerCycle"",
        ""displayLabel"": ""Singleton live births per cycle"",
        ""successNumber"": ""0 out of 0"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""**"",
        ""nationalPercentage"": ""27%"",
        ""nationalCompare"": """"
      },
      {
        ""type"": ""multipleLiveBirthsPerCycle"",
        ""displayLabel"": ""Multiple births per cycle"",
        ""successNumber"": ""0 out of 0"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""**"",
        ""nationalPercentage"": ""6%"",
        ""nationalCompare"": """"
      },
      {
        ""type"": ""liveBirthsPerEggCollection"",
        ""displayLabel"": ""Live births per egg collection"",
        ""successNumber"": ""N/A"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""N/A"",
        ""nationalPercentage"": ""N/A"",
        ""nationalCompare"": """"
      },
      {
        ""type"": ""liveBirthsPerEmbryoTransfer"",
        ""displayLabel"": ""Live births per embryo transfer"",
        ""successNumber"": ""0 out of 0"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""**"",
        ""nationalPercentage"": ""36%"",
        ""nationalCompare"": """"
      }
    ],
    ""pregnanciesAndLiveBirthsPerEmbryoTransferred"": [
      {
        ""type"": ""pregnanciesPerCycle"",
        ""displayLabel"": ""Pregnancies per cycle"",
        ""successNumber"": ""0 out of 0"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient becoming pregnant"",
        ""predictedSuccessMostLikely"": ""**"",
        ""nationalPercentage"": ""25%"",
        ""nationalCompare"": """"
      },
      {
        ""type"": ""liveBirthsPerCycle"",
        ""displayLabel"": ""Live births per cycle"",
        ""successNumber"": ""0 out of 0"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""**"",
        ""nationalPercentage"": ""22%"",
        ""nationalCompare"": """"
      },
      {
        ""type"": ""singletonLiveBirthsPerCycle"",
        ""displayLabel"": ""Singleton live births per cycle"",
        ""successNumber"": ""0 out of 0"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""**"",
        ""nationalPercentage"": ""18%"",
        ""nationalCompare"": """"
      },
      {
        ""type"": ""multipleLiveBirthsPerCycle"",
        ""displayLabel"": ""Multiple births per cycle"",
        ""successNumber"": ""0 out of 0"",
        ""predictedSuccessChanceRange"": """",
        ""predictedSuccessMostLikelyLabel"": ""Predicated chance of an average patient having a live birth"",
        ""predictedSuccessMostLikely"": ""**"",
        ""nationalPercentage"": ""4%"",
        ""nationalCompare"": """"
      }
    ],
    ""ageSplitOfPatients"": [
      {
        ""type"": ""under35"",
        ""displayLabel"": ""Under 35"",
        ""clinicPercentage"": null,
        ""nationalPercentage"": null
      },
      {
        ""type"": ""35to37"",
        ""displayLabel"": ""35-37"",
        ""clinicPercentage"": null,
        ""nationalPercentage"": null
      },
      {
        ""type"": ""38to39"",
        ""displayLabel"": ""38-39"",
        ""clinicPercentage"": null,
        ""nationalPercentage"": null
      },
      {
        ""type"": ""40to42"",
        ""displayLabel"": ""40-42"",
        ""clinicPercentage"": null,
        ""nationalPercentage"": null
      },
      {
        ""type"": ""43to44"",
        ""displayLabel"": ""43-44"",
        ""clinicPercentage"": null,
        ""nationalPercentage"": null
      },
      {
        ""type"": ""over44"",
        ""displayLabel"": ""Over 44"",
        ""clinicPercentage"": null,
        ""nationalPercentage"": null
      },
      {
        ""type"": ""averageLengthOfInfertility"",
        ""displayLabel"": ""Average length of infertility of patients treated"",
        ""clinicPercentage"": null,
        ""nationalPercentage"": null
      }
    ]
  }
}
";

    }
}
