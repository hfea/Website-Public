using HFEA.Connector.Contracts.CaFC.Comparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.CaFCComparison.Data
{
    public class ThreeClinicsData
    {
        public static List<ComparisonClinicInfo> Clinics_4_6_10603
        {
            get
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ComparisonClinicInfo>>(clinics_4_6_10603);
            }
        }

        private const string clinics_4_6_10603 = @"
[
  {
    ""id"": 4,
    ""centreName"": ""Ninewells Hospital"",
    ""centreType"": 878,
    ""centreTypeDescription"": ""Treatment with Storage"",
    ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/4Profile"",
    ""inspectionRating"": 5,
    ""inspectionRatingLicensedUntil"": ""2017-09-30T00:00:00"",
    ""patientRating"": 2.5,
    ""patientRatingNumberOfRatings"": 1,
    ""ivfBirthRateAllAges"": null,
    ""diBirthRateAllAges"": null,
    ""iuiBirthRateAllAges"": null,
    ""multipleBirthRateAllAges"": null,
    ""eligibilityAndFunding"": [
      {
        ""id"": 2012,
        ""name"": ""BMI limit"",
        ""description"": ""&lt;30 for female patients"",
        ""helpText"": null
      },
      {
        ""id"": 2024,
        ""name"": ""Patients from abroad"",
        ""description"": ""Self-funded only - offer of treatment depends on completion of welfare of child assessment"",
        ""helpText"": ""Help text for patients from abroad""
      },
      {
        ""id"": 2028,
        ""name"": ""Treats NHS patients"",
        ""description"": null,
        ""helpText"": null
      },
      {
        ""id"": 2029,
        ""name"": ""Treats private patients"",
        ""description"": null,
        ""helpText"": null
      },
      {
        ""id"": 2030,
        ""name"": ""Upper age limit of patients treated"",
        ""description"": ""2089"",
        ""helpText"": null
      },
      {
        ""id"": 2031,
        ""name"": ""Upper male age limit"",
        ""description"": ""N/A"",
        ""helpText"": null
      }
    ],
    ""treatmentsOffered"": [
      {
        ""id"": 2046,
        ""name"": ""IVF for patients with communicable viral infections"",
        ""helpText"": ""IVF for patients with communicable viral infections""
      }
    ],
    ""donorServices"": [
      {
        ""id"": 2062,
        ""name"": ""Egg sharing programme"",
        ""helpText"": null
      },
      {
        ""id"": 2063,
        ""name"": ""Known donor programme"",
        ""helpText"": null
      },
      {
        ""id"": 2064,
        ""name"": ""Recruits egg donors"",
        ""helpText"": null
      },
      {
        ""id"": 2067,
        ""name"": ""Recruits donors for research projects"",
        ""helpText"": null
      },
      {
        ""id"": 2068,
        ""name"": ""Recruits sperm donors"",
        ""helpText"": null
      }
    ],
    ""spermDonorWaitingTimes"": {
      ""White"": """",
      ""Mixed"": ""No data available"",
      ""Asian"": ""No data available"",
      ""Black"": ""No data available"",
      ""Other ethnic groups"": ""No data available""
    },
    ""eggDonorWaitingTimes"": {
      ""White"": """",
      ""Mixed"": ""No data available"",
      ""Asian"": ""No data available"",
      ""Black"": ""No data available"",
      ""Other ethnic groups"": ""No data available""
    },
    ""embryoDonorWaitingTimes"": {
      ""White"": """",
      ""Mixed"": ""No data available"",
      ""Asian"": ""No data available"",
      ""Black"": ""No data available"",
      ""Other ethnic groups"": ""No data available""
    },
    ""counsellingAndSupport"": [
      {
        ""id"": 2032,
        ""name"": ""Compulsory counselling for donors"",
        ""description"": null,
        ""helpText"": null
      },
      {
        ""id"": 2033,
        ""name"": ""Counselling services at clinic"",
        ""description"": null,
        ""helpText"": ""This is help text for counselling services at clinic""
      },
      {
        ""id"": 2035,
        ""name"": ""Dedicated counsellor"",
        ""description"": null,
        ""helpText"": null
      },
      {
        ""id"": 2037,
        ""name"": ""Number of counselling sessions included"",
        ""description"": ""no charge"",
        ""helpText"": null
      }
    ],
    ""staff"": [
      {
        ""id"": 2009,
        ""name"": ""Female doctor available"",
        ""helpText"": null
      }
    ],
    ""facilities"": [
      {
        ""id"": 1995,
        ""name"": ""Wheelchair access"",
        ""helpText"": null
      },
      {
        ""id"": 2001,
        ""name"": ""Parking"",
        ""helpText"": ""Named nurse system help text""
      }
    ],
    ""openingTimes"": [
      {
        ""isOpened"": false,
        ""day"": 0,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 1,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 2,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 3,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 4,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 5,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 6,
        ""openTime"": null,
        ""closeTime"": null
      }
    ],
    ""otherLookupItems"": [],
    ""mainAddress"": {
      ""addressType"": ""Main"",
      ""entityType"": ""Centre"",
      ""subDwelling"": ""Assisted Conception Unit, Ward 35"",
      ""numberName"": ""Ninewells Hospital"",
      ""street"": null,
      ""locality"": null,
      ""town"": ""Dundee"",
      ""county"": null,
      ""postcode"": ""DD1 9SY"",
      ""computedBS7666Address"": ""Assisted Conception Unit, Ward 35, Ninewells Hospital, Dundee, DD1 9SY, United Kingdom"",
      ""startDate"": ""1999-09-22T00:00:00"",
      ""endDate"": null,
      ""country"": null
    },
    ""links"": []
  },
  {
    ""id"": 6,
    ""centreName"": ""The Lister Fertility Clinic"",
    ""centreType"": 878,
    ""centreTypeDescription"": ""Treatment with Storage"",
    ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
    ""inspectionRating"": 5,
    ""inspectionRatingLicensedUntil"": ""2018-02-28T00:00:00"",
    ""patientRating"": 2,
    ""patientRatingNumberOfRatings"": 37,
    ""ivfBirthRateAllAges"": null,
    ""diBirthRateAllAges"": null,
    ""iuiBirthRateAllAges"": null,
    ""multipleBirthRateAllAges"": null,
    ""eligibilityAndFunding"": [],
    ""treatmentsOffered"": [
      {
        ""id"": 1829,
        ""name"": ""IVF"",
        ""helpText"": ""IVF""
      },
      {
        ""id"": 1830,
        ""name"": ""ICSI"",
        ""helpText"": ""ICSI""
      },
      {
        ""id"": 1817,
        ""name"": ""Insemination"",
        ""helpText"": ""Insemination""
      },
      {
        ""id"": 1808,
        ""name"": ""Surgical sperm collection"",
        ""helpText"": ""Surgical sperm collection""
      },
      {
        ""id"": 2046,
        ""name"": ""IVF for patients with communicable viral infections"",
        ""helpText"": ""IVF for patients with communicable viral infections""
      }
    ],
    ""donorServices"": [
      {
        ""id"": 2062,
        ""name"": ""Egg sharing programme"",
        ""helpText"": null
      },
      {
        ""id"": 2063,
        ""name"": ""Known donor programme"",
        ""helpText"": null
      },
      {
        ""id"": 2064,
        ""name"": ""Recruits egg donors"",
        ""helpText"": null
      }
    ],
    ""spermDonorWaitingTimes"": {
      ""White"": ""Immediately available"",
      ""Mixed"": ""Immediately available"",
      ""Black"": ""Immediately available"",
      ""Asian"": ""No data available"",
      ""Other ethnic groups"": ""No data available""
    },
    ""eggDonorWaitingTimes"": {
      ""White"": ""Immediately available"",
      ""Mixed"": ""Immediately available"",
      ""Black"": ""Immediately available"",
      ""Asian"": ""No data available"",
      ""Other ethnic groups"": ""No data available""
    },
    ""embryoDonorWaitingTimes"": {
      ""White"": ""Immediately available"",
      ""Mixed"": ""Immediately available"",
      ""Black"": ""Immediately available"",
      ""Asian"": ""No data available"",
      ""Other ethnic groups"": ""No data available""
    },
    ""counsellingAndSupport"": [
      {
        ""id"": 2032,
        ""name"": ""Compulsory counselling for donors"",
        ""description"": null,
        ""helpText"": null
      },
      {
        ""id"": 2033,
        ""name"": ""Counselling services at clinic"",
        ""description"": null,
        ""helpText"": ""This is help text for counselling services at clinic""
      },
      {
        ""id"": 2035,
        ""name"": ""Dedicated counsellor"",
        ""description"": null,
        ""helpText"": null
      },
      {
        ""id"": 2037,
        ""name"": ""Number of counselling sessions included"",
        ""description"": ""as required"",
        ""helpText"": null
      }
    ],
    ""staff"": [],
    ""facilities"": [],
    ""openingTimes"": [
      {
        ""isOpened"": false,
        ""day"": 0,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 1,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 2,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 3,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 4,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 5,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 6,
        ""openTime"": null,
        ""closeTime"": null
      }
    ],
    ""otherLookupItems"": [],
    ""mainAddress"": {
      ""addressType"": ""Main"",
      ""entityType"": ""Centre"",
      ""subDwelling"": null,
      ""numberName"": ""The Lister Hospital"",
      ""street"": ""Chelsea Bridge Road"",
      ""locality"": null,
      ""town"": ""London"",
      ""county"": null,
      ""postcode"": ""SW1W 8RH"",
      ""computedBS7666Address"": ""The Lister Hospital, Chelsea Bridge Road, London, SW1W 8RH, United Kingdom"",
      ""startDate"": ""1990-01-01T00:00:00"",
      ""endDate"": null,
      ""country"": null
    },
    ""links"": [
      {
        ""parentCentreId"": 6,
        ""parentCentreName"": ""The Lister Fertility Clinic"",
        ""linkCentreId"": 254,
        ""linkCentreName"": ""The Agora Gynaecology and Fertility Centre"",
        ""linkType"": 1520,
        ""linkTypeDescription"": ""Satellite"",
        ""linkCentreAddress"": {
          ""addressType"": ""Main"",
          ""entityType"": ""Centre"",
          ""subDwelling"": """",
          ""numberName"": ""The Agora"",
          ""street"": ""Ellen Street"",
          ""locality"": """",
          ""town"": ""Brighton & Hove"",
          ""county"": null,
          ""postcode"": ""BN3 3LN"",
          ""computedBS7666Address"": ""The Agora, Ellen Street, Brighton & Hove, BN3 3LN, "",
          ""startDate"": ""2012-03-19T00:00:00"",
          ""endDate"": null,
          ""country"": null
        },
        ""linkCentrePhone"": ""01273 229410""
      },
      {
        ""parentCentreId"": 6,
        ""parentCentreName"": ""The Lister Fertility Clinic"",
        ""linkCentreId"": 9067,
        ""linkCentreName"": ""Spire Thames Valley Hospital"",
        ""linkType"": 1520,
        ""linkTypeDescription"": ""Satellite"",
        ""linkCentreAddress"": {
          ""addressType"": ""Main"",
          ""entityType"": ""Centre"",
          ""subDwelling"": """",
          ""numberName"": ""Spire Thames Valley Hospital"",
          ""street"": ""Wexham Street"",
          ""locality"": ""Wexham, Buckinghamshire"",
          ""town"": null,
          ""county"": null,
          ""postcode"": ""SL3 6NH"",
          ""computedBS7666Address"": ""Spire Thames Valley Hospital, Wexham Street, Wexham, Buckinghamshire, SL3 6NH, "",
          ""startDate"": ""2006-06-09T00:00:00"",
          ""endDate"": null,
          ""country"": null
        },
        ""linkCentrePhone"": null
      },
      {
        ""parentCentreId"": 6,
        ""parentCentreName"": ""The Lister Fertility Clinic"",
        ""linkCentreId"": 9128,
        ""linkCentreName"": ""The Lister Fertility Clinic at City of London Medical Centre"",
        ""linkType"": 1520,
        ""linkTypeDescription"": ""Satellite"",
        ""linkCentreAddress"": null,
        ""linkCentrePhone"": null
      },
      {
        ""parentCentreId"": 6,
        ""parentCentreName"": ""The Lister Fertility Clinic"",
        ""linkCentreId"": 259,
        ""linkCentreName"": ""Epsom And St Helier NHS Trust"",
        ""linkType"": 1521,
        ""linkTypeDescription"": ""Transport"",
        ""linkCentreAddress"": {
          ""addressType"": ""Main"",
          ""entityType"": ""Centre"",
          ""subDwelling"": ""Assisted Conception Unit, Womens Health"",
          ""numberName"": ""St Helier Hospital"",
          ""street"": ""Wrythe Lane"",
          ""locality"": null,
          ""town"": ""Carshalton"",
          ""county"": null,
          ""postcode"": ""SM5 1AA"",
          ""computedBS7666Address"": ""Assisted Conception Unit, Womens Health, St Helier Hospital, Wrythe Lane, Carshalton, Surrey, SM5 1AA, United Kingdom"",
          ""startDate"": ""2007-04-01T00:00:00"",
          ""endDate"": null,
          ""country"": null
        },
        ""linkCentrePhone"": ""02082962101""
      },
      {
        ""parentCentreId"": 6,
        ""parentCentreName"": ""The Lister Fertility Clinic"",
        ""linkCentreId"": 9153,
        ""linkCentreName"": ""Poundbury Fertility"",
        ""linkType"": 1520,
        ""linkTypeDescription"": ""Satellite"",
        ""linkCentreAddress"": {
          ""addressType"": ""Main"",
          ""entityType"": ""Centre"",
          ""subDwelling"": """",
          ""numberName"": ""Poundbury Fertility"",
          ""street"": ""King Edward VII's Hospital"",
          ""locality"": """",
          ""town"": ""Beaumont Street"",
          ""county"": null,
          ""postcode"": ""W1G 6AA"",
          ""computedBS7666Address"": ""Poundbury Fertility, King Edward VII's Hospital, Beaumont Street, London, W1G 6AA, "",
          ""startDate"": ""2015-02-06T00:00:00"",
          ""endDate"": null,
          ""country"": null
        },
        ""linkCentrePhone"": null
      },
      {
        ""parentCentreId"": 6,
        ""parentCentreName"": ""The Lister Fertility Clinic"",
        ""linkCentreId"": 9162,
        ""linkCentreName"": ""Assisted Reproduction Unit, Jersey General Hospital"",
        ""linkType"": 1520,
        ""linkTypeDescription"": ""Satellite"",
        ""linkCentreAddress"": null,
        ""linkCentrePhone"": ""07797716160""
      }
    ]
  },
  {
    ""id"": 10603,
    ""centreName"": ""HFEA Test Centre"",
    ""centreType"": 881,
    ""centreTypeDescription"": ""Treatment with Storage and Research"",
    ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/10603Profile"",
    ""inspectionRating"": 0,
    ""inspectionRatingLicensedUntil"": ""2017-09-30T00:00:00"",
    ""patientRating"": 4,
    ""patientRatingNumberOfRatings"": 68,
    ""ivfBirthRateAllAges"": null,
    ""diBirthRateAllAges"": null,
    ""iuiBirthRateAllAges"": null,
    ""multipleBirthRateAllAges"": null,
    ""eligibilityAndFunding"": [],
    ""treatmentsOffered"": [],
    ""donorServices"": [],
    ""spermDonorWaitingTimes"": {
      ""White"": ""No data available"",
      ""Mixed"": ""No data available"",
      ""Asian"": ""No data available"",
      ""Black"": ""No data available"",
      ""Other ethnic groups"": ""No data available""
    },
    ""eggDonorWaitingTimes"": {
      ""White"": ""No data available"",
      ""Mixed"": ""No data available"",
      ""Asian"": ""No data available"",
      ""Black"": ""No data available"",
      ""Other ethnic groups"": ""No data available""
    },
    ""embryoDonorWaitingTimes"": {
      ""White"": ""No data available"",
      ""Mixed"": ""No data available"",
      ""Asian"": ""No data available"",
      ""Black"": ""No data available"",
      ""Other ethnic groups"": ""No data available""
    },
    ""counsellingAndSupport"": [],
    ""staff"": [],
    ""facilities"": [],
    ""openingTimes"": [
      {
        ""isOpened"": false,
        ""day"": 0,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": true,
        ""day"": 1,
        ""openTime"": ""15:30"",
        ""closeTime"": ""20:00""
      },
      {
        ""isOpened"": true,
        ""day"": 2,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 3,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 4,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 5,
        ""openTime"": null,
        ""closeTime"": null
      },
      {
        ""isOpened"": false,
        ""day"": 6,
        ""openTime"": null,
        ""closeTime"": null
      }
    ],
    ""otherLookupItems"": [],
    ""mainAddress"": null,
    ""links"": []
  }
]
        ";
    }
}
