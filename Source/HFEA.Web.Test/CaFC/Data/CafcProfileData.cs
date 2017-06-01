using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.CaFC.Data
{
    public class CafcProfileData
    {        
        internal const string Profile = @"
{
  ""id"": 9018,
  ""centreName"": ""HFEA Generic Centre"",
  ""centreType"": 878,
  ""centreTypeDescription"": ""Treatment with Storage"",
  ""distanceFromSource"": 0,
  ""indicativeSuccessRate"": ""35.3%"",
  ""nationalAverage"": ""34.2%"",
  ""centreEmail"": ""info@hfea.gov.uk"",
  ""centrePhone"": ""01234 567 8910"",
  ""otherCentrePhone"": null,
  ""website"": ""www.hfea.gov.uk"",
  ""fax"": ""01234 212 2121"",
  ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/9018Profile"",
  ""indicativeSuccessRateCaveat"": ""This is the indicative success rate caveat. The text here can be long so the front end design needs to accommodate this. This is the generic centre 9018."",
  ""successRateSummaryCaveat"": ""This is the success rate summary caveat. The text here can be long so the front end design needs to accommodate this. This is the generic centre 9018."",
  ""images"": [
    {
      ""imageType"": ""Profile"",
      ""imageUri"": ""https://someblob.blob.core.windows.net/images/9018Profile""
    }
  ],
  ""mainAddress"": {
    ""addressType"": ""Main"",
    ""entityType"": ""Centre"",
    ""subDwelling"": ""Finsbury Tower"",
    ""numberName"": ""103-105"",
    ""street"": ""Bunhill Row"",
    ""locality"": ""London"",
    ""town"": null,
    ""county"": null,
    ""postcode"": ""EC1Y 8HF"",
    ""computedBS7666Address"": ""Finsbury Tower, 103-105, Bunhill Row, London, London, EC1Y 8HF, "",
    ""startDate"": ""2014-11-12T00:00:00"",
    ""endDate"": null,
    ""country"": null
  },
  ""mapToolTip"": {
    ""name"": ""HFEA Generic Centre"",
    ""type"": ""Treatment with Storage""
  },
  ""links"": [
    {
      ""parentCentreId"": 9018,
      ""parentCentreName"": ""HFEA Generic Centre"",
      ""linkCentreId"": 88,
      ""linkCentreName"": ""London Fertility Centre"",
      ""linkType"": 1520,
      ""linkTypeDescription"": ""Satellite"",
      ""linkCentreAddress"": {
        ""addressType"": ""Main"",
        ""entityType"": ""Centre"",
        ""subDwelling"": """",
        ""numberName"": ""53"",
        ""street"": ""Portland Place"",
        ""locality"": """",
        ""town"": ""London"",
        ""county"": null,
        ""postcode"": ""W1B 1QJ"",
        ""computedBS7666Address"": null,
        ""startDate"": ""0001-01-01T00:00:00"",
        ""endDate"": null,
        ""country"": null
      },
      ""linkCentrePhone"": ""020 7224 0707\n020 7317 1071""
    }
  ],
  ""centreSuccessRateSummary"": {
    ""dataDateRangeStart"": ""2013-01-01T00:00:00"",
    ""dataDateRangeEnd"": ""2014-12-31T00:00:00"",
    ""genericTreatment"": ""Ivf"",
    ""genericTreatmentClinicValue"": 52,
    ""genericTreatmentNationalValue"": 62,
    ""pregnancyRates"": [
      {
        ""date"": ""2016-12-01T00:00:00"",
        ""pregnancyRate"": 41,
        ""multiplePregnancyRate"": 31
      },
      {
        ""date"": ""2016-09-01T00:00:00"",
        ""pregnancyRate"": 51,
        ""multiplePregnancyRate"": 41
      },
      {
        ""date"": ""2016-06-01T00:00:00"",
        ""pregnancyRate"": 61,
        ""multiplePregnancyRate"": 51
      },
      {
        ""date"": ""2016-03-01T00:00:00"",
        ""pregnancyRate"": 31,
        ""multiplePregnancyRate"": 21
      },
      {
        ""date"": ""2015-12-01T00:00:00"",
        ""pregnancyRate"": 41,
        ""multiplePregnancyRate"": 31
      },
      {
        ""date"": ""2015-09-01T00:00:00"",
        ""pregnancyRate"": 51,
        ""multiplePregnancyRate"": 41
      },
      {
        ""date"": ""2015-06-01T00:00:00"",
        ""pregnancyRate"": 61,
        ""multiplePregnancyRate"": 51
      },
      {
        ""date"": ""2015-03-01T00:00:00"",
        ""pregnancyRate"": 31,
        ""multiplePregnancyRate"": 21
      },
      {
        ""date"": ""2014-12-01T00:00:00"",
        ""pregnancyRate"": 41,
        ""multiplePregnancyRate"": 31
      },
      {
        ""date"": ""2014-09-01T00:00:00"",
        ""pregnancyRate"": 51,
        ""multiplePregnancyRate"": 41
      },
      {
        ""date"": ""2014-06-01T00:00:00"",
        ""pregnancyRate"": 61,
        ""multiplePregnancyRate"": 51
      },
      {
        ""date"": ""2014-03-01T00:00:00"",
        ""pregnancyRate"": 31,
        ""multiplePregnancyRate"": 21
      }
    ],
    ""fieldU38OverallCountBet"": 0,
    ""fieldU38Bet"": 1251,
    ""fieldU38BetEst"": 35,
    ""fieldU38BetNational"": 38,
    ""fieldU38BetChanceLower"": 25,
    ""fieldU38BetChanceHigher"": 54,
    ""fieldU38BetCompareNat"": ""Below"",
    ""fieldO38OverallCountBet"": 0,
    ""fieldO38Bet"": 758,
    ""fieldO38BetEst"": 55,
    ""fieldO38BetNational"": 54,
    ""fieldO38BetChanceLower"": 30,
    ""fieldO38BetChanceHigher"": 60,
    ""fieldO38BetCompareNat"": ""Above"",
    ""fieldAllOverallCountBet"": 0,
    ""fieldAllBet"": 600,
    ""fieldAllBetEst"": 27,
    ""fieldAllBetNational"": 32,
    ""fieldAllBetChanceLower"": 10,
    ""fieldAllBetChanceHigher"": 80,
    ""fieldAllBetCompareNat"": ""Below"",
    ""fieldU38OverallCountBec"": 0,
    ""fieldU38Bec"": 695,
    ""fieldU38BecEst"": 22,
    ""fieldU38BecNational"": 20,
    ""fieldU38BecChanceLower"": 12,
    ""fieldU38BecChanceHigher"": 60,
    ""fieldU38BecCompareNat"": ""Above"",
    ""fieldO38OverallCountBec"": 0,
    ""fieldO38Bec"": 87,
    ""fieldO38BecEst"": 44,
    ""fieldO38BecNational"": 40,
    ""fieldO38BecChanceLower"": 12,
    ""fieldO38BecChanceHigher"": 65,
    ""fieldO38BecCompareNat"": ""Above"",
    ""fieldAllOverallCountBec"": 0,
    ""fieldAllBec"": 222,
    ""fieldAllBecEst"": 31,
    ""fieldAllBecNational"": 0,
    ""fieldAllBecChanceLower"": 12,
    ""fieldAllBecChanceHigher"": 35,
    ""fieldAllBecCompareNat"": ""Below"",
    ""fieldU38OverallCountMlb"": 0,
    ""fieldU38Mlb"": 555,
    ""fieldU38MlbEst"": 34,
    ""fieldU38MlbNational"": 55,
    ""fieldU38MlbChanceLower"": 12,
    ""fieldU38MlbChanceHigher"": 60,
    ""fieldU38MlbCompareNat"": ""Below"",
    ""fieldU38MlbTar"": 44,
    ""fieldO38OverallCountMlb"": 0,
    ""fieldO38Mlb"": 285,
    ""fieldO38MlbEst"": 22,
    ""fieldO38MlbNational"": 22,
    ""fieldO38MlbChanceLower"": 12,
    ""fieldO38MlbChanceHigher"": 34,
    ""fieldO38MlbCompareNat"": ""Consistent with"",
    ""fieldO38MlbTar"": 34,
    ""fieldAllOverallCountMlb"": 0,
    ""fieldAllMlb"": 126,
    ""fieldAllMlbEst"": 35,
    ""fieldAllMlbNational"": 30,
    ""fieldAllMlbChanceLower"": 10,
    ""fieldAllMlbChanceHigher"": 50,
    ""fieldAllMlbCompareNat"": ""Above"",
    ""fieldAllMlbTar"": 32,
    ""fieldU38OverallCountPreg"": 0,
    ""fieldU38Preg"": 684,
    ""fieldU38PregEst"": 66,
    ""fieldU38PregNational"": 53,
    ""fieldU38PregChanceLower"": 12,
    ""fieldU38PregChanceHigher"": 70,
    ""fieldU38PregCompareNat"": ""Above"",
    ""fieldO38OverallCountPreg"": 0,
    ""fieldO38Preg"": 531,
    ""fieldO38PregEst"": 61,
    ""fieldO38PregNational"": 60,
    ""fieldO38PregChanceLower"": 41,
    ""fieldO38PregChanceHigher"": 71,
    ""fieldO38PregCompareNat"": ""Above"",
    ""fieldAllOverallCountPreg"": 0,
    ""fieldAllPreg"": 534,
    ""fieldAllPregEst"": 34,
    ""fieldAllPregNational"": 45,
    ""fieldAllPregChanceLower"": 24,
    ""fieldAllPregChanceHigher"": 60,
    ""fieldAllPregCompareNat"": ""Below"",
    ""fieldU38OverallCountDi"": 0,
    ""fieldU38Di"": 43,
    ""fieldU38DiEst"": 68,
    ""fieldU38DiNational"": 50,
    ""fieldU38DiChanceLower"": 34,
    ""fieldU38DiChanceHigher"": 75,
    ""fieldU38DiCompareNat"": ""Above"",
    ""fieldO38OverallCountDi"": 0,
    ""fieldO38Di"": 165,
    ""fieldO38DiEst"": 44,
    ""fieldO38DiNational"": 35,
    ""fieldO38DiChanceLower"": 23,
    ""fieldO38DiChanceHigher"": 30,
    ""fieldO38DiCompareNat"": ""Above"",
    ""fieldAllOverallCountDi"": 0,
    ""fieldAllDi"": 652,
    ""fieldAllDiEst"": 45,
    ""fieldAllDiNational"": 50,
    ""fieldAllDiChanceLower"": 20,
    ""fieldAllDiChanceHigher"": 70,
    ""fieldAllDiCompareNat"": ""Below""
  },
  ""patientExperiences"": {
    ""overallScore"": 3,
    ""numberOfReviews"": 698,
    ""shortRatingsList"": [
      {
        ""question"": ""How likely are you to recommend this clinic to friends and family if they needed similar care or treatment?"",
        ""overallScore"": 1,
        ""numberOfReviews"": 587,
        ""scoreValue1Text"": null,
        ""scoreValue1"": 568,
        ""scoreValue2Text"": null,
        ""scoreValue2"": 5,
        ""scoreValue3Text"": null,
        ""scoreValue3"": 2,
        ""scoreValue4Text"": null,
        ""scoreValue4"": 8,
        ""scoreValue5Text"": null,
        ""scoreValue5"": 4
      },
      {
        ""question"": ""To what extent did you feel you were treated with privacy and dignity?"",
        ""overallScore"": 3,
        ""numberOfReviews"": 578,
        ""scoreValue1Text"": null,
        ""scoreValue1"": 4,
        ""scoreValue2Text"": null,
        ""scoreValue2"": 6,
        ""scoreValue3Text"": null,
        ""scoreValue3"": 553,
        ""scoreValue4Text"": null,
        ""scoreValue4"": 1,
        ""scoreValue5Text"": null,
        ""scoreValue5"": 14
      },
      {
        ""question"": ""To what extent did you feel you understood everything that was happening throughout your treatment?"",
        ""overallScore"": 2,
        ""numberOfReviews"": 370,
        ""scoreValue1Text"": null,
        ""scoreValue1"": 268,
        ""scoreValue2Text"": null,
        ""scoreValue2"": 3,
        ""scoreValue3Text"": null,
        ""scoreValue3"": 2,
        ""scoreValue4Text"": null,
        ""scoreValue4"": 93,
        ""scoreValue5Text"": null,
        ""scoreValue5"": 4
      },
      {
        ""question"": ""Was your level of involvement in decisions about your treatment?"",
        ""overallScore"": 4.5,
        ""numberOfReviews"": 502,
        ""scoreValue1Text"": null,
        ""scoreValue1"": 26,
        ""scoreValue2Text"": null,
        ""scoreValue2"": 3,
        ""scoreValue3Text"": null,
        ""scoreValue3"": 2,
        ""scoreValue4Text"": null,
        ""scoreValue4"": 48,
        ""scoreValue5Text"": null,
        ""scoreValue5"": 423
      },
      {
        ""question"": ""Was the level of empathy and understanding shown towards you by the clinic team?"",
        ""overallScore"": 4,
        ""numberOfReviews"": 397,
        ""scoreValue1Text"": null,
        ""scoreValue1"": 26,
        ""scoreValue2Text"": null,
        ""scoreValue2"": 3,
        ""scoreValue3Text"": null,
        ""scoreValue3"": 2,
        ""scoreValue4Text"": null,
        ""scoreValue4"": 362,
        ""scoreValue5Text"": null,
        ""scoreValue5"": 4
      }
    ],
    ""accuracyOfCostEstimate"": {
      ""question"": ""Did you pay what you expected?"",
      ""overallScore"": 0,
      ""numberOfReviews"": 17,
      ""scoreValue1Text"": ""It was much cheaper"",
      ""scoreValue1"": 1,
      ""scoreValue2Text"": ""It was slightly cheaper"",
      ""scoreValue2"": 3,
      ""scoreValue3Text"": ""It was about right"",
      ""scoreValue3"": 2,
      ""scoreValue4Text"": ""It was more expensive"",
      ""scoreValue4"": 7,
      ""scoreValue5Text"": ""It was way above the estimate"",
      ""scoreValue5"": 4
    }
  },
  ""inspectionRating"": 0,
  ""inspectionRatingProfile"": {
    ""OverallScore"": 4,
    ""InspectionSummary"": ""This is the inspection summary text entered by an inspector, read from the database."",
    ""CentreProfile"": ""This is the profile text entered by an inspector, read from the database. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus."",
    ""LicenceExpires"": ""2017-03-31T00:00:00"",
    ""LastInspected"": ""2015-04-06T00:00:00""
  },
  ""coordinates"": {
    ""lat"": 51.5216931,
    ""lng"": -0.08961650000003374
  },
  ""openingTimes"": [
    {
      ""isOpened"": false,
      ""day"": 0,
      ""openTime"": ""Closed"",
      ""closeTime"": ""Closed""
    },
    {
      ""isOpened"": true,
      ""day"": 1,
      ""openTime"": ""09:00"",
      ""closeTime"": ""18:00""
    },
    {
      ""isOpened"": true,
      ""day"": 2,
      ""openTime"": ""09:00"",
      ""closeTime"": ""18:00""
    },
    {
      ""isOpened"": true,
      ""day"": 3,
      ""openTime"": ""09:00"",
      ""closeTime"": ""18:00""
    },
    {
      ""isOpened"": true,
      ""day"": 4,
      ""openTime"": ""09:30"",
      ""closeTime"": ""18:00""
    },
    {
      ""isOpened"": true,
      ""day"": 5,
      ""openTime"": ""10:00"",
      ""closeTime"": ""17:00""
    },
    {
      ""isOpened"": false,
      ""day"": 6,
      ""openTime"": ""Closed"",
      ""closeTime"": ""Closed""
    }
  ],
  ""treatmentsOffered"": [
    {
      ""id"": 1829,
      ""name"": ""IVF""
    },
    {
      ""id"": 1830,
      ""name"": ""ICSI""
    },
    {
      ""id"": 1817,
      ""name"": ""Insemination""
    },
    {
      ""id"": 1808,
      ""name"": ""Surgical sperm collection""
    },
    {
      ""id"": 3298,
      ""name"": ""Fertility preservation""
    },
    {
      ""id"": 1813,
      ""name"": ""In vitro maturation""
    },
    {
      ""id"": 2046,
      ""name"": ""IVF for patients with communicable viral infections""
    }
  ],
  ""eligibilityAndFunding"": [
    {
      ""Id"": 2012,
      ""Name"": ""BMI limit"",
      ""Description"": ""30""
    },
    {
      ""Id"": 2024,
      ""Name"": ""Patients from abroad"",
      ""Description"": """"
    },
    {
      ""Id"": 2028,
      ""Name"": ""Treats NHS patients"",
      ""Description"": """"
    },
    {
      ""Id"": 2029,
      ""Name"": ""Treats private patients"",
      ""Description"": """"
    },
    {
      ""Id"": 2030,
      ""Name"": ""Upper age limit of patients treated"",
      ""Description"": ""45""
    },
    {
      ""Id"": 2031,
      ""Name"": ""Upper male age limit"",
      ""Description"": ""40""
    }
  ],
  ""staff"": [
    {
      ""id"": 2009,
      ""name"": ""Female doctor available""
    },
    {
      ""id"": 2010,
      ""name"": ""Named nurse system""
    },
    {
      ""id"": 2011,
      ""name"": ""One physician throughout treatment""
    }
  ],
  ""facilities"": [
    {
      ""id"": 1995,
      ""name"": ""Wheelchair access""
    },
    {
      ""id"": 2001,
      ""name"": ""Parking""
    },
    {
      ""id"": 2003,
      ""name"": ""Near public transport""
    }
  ],
  ""companyType"": [
    {
      ""id"": 1986,
      ""name"": ""NHS Trust or unit""
    }
  ],
  ""centreInformation"": [
    {
      ""Id"": 2070,
      ""Name"": ""Ethics Committee"",
      ""Description"": """"
    },
    {
      ""Id"": 2072,
      ""Name"": ""Emergency out of hours contact"",
      ""Description"": ""0207 291 8311""
    },
    {
      ""Id"": 2073,
      ""Name"": ""Specialist areas"",
      ""Description"": ""Specialist areas for centre 9018""
    }
  ],
  ""donorServices"": [
    {
      ""id"": 2062,
      ""name"": ""Egg sharing programme""
    },
    {
      ""id"": 2063,
      ""name"": ""Known donor programme""
    },
    {
      ""id"": 2064,
      ""name"": ""Recruits egg donors""
    },
    {
      ""id"": 2067,
      ""name"": ""Recruits donors for research projects""
    },
    {
      ""id"": 2068,
      ""name"": ""Recruits sperm donors""
    },
    {
      ""id"": 2069,
      ""name"": ""Sperm sharing""
    }
  ],
  ""screeningServices"": [
    {
      ""id"": 1834,
      ""name"": ""PGD""
    },
    {
      ""id"": 1835,
      ""name"": ""PGS""
    }
  ],
  ""counsellingAndSupport"": [
    {
      ""Id"": 2032,
      ""Name"": ""Compulsory counselling for donors"",
      ""Description"": """"
    },
    {
      ""Id"": 2033,
      ""Name"": ""Counselling services at clinic"",
      ""Description"": """"
    },
    {
      ""Id"": 2035,
      ""Name"": ""Dedicated counsellor"",
      ""Description"": """"
    },
    {
      ""Id"": 2037,
      ""Name"": ""Number of counselling sessions included"",
      ""Description"": ""The number of counselling sessions is not limited""
    }
  ],
  ""nonLicensedTreatmentsAndServices"": [
    {
      ""id"": 2046,
      ""name"": ""IVF for patients with communicable viral infections""
    },
    {
      ""id"": 3298,
      ""name"": ""Fertility preservation""
    }
  ],
  ""spermDonorWaitingTimes"": {
    ""White"": ""Immediately available"",
    ""Asian"": ""Immediately available"",
    ""Black"": ""Immediately available""
  },
  ""eggDonorWaitingTimes"": {
    ""White"": ""More than 6 months"",
    ""Mixed"": ""Less than 1 month"",
    ""Asian"": ""Immediately available"",
    ""Black"": ""Immediately available""
  },
  ""embryoDonorWaitingTimes"": {
    ""White"": ""Immediately available"",
    ""Mixed"": ""Immediately available"",
    ""Asian"": ""More than 6 months"",
    ""Black"": ""More than 6 months""
  }
}";
        
    }
}
