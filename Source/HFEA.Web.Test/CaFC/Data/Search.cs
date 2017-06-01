using HFEA.Connector.Contracts.CaFC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.CaFC.Data
{
    public class Search
    {        
        public static SearchResults DistanceSearch
        {
            get
            {
                return JsonConvert.DeserializeObject<SearchResults>(distanceSearch);
            }
        }

        public static SearchResults FullSearch
        {
            get
            {
                return JsonConvert.DeserializeObject<SearchResults>(fullSearch);
            }
        }

        private const string fullSearch = @"
{
  ""submittedSearchParameters"": {
    ""source"": ""London"",
    ""radius"": ""150"",
    ""options"": ""1829,1830,1834"",
    ""pageSize"": ""5"",
    ""pageNumber"": ""3"",
    ""sort"": ""1"",
    ""numberOfResults"": ""17"",
    ""showingResultsFor"": ""London, UK""
  },
  ""centreSearchResultItems"": [
    {
      ""id"": 301,
      ""centreName"": ""London Women's Clinic, Wales"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 130.936,
      ""indicativeSuccessRate"": ""41.8%"",
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": ""34.2%"",
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.48392105102539,
        ""lng"": -3.173787832260132
      },
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
          ""id"": 1808,
          ""name"": ""Surgical sperm collection""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2001,
          ""name"": ""Named nurse system""
        },
        {
          ""id"": 2009,
          ""name"": ""Female doctor available""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""London Women's Clinic, Wales"",
        ""type"": ""Treatment with Storage""
      }
    },
    {
      ""id"": 321,
      ""centreName"": ""NewLife Fertility Centre"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 13.444,
      ""indicativeSuccessRate"": ""28.3%"",
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": ""34.2%"",
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.33218002319336,
        ""lng"": -0.2640807032585144
      },
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
          ""id"": 1808,
          ""name"": ""Surgical sperm collection""
        },
        {
          ""id"": 1809,
          ""name"": ""Ovarian tissue collection""
        },
        {
          ""id"": 1813,
          ""name"": ""IVM""
        },
        {
          ""id"": 2046,
          ""name"": ""IVF for patients with communicable viral infections""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2001,
          ""name"": ""Named nurse system""
        },
        {
          ""id"": 2011,
          ""name"": ""One physician throughout treatment""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""NewLife Fertility Centre"",
        ""type"": ""Treatment with Storage""
      }
    },
    {
      ""id"": 35,
      ""centreName"": ""Oxford Fertility"",
      ""centreType"": 881,
      ""centreTypeDescription"": ""Treatment with Storage and Research"",
      ""distanceFromSource"": 48.752,
      ""indicativeSuccessRate"": ""36.8%"",
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": ""34.2%"",
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.73358917236328,
        ""lng"": -1.2050795555114746
      },
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
          ""id"": 1813,
          ""name"": ""IVM""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        },
        {
          ""id"": 2028,
          ""name"": ""Treats NHS patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2001,
          ""name"": ""Named nurse system""
        },
        {
          ""id"": 2009,
          ""name"": ""Female doctor available""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""Oxford Fertility"",
        ""type"": ""Treatment with Storage and Research""
      }
    },
    {
      ""id"": 206,
      ""centreName"": ""Reproductive Genetics Institute"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 1.245,
      ""indicativeSuccessRate"": ""25.0%"",
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": ""34.2%"",
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.52083206176758,
        ""lng"": -0.14700770378112793
      },
      ""treatmentsOffered"": [
        {
          ""id"": 1829,
          ""name"": ""IVF""
        },
        {
          ""id"": 1830,
          ""name"": ""ICSI""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2001,
          ""name"": ""Named nurse system""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""Reproductive Genetics Institute"",
        ""type"": ""Treatment with Storage""
      }
    },
    {
      ""id"": 44,
      ""centreName"": ""The Centre for Reproductive and Genetic Health"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 1.279,
      ""indicativeSuccessRate"": ""52.4%"",
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": ""34.2%"",
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.52297592163086,
        ""lng"": -0.14374940097332
      },
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
          ""id"": 1808,
          ""name"": ""Surgical sperm collection""
        },
        {
          ""id"": 1813,
          ""name"": ""IVM""
        },
        {
          ""id"": 2046,
          ""name"": ""IVF for patients with communicable viral infections""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        },
        {
          ""id"": 2028,
          ""name"": ""Treats NHS patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2001,
          ""name"": ""Named nurse system""
        },
        {
          ""id"": 2009,
          ""name"": ""Female doctor available""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""The Centre for Reproductive and Genetic Health"",
        ""type"": ""Treatment with Storage""
      }
    }
  ],
  ""centreSearchResultMapItems"": [
    {
      ""centreId"": 6,
      ""centreName"": ""The Lister Fertility Clinic"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.4865188598634,
      ""lng"": -0.150501996278764,
      ""links"": []
    },
    {
      ""centreId"": 16,
      ""centreName"": ""CARE Northampton"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 52.23637771606445,
      ""lng"": -0.8773338794708252,
      ""links"": []
    },
    {
      ""centreId"": 35,
      ""centreName"": ""Oxford Fertility"",
      ""centreType"": ""Treatment with Storage and Research"",
      ""lat"": 51.73358917236328,
      ""lng"": -1.2050795555114746,
      ""links"": []
    },
    {
      ""centreId"": 44,
      ""centreName"": ""The Centre for Reproductive and Genetic Health"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52297592163086,
      ""lng"": -0.14374940097332,
      ""links"": []
    },
    {
      ""centreId"": 78,
      ""centreName"": ""IVF Hammersmith"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.51652145385742,
      ""lng"": -0.23665839433670044,
      ""links"": []
    },
    {
      ""centreId"": 101,
      ""centreName"": ""CARE Nottingham"",
      ""centreType"": ""Treatment with Storage and Research"",
      ""lat"": 52.9811897277832,
      ""lng"": -1.2394098043441772,
      ""links"": []
    },
    {
      ""centreId"": 102,
      ""centreName"": ""Guys Hospital"",
      ""centreType"": ""Treatment with Storage and Research"",
      ""lat"": 51.504642486572266,
      ""lng"": -0.08898969739675522,
      ""links"": []
    },
    {
      ""centreId"": 105,
      ""centreName"": ""London Women's Clinic"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52143096923828,
      ""lng"": -0.14838160574436188,
      ""links"": []
    },
    {
      ""centreId"": 119,
      ""centreName"": ""Birmingham Women's Hospital"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 52.45318603515625,
      ""lng"": -1.942243218421936,
      ""links"": []
    },
    {
      ""centreId"": 157,
      ""centreName"": ""Assisted Reproduction and Gynaecology Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52131271362305,
      ""lng"": -0.14942429959774017,
      ""links"": []
    },
    {
      ""centreId"": 199,
      ""centreName"": ""CRM CARE London"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52757263183594,
      ""lng"": -0.16549000144004822,
      ""links"": []
    },
    {
      ""centreId"": 206,
      ""centreName"": ""Reproductive Genetics Institute"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52083206176758,
      ""lng"": -0.14700770378112793,
      ""links"": []
    },
    {
      ""centreId"": 301,
      ""centreName"": ""London Women's Clinic, Wales"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.48392105102539,
      ""lng"": -3.173787832260132,
      ""links"": []
    },
    {
      ""centreId"": 321,
      ""centreName"": ""NewLife Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.33218002319336,
      ""lng"": -0.2640807032585144,
      ""links"": []
    },
    {
      ""centreId"": 9097,
      ""centreName"": ""Boston Place"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.523441314697266,
      ""lng"": -0.1625566929578781,
      ""links"": []
    },
    {
      ""centreId"": 9113,
      ""centreName"": ""Harley Street Fertility Clinic"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52250671386719,
      ""lng"": -0.14830909669399261,
      ""links"": []
    },
    {
      ""centreId"": 9141,
      ""centreName"": ""The Fertility & Gynaecology Academy"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.51915740966797,
      ""lng"": -0.14896400272846222,
      ""links"": []
    }
  ]
}
";

        private const string distanceSearch = @"
{
  ""submittedSearchParameters"": {
    ""source"": ""London"",
    ""radius"": ""100"",
    ""options"": """",
    ""pageSize"": ""10"",
    ""pageNumber"": ""1"",
    ""sort"": ""0"",
    ""numberOfResults"": ""63"",
    ""showingResultsFor"": ""London, UK""
  },
  ""centreSearchResultItems"": [
    {
      ""id"": 9154,
      ""centreName"": ""Spire Healthcare Limited"",
      ""centreType"": 0,
      ""centreTypeDescription"": null,
      ""distanceFromSource"": 1.031,
      ""indicativeSuccessRate"": null,
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": null,
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 0,
      ""numberOfUserReviews"": 0,
      ""coordinates"": {
        ""lat"": 51.51310348510742,
        ""lng"": -0.10561300069093704
      },
      ""treatmentsOffered"": [
        {
          ""id"": 1829,
          ""name"": ""IVF""
        },
        {
          ""id"": 1830,
          ""name"": ""ICSI""
        }
      ],
      ""eligibilityAndFunding"": [],
      ""staffing"": [],
      ""links"": [
        {
          ""centreLinkId"": 0,
          ""parentCentreId"": 102,
          ""parentCentreName"": ""Guys Hospital"",
          ""linkCentreId"": 0,
          ""linkType"": 1520,
          ""linkTypeDescription"": ""Satellite""
        }
      ],
      ""mapToolTip"": {
        ""name"": ""Spire Healthcare Limited"",
        ""type"": null
      }
    },
    {
      ""id"": 9157,
      ""centreName"": ""Reproductive Health Group 9 Harley Street"",
      ""centreType"": 0,
      ""centreTypeDescription"": null,
      ""distanceFromSource"": 1.044,
      ""indicativeSuccessRate"": null,
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": null,
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 0,
      ""numberOfUserReviews"": 0,
      ""coordinates"": {
        ""lat"": 51.5169677734375,
        ""lng"": -0.1465016007423401
      },
      ""treatmentsOffered"": [
        {
          ""id"": 1829,
          ""name"": ""IVF""
        },
        {
          ""id"": 1830,
          ""name"": ""ICSI""
        }
      ],
      ""eligibilityAndFunding"": [],
      ""staffing"": [],
      ""links"": [
        {
          ""centreLinkId"": 0,
          ""parentCentreId"": 9127,
          ""parentCentreName"": ""Reproductive Health Group"",
          ""linkCentreId"": 0,
          ""linkType"": 1520,
          ""linkTypeDescription"": ""Satellite""
        }
      ],
      ""mapToolTip"": {
        ""name"": ""Reproductive Health Group 9 Harley Street"",
        ""type"": null
      }
    },
    {
      ""id"": 293,
      ""centreName"": ""Andrology Solutions"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 1.123,
      ""indicativeSuccessRate"": null,
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": null,
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.51746368408203,
        ""lng"": -0.14822550117969513
      },
      ""treatmentsOffered"": [],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2009,
          ""name"": ""Female doctor available""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""Andrology Solutions"",
        ""type"": ""Treatment with Storage""
      }
    },
    {
      ""id"": 9141,
      ""centreName"": ""The Fertility & Gynaecology Academy"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 1.223,
      ""indicativeSuccessRate"": null,
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": null,
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.51915740966797,
        ""lng"": -0.14896400272846222
      },
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
          ""id"": 1808,
          ""name"": ""Surgical sperm collection""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2011,
          ""name"": ""One physician throughout treatment""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""The Fertility & Gynaecology Academy"",
        ""type"": ""Treatment with Storage""
      }
    },
    {
      ""id"": 88,
      ""centreName"": ""London Fertility Centre"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 1.241,
      ""indicativeSuccessRate"": ""23.7%"",
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": ""34.2%"",
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.52131271362305,
        ""lng"": -0.14595040678977966
      },
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
          ""id"": 1808,
          ""name"": ""Surgical sperm collection""
        },
        {
          ""id"": 2046,
          ""name"": ""IVF for patients with communicable viral infections""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        },
        {
          ""id"": 2028,
          ""name"": ""Treats NHS patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2001,
          ""name"": ""Named nurse system""
        },
        {
          ""id"": 2009,
          ""name"": ""Female doctor available""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""London Fertility Centre"",
        ""type"": ""Treatment with Storage""
      }
    },
    {
      ""id"": 206,
      ""centreName"": ""Reproductive Genetics Institute"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 1.245,
      ""indicativeSuccessRate"": ""25.0%"",
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": ""34.2%"",
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.52083206176758,
        ""lng"": -0.14700770378112793
      },
      ""treatmentsOffered"": [
        {
          ""id"": 1829,
          ""name"": ""IVF""
        },
        {
          ""id"": 1830,
          ""name"": ""ICSI""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2001,
          ""name"": ""Named nurse system""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""Reproductive Genetics Institute"",
        ""type"": ""Treatment with Storage""
      }
    },
    {
      ""id"": 167,
      ""centreName"": ""Reproductive Medicine Unit"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 1.273,
      ""indicativeSuccessRate"": null,
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": null,
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.524864196777344,
        ""lng"": -0.13701249659061432
      },
      ""treatmentsOffered"": [
        {
          ""id"": 1808,
          ""name"": ""Surgical sperm collection""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2028,
          ""name"": ""Treats NHS patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2009,
          ""name"": ""Female doctor available""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""Reproductive Medicine Unit"",
        ""type"": ""Treatment with Storage""
      }
    },
    {
      ""id"": 44,
      ""centreName"": ""The Centre for Reproductive and Genetic Health"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 1.279,
      ""indicativeSuccessRate"": ""52.4%"",
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": ""34.2%"",
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.52297592163086,
        ""lng"": -0.14374940097332
      },
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
          ""id"": 1808,
          ""name"": ""Surgical sperm collection""
        },
        {
          ""id"": 1813,
          ""name"": ""IVM""
        },
        {
          ""id"": 2046,
          ""name"": ""IVF for patients with communicable viral infections""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        },
        {
          ""id"": 2028,
          ""name"": ""Treats NHS patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2001,
          ""name"": ""Named nurse system""
        },
        {
          ""id"": 2009,
          ""name"": ""Female doctor available""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""The Centre for Reproductive and Genetic Health"",
        ""type"": ""Treatment with Storage""
      }
    },
    {
      ""id"": 11,
      ""centreName"": ""London Sperm Bank"",
      ""centreType"": 833,
      ""centreTypeDescription"": ""Storage only"",
      ""distanceFromSource"": 1.31,
      ""indicativeSuccessRate"": null,
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": null,
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.521583557128906,
        ""lng"": -0.14792850613594055
      },
      ""treatmentsOffered"": [
        {
          ""id"": 1817,
          ""name"": ""IUI""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        },
        {
          ""id"": 2028,
          ""name"": ""Treats NHS patients""
        }
      ],
      ""staffing"": [],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""London Sperm Bank"",
        ""type"": ""Storage only""
      }
    },
    {
      ""id"": 105,
      ""centreName"": ""London Women's Clinic"",
      ""centreType"": 878,
      ""centreTypeDescription"": ""Treatment with Storage"",
      ""distanceFromSource"": 1.315,
      ""indicativeSuccessRate"": ""34.9%"",
      ""indicativeSuccessRateCaveat"": ""This is an indicative success rate caveat. The text here can be long so the front end design needs to accommodate this."",
      ""profileCaveat"": null,
      ""nationalAverage"": ""34.2%"",
      ""profileImageUrl"": ""https://someblob.blob.core.windows.net/images/0Profile"",
      ""inspectionRating"": 0,
      ""inspectionRatingProfile"": null,
      ""userRating"": 3.5,
      ""numberOfUserReviews"": 20,
      ""coordinates"": {
        ""lat"": 51.52143096923828,
        ""lng"": -0.14838160574436188
      },
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
          ""id"": 1808,
          ""name"": ""Surgical sperm collection""
        },
        {
          ""id"": 1813,
          ""name"": ""IVM""
        },
        {
          ""id"": 2046,
          ""name"": ""IVF for patients with communicable viral infections""
        }
      ],
      ""eligibilityAndFunding"": [
        {
          ""id"": 2029,
          ""name"": ""Treats private patients""
        },
        {
          ""id"": 2028,
          ""name"": ""Treats NHS patients""
        }
      ],
      ""staffing"": [
        {
          ""id"": 2009,
          ""name"": ""Female doctor available""
        }
      ],
      ""links"": [],
      ""mapToolTip"": {
        ""name"": ""London Women's Clinic"",
        ""type"": ""Treatment with Storage""
      }
    }
  ],
  ""centreSearchResultMapItems"": [
    {
      ""centreId"": 6,
      ""centreName"": ""The Lister Fertility Clinic"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.4865188598634,
      ""lng"": -0.150501996278764,
      ""links"": []
    },
    {
      ""centreId"": 11,
      ""centreName"": ""London Sperm Bank"",
      ""centreType"": ""Storage only"",
      ""lat"": 51.521583557128906,
      ""lng"": -0.14792850613594055,
      ""links"": []
    },
    {
      ""centreId"": 13,
      ""centreName"": ""Centre for Reproductive Medicine, Coventry"",
      ""centreType"": ""Treatment with Storage and Research"",
      ""lat"": 52.421424865722656,
      ""lng"": -1.4435030221939087,
      ""links"": []
    },
    {
      ""centreId"": 15,
      ""centreName"": ""Sussex Downs Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 50.76611328125,
      ""lng"": 0.28703048825263977,
      ""links"": []
    },
    {
      ""centreId"": 16,
      ""centreName"": ""CARE Northampton"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 52.23637771606445,
      ""lng"": -0.8773338794708252,
      ""links"": []
    },
    {
      ""centreId"": 30,
      ""centreName"": ""Herts and Essex Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.70335388183594,
      ""lng"": -0.0478040985763073,
      ""links"": []
    },
    {
      ""centreId"": 35,
      ""centreName"": ""Oxford Fertility"",
      ""centreType"": ""Treatment with Storage and Research"",
      ""lat"": 51.73358917236328,
      ""lng"": -1.2050795555114746,
      ""links"": []
    },
    {
      ""centreId"": 44,
      ""centreName"": ""The Centre for Reproductive and Genetic Health"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52297592163086,
      ""lng"": -0.14374940097332,
      ""links"": []
    },
    {
      ""centreId"": 51,
      ""centreName"": ""Cambridge IVF"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 52.17329788208008,
      ""lng"": 0.11088129878044128,
      ""links"": []
    },
    {
      ""centreId"": 57,
      ""centreName"": ""Wessex Fertility Limited"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 50.92627716064453,
      ""lng"": -1.4336774349212646,
      ""links"": []
    },
    {
      ""centreId"": 68,
      ""centreName"": ""Leicester Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 52.62781524658203,
      ""lng"": -1.1348028182983398,
      ""links"": []
    },
    {
      ""centreId"": 70,
      ""centreName"": ""The Bridge Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.504920959472656,
      ""lng"": -0.08794049918651581,
      ""links"": []
    },
    {
      ""centreId"": 78,
      ""centreName"": ""IVF Hammersmith"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.51652145385742,
      ""lng"": -0.23665839433670044,
      ""links"": []
    },
    {
      ""centreId"": 80,
      ""centreName"": ""Andrology Unit, Hammersmith Hospital"",
      ""centreType"": ""Storage only"",
      ""lat"": 51.51652145385742,
      ""lng"": -0.23665839433670044,
      ""links"": []
    },
    {
      ""centreId"": 86,
      ""centreName"": ""BMI Chelsfield Park ACU"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.3583984375,
      ""lng"": 0.1308145970106125,
      ""links"": []
    },
    {
      ""centreId"": 88,
      ""centreName"": ""London Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52131271362305,
      ""lng"": -0.14595040678977966,
      ""links"": []
    },
    {
      ""centreId"": 94,
      ""centreName"": ""Barts Health Centre for Reproductive Medicine"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.5169677734375,
      ""lng"": -0.10088369995355606,
      ""links"": []
    },
    {
      ""centreId"": 100,
      ""centreName"": ""Bourn Hall Clinic"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 52.190284729003906,
      ""lng"": -0.06224089860916138,
      ""links"": []
    },
    {
      ""centreId"": 102,
      ""centreName"": ""Guys Hospital"",
      ""centreType"": ""Treatment with Storage and Research"",
      ""lat"": 51.504642486572266,
      ""lng"": -0.08898969739675522,
      ""links"": []
    },
    {
      ""centreId"": 105,
      ""centreName"": ""London Women's Clinic"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52143096923828,
      ""lng"": -0.14838160574436188,
      ""links"": []
    },
    {
      ""centreId"": 109,
      ""centreName"": ""King’s Hewitt Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.46835708618164,
      ""lng"": -0.09230589866638184,
      ""links"": []
    },
    {
      ""centreId"": 139,
      ""centreName"": ""Bath Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.312232971191406,
      ""lng"": -2.414358139038086,
      ""links"": []
    },
    {
      ""centreId"": 144,
      ""centreName"": ""Nuffield Health Woking Hospital"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.332237243652344,
      ""lng"": -0.5614367127418518,
      ""links"": []
    },
    {
      ""centreId"": 151,
      ""centreName"": ""Gloucestershire Hospitals NHS Trust"",
      ""centreType"": ""Storage only"",
      ""lat"": 51.866390228271484,
      ""lng"": -2.231041669845581,
      ""links"": []
    },
    {
      ""centreId"": 153,
      ""centreName"": ""Homerton Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.55063247680664,
      ""lng"": -0.046098701655864716,
      ""links"": []
    },
    {
      ""centreId"": 157,
      ""centreName"": ""Assisted Reproduction and Gynaecology Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52131271362305,
      ""lng"": -0.14942429959774017,
      ""links"": []
    },
    {
      ""centreId"": 158,
      ""centreName"": ""Chelsea & Westminster Hospital"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.48426055908203,
      ""lng"": -0.18145869672298431,
      ""links"": []
    },
    {
      ""centreId"": 159,
      ""centreName"": ""Royal Surrey County Hospital"",
      ""centreType"": ""Storage only"",
      ""lat"": 51.241024017333984,
      ""lng"": -0.6074622869491577,
      ""links"": []
    },
    {
      ""centreId"": 161,
      ""centreName"": ""BMI The Chaucer Hospital"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.26170349121094,
      ""lng"": 1.0874725580215454,
      ""links"": []
    },
    {
      ""centreId"": 163,
      ""centreName"": ""Shirley Oaks Hospital"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.382301330566406,
      ""lng"": -0.056352101266384125,
      ""links"": []
    },
    {
      ""centreId"": 165,
      ""centreName"": ""Brentwood Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.62356948852539,
      ""lng"": 0.312688410282135,
      ""links"": []
    },
    {
      ""centreId"": 167,
      ""centreName"": ""Reproductive Medicine Unit"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.524864196777344,
      ""lng"": -0.13701249659061432,
      ""links"": []
    },
    {
      ""centreId"": 188,
      ""centreName"": ""Bourn Hall Clinic (Colchester)"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.92168045043945,
      ""lng"": 0.9283751845359802,
      ""links"": []
    },
    {
      ""centreId"": 197,
      ""centreName"": ""Salisbury Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.0439567565918,
      ""lng"": -1.7898224592208862,
      ""links"": []
    },
    {
      ""centreId"": 199,
      ""centreName"": ""CRM CARE London"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52757263183594,
      ""lng"": -0.16549000144004822,
      ""links"": []
    },
    {
      ""centreId"": 206,
      ""centreName"": ""Reproductive Genetics Institute"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52083206176758,
      ""lng"": -0.14700770378112793,
      ""links"": []
    },
    {
      ""centreId"": 208,
      ""centreName"": ""CARE Tunbridge Wells"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.14106369018555,
      ""lng"": 0.26171019673347473,
      ""links"": []
    },
    {
      ""centreId"": 254,
      ""centreName"": ""The Agora Gynaecology and Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 50.83466339111328,
      ""lng"": -0.1738618016242981,
      ""links"": []
    },
    {
      ""centreId"": 258,
      ""centreName"": ""The Whittington Hospital Fertility Unit"",
      ""centreType"": ""Treatment only"",
      ""lat"": 51.566680908203125,
      ""lng"": -0.13817499577999115,
      ""links"": []
    },
    {
      ""centreId"": 259,
      ""centreName"": ""Epsom And St Helier NHS Trust"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.38007354736328,
      ""lng"": -0.18319140374660492,
      ""links"": []
    },
    {
      ""centreId"": 270,
      ""centreName"": ""Kingston Hospital ACU"",
      ""centreType"": ""Treatment only"",
      ""lat"": 51.414283752441406,
      ""lng"": -0.28308990597724915,
      ""links"": []
    },
    {
      ""centreId"": 289,
      ""centreName"": ""North Middlesex University Hospital (Reproductive Medicines Unit)"",
      ""centreType"": ""Treatment only"",
      ""lat"": 51.613121032714844,
      ""lng"": -0.07434059679508209,
      ""links"": []
    },
    {
      ""centreId"": 291,
      ""centreName"": ""Fertility Unit Barking, Havering and Redbridge Hospitals Trust"",
      ""centreType"": ""Treatment only"",
      ""lat"": 51.56862258911133,
      ""lng"": 0.17891399562358856,
      ""links"": []
    },
    {
      ""centreId"": 293,
      ""centreName"": ""Andrology Solutions"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.51746368408203,
      ""lng"": -0.14822550117969513,
      ""links"": []
    },
    {
      ""centreId"": 299,
      ""centreName"": ""CREATE Centre for Reproduction and Advanced Technology"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.410316467285156,
      ""lng"": -0.22803589701652527,
      ""links"": []
    },
    {
      ""centreId"": 307,
      ""centreName"": ""Complete Fertility Centre Southampton"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 50.93525695800781,
      ""lng"": -1.4348634481430054,
      ""links"": []
    },
    {
      ""centreId"": 321,
      ""centreName"": ""NewLife Fertility Centre"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.33218002319336,
      ""lng"": -0.2640807032585144,
      ""links"": []
    },
    {
      ""centreId"": 9024,
      ""centreName"": ""Brighton Fertility Associates"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 50.82001876831055,
      ""lng"": -0.1344532072544098,
      ""links"": []
    },
    {
      ""centreId"": 9094,
      ""centreName"": ""City Fertility"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52020263671875,
      ""lng"": -0.10149849951267242,
      ""links"": []
    },
    {
      ""centreId"": 9095,
      ""centreName"": ""Bourn Hall (Norwich) Limited"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 52.57828903198242,
      ""lng"": 1.1415414810180664,
      ""links"": []
    },
    {
      ""centreId"": 9097,
      ""centreName"": ""Boston Place"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.523441314697266,
      ""lng"": -0.1625566929578781,
      ""links"": []
    },
    {
      ""centreId"": 9112,
      ""centreName"": ""Oxford Heart Valve Bank"",
      ""centreType"": ""Storage only"",
      ""lat"": 51.76387023925781,
      ""lng"": -1.2198063135147095,
      ""links"": []
    },
    {
      ""centreId"": 9113,
      ""centreName"": ""Harley Street Fertility Clinic"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.52250671386719,
      ""lng"": -0.14830909669399261,
      ""links"": []
    },
    {
      ""centreId"": 9121,
      ""centreName"": ""Simply Fertility"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.70933532714844,
      ""lng"": 0.5026373863220215,
      ""links"": []
    },
    {
      ""centreId"": 9124,
      ""centreName"": ""Fertility in Community"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.363311767578125,
      ""lng"": -0.09665980190038681,
      ""links"": []
    },
    {
      ""centreId"": 9129,
      ""centreName"": ""CREATE, St Paul's London"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.51511001586914,
      ""lng"": -0.09675239771604538,
      ""links"": []
    },
    {
      ""centreId"": 9141,
      ""centreName"": ""The Fertility & Gynaecology Academy"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.51915740966797,
      ""lng"": -0.14896400272846222,
      ""links"": []
    },
    {
      ""centreId"": 9147,
      ""centreName"": ""Concept Fertility"",
      ""centreType"": ""Treatment with Storage"",
      ""lat"": 51.460872650146484,
      ""lng"": -0.1990153044462204,
      ""links"": []
    },
    {
      ""centreId"": 9153,
      ""centreName"": ""Poundbury Fertility"",
      ""centreType"": null,
      ""lat"": 51.52077865600586,
      ""lng"": -0.15032519400119781,
      ""links"": [
        {
          ""centreLinkId"": 0,
          ""parentCentreId"": 6,
          ""parentCentreName"": ""The Lister Fertility Clinic"",
          ""linkCentreId"": 0,
          ""linkType"": 1520,
          ""linkTypeDescription"": ""Satellite""
        }
      ]
    },
    {
      ""centreId"": 9154,
      ""centreName"": ""Spire Healthcare Limited"",
      ""centreType"": null,
      ""lat"": 51.51310348510742,
      ""lng"": -0.10561300069093704,
      ""links"": [
        {
          ""centreLinkId"": 0,
          ""parentCentreId"": 102,
          ""parentCentreName"": ""Guys Hospital"",
          ""linkCentreId"": 0,
          ""linkType"": 1520,
          ""linkTypeDescription"": ""Satellite""
        }
      ]
    },
    {
      ""centreId"": 9157,
      ""centreName"": ""Reproductive Health Group 9 Harley Street"",
      ""centreType"": null,
      ""lat"": 51.5169677734375,
      ""lng"": -0.1465016007423401,
      ""links"": [
        {
          ""centreLinkId"": 0,
          ""parentCentreId"": 9127,
          ""parentCentreName"": ""Reproductive Health Group"",
          ""linkCentreId"": 0,
          ""linkType"": 1520,
          ""linkTypeDescription"": ""Satellite""
        }
      ]
    },
    {
      ""centreId"": 9158,
      ""centreName"": ""Bourn Hall Clinic at Peterborough"",
      ""centreType"": null,
      ""lat"": 52.584190368652344,
      ""lng"": -0.24129240214824677,
      ""links"": [
        {
          ""centreLinkId"": 0,
          ""parentCentreId"": 100,
          ""parentCentreName"": ""Bourn Hall Clinic"",
          ""linkCentreId"": 0,
          ""linkType"": 1520,
          ""linkTypeDescription"": ""Satellite""
        }
      ]
    },
    {
      ""centreId"": 9166,
      ""centreName"": ""Bourn Hall Clinic at King’s Lynn"",
      ""centreType"": null,
      ""lat"": 52.77124786376953,
      ""lng"": 0.41377079486846924,
      ""links"": [
        {
          ""centreLinkId"": 0,
          ""parentCentreId"": 100,
          ""parentCentreName"": ""Bourn Hall Clinic"",
          ""linkCentreId"": 0,
          ""linkType"": 1520,
          ""linkTypeDescription"": ""Satellite""
        },
        {
          ""centreLinkId"": 0,
          ""parentCentreId"": 9095,
          ""parentCentreName"": ""Bourn Hall (Norwich) Limited"",
          ""linkCentreId"": 0,
          ""linkType"": 1520,
          ""linkTypeDescription"": ""Satellite""
        }
      ]
    }
  ]
}

";
        
    }
}
