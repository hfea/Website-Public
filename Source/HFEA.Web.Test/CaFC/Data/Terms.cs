using HFEA.Connector.Contracts.CaFC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.CaFC.Data
{
    public class Terms
    {
        public static string JSON
        {
            get
            {
                return terms;
            }
        }
        
        public static SearchFilters ResultObject
        {
            get
            {
                return JsonConvert.DeserializeObject<SearchFilters>(JSON);
            }
        }


        private const string terms = @"
{
  ""collectionNames"": [
    {
      ""Key"": ""Treatments"",
      ""Value"": ""Treatments""
    },
    {
      ""Key"": ""EligibilityAndFunding"",
      ""Value"": ""Eligibility and Funding""
    },
    {
      ""Key"": ""DonorRecruitment"",
      ""Value"": ""Donor recruitment""
    },
    {
      ""Key"": ""ScreeningServices"",
      ""Value"": ""Screening services""
    },
    {
      ""Key"": ""CounsellingAndSupport"",
      ""Value"": ""Counselling and support""
    }
  ],
  ""treatments"": [
    {
      ""Id"": 1829,
      ""Name"": ""IVF"",
      ""Description"": ""IVF (In Vitro Fertilisation) - Patient's eggs and her partner's or donor's sperm are collected and mixed together in a laboratory to achieve fertilisation outside the body. The embryos produced may then be transferred into the female patient.""
    },
    {
      ""Id"": 1830,
      ""Name"": ""ICSI"",
      ""Description"": ""ICSI (Intra Cytoplasmic Sperm Injection) - ICSI involves injecting a single sperm directly into an egg in order to fertilise it. The fertilised egg (embryo) is then transferred to the woman's womb.""
    },
    {
      ""Id"": 1817,
      ""Name"": ""IUI"",
      ""Description"": ""IUI (Intra Uterine Insemination) - Sperm from a woman’s partner is inserted into her  uterus at her most fertile time. DI (Donor Insemination) - Sperm from a donor is inserted into a woman’s cervix or uterus at her most fertile time.""
    },
    {
      ""Id"": 1808,
      ""Name"": ""Surgical sperm collection"",
      ""Description"": ""The surgical retrieval of sperm from the testes for use in fertility treatment.""
    },
    {
      ""Id"": 1809,
      ""Name"": ""Ovarian tissue collection"",
      ""Description"": ""The collection of ovarian tissue from a woman.""
    },
    {
      ""Id"": 3298,
      ""Name"": ""Fertility preservation"",
      ""Description"": ""Text for fertility preservation.""
    },
    {
      ""Id"": 1813,
      ""Name"": ""IVM"",
      ""Description"": ""If eggs are removed from the ovaries when they are still immature, they can then be matured in the laboratory before being fertilised.""
    },
    {
      ""Id"": 2046,
      ""Name"": ""IVF for patients with communicable viral infections"",
      ""Description"": ""Text for IVF for patients with communicable viral infections.""
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
  ""donorRecruitment"": [
    {
      ""id"": 2064,
      ""name"": ""Recruits egg donors""
    },
    {
      ""id"": 2068,
      ""name"": ""Recruits sperm donors""
    },
    {
      ""id"": 2067,
      ""name"": ""Recruits donors for research projects""
    }
  ],
  ""screeningServices"": [
    {
      ""Id"": 1834,
      ""Name"": ""PGD"",
      ""Description"": ""PGD (Pre-implantation genetic diagnosis) - PGD is a technique that enables people at risk of passing on to their children a specific inherited condition, to screen embryos created through IVF for this condition.""
    },
    {
      ""Id"": 1835,
      ""Name"": ""PGS"",
      ""Description"": ""PGS (also known as aneuploidy screening) involves checking the chromosomes of embryos conceived by in vitro fertilisation (IVF) or intra-cytoplasmic sperm injection (ICSI) for common abnormalities. This avoids having abnormal embryos transferred to the womb during IVF or ICSI.""
    }
  ],
  ""counsellingAndSupport"": [
    {
      ""id"": 2033,
      ""name"": ""Counselling services at clinic""
    },
    {
      ""id"": 2035,
      ""name"": ""Dedicated counsellor""
    },
    {
      ""id"": 2032,
      ""name"": ""Compulsory counselling for donors""
    }
  ],
  ""sortableTerms"": [
    {
      ""id"": 0,
      ""name"": ""Distance""
    },
    {
      ""id"": 1,
      ""name"": ""Centre name ascending""
    },
    {
      ""id"": 2,
      ""name"": ""Centre name descending""
    },
    {
      ""id"": 3,
      ""name"": ""User rating ascending""
    },
    {
      ""id"": 6,
      ""name"": ""Success rate descending""
    },
    {
      ""id"": 7,
      ""name"": ""Inspection rating ascending""
    },
    {
      ""id"": 8,
      ""name"": ""Inspection rating descending""
    },
    {
      ""id"": 4,
      ""name"": ""User rating descending""
    },
    {
      ""id"": 5,
      ""name"": ""Success rate ascending""
    }
  ]
}
";


        private const string search = "";

        private const string allClinicJSON = @"
[
  {
    ""id"": 19,
    ""centreName"": ""Aberdeen Fertility Centre""
  },
  {
    ""id"": 293,
    ""centreName"": ""Andrology Solutions""
  },
  {
    ""id"": 80,
    ""centreName"": ""Andrology Unit, Hammersmith Hospital""
  },
  {
    ""id"": 157,
    ""centreName"": ""Assisted Reproduction and Gynaecology Centre""
  },
  {
    ""id"": 31,
    ""centreName"": ""Assisted Reproduction Unit (ARU), University Hospital of Hartlepool""
  },
  {
    ""id"": 287,
    ""centreName"": ""Ayrshire Fertility Unit, Crosshouse Hospital""
  },
  {
    ""id"": 94,
    ""centreName"": ""Barts Health Centre for Reproductive Medicine""
  },
  {
    ""id"": 139,
    ""centreName"": ""Bath Fertility Centre""
  },
  {
    ""id"": 119,
    ""centreName"": ""Birmingham Women's Hospital""
  },
  {
    ""id"": 86,
    ""centreName"": ""BMI Chelsfield Park ACU""
  },
  {
    ""id"": 26,
    ""centreName"": ""BMI Priory Hospital""
  },
  {
    ""id"": 161,
    ""centreName"": ""BMI The Chaucer Hospital""
  },
  {
    ""id"": 9097,
    ""centreName"": ""Boston Place""
  },
  {
    ""id"": 9095,
    ""centreName"": ""Bourn Hall (Norwich) Limited""
  },
  {
    ""id"": 100,
    ""centreName"": ""Bourn Hall Clinic""
  },
  {
    ""id"": 188,
    ""centreName"": ""Bourn Hall Clinic (Colchester)""
  },
  {
    ""id"": 165,
    ""centreName"": ""Brentwood Fertility Centre""
  },
  {
    ""id"": 9024,
    ""centreName"": ""Brighton Fertility Associates""
  },
  {
    ""id"": 295,
    ""centreName"": ""Bristol Centre for Reproductive Medicine""
  },
  {
    ""id"": 184,
    ""centreName"": ""Burton Hospitals NHS Trust""
  },
  {
    ""id"": 51,
    ""centreName"": ""Cambridge IVF""
  },
  {
    ""id"": 185,
    ""centreName"": ""CARE Manchester""
  },
  {
    ""id"": 16,
    ""centreName"": ""CARE Northampton""
  },
  {
    ""id"": 101,
    ""centreName"": ""CARE Nottingham""
  },
  {
    ""id"": 61,
    ""centreName"": ""CARE Sheffield""
  },
  {
    ""id"": 208,
    ""centreName"": ""CARE Tunbridge Wells""
  },
  {
    ""id"": 251,
    ""centreName"": ""Centre for human development, stem cells and regeneration""
  },
  {
    ""id"": 209,
    ""centreName"": ""Centre for Human Reproductive Science""
  },
  {
    ""id"": 316,
    ""centreName"": ""Centre for Reproduction & Gynaecology Wales (CRGW)""
  },
  {
    ""id"": 13,
    ""centreName"": ""Centre for Reproductive Medicine, Coventry""
  },
  {
    ""id"": 312,
    ""centreName"": ""Centre for Stem Cell Biology (Alfred Denny)""
  },
  {
    ""id"": 158,
    ""centreName"": ""Chelsea & Westminster Hospital""
  },
  {
    ""id"": 9094,
    ""centreName"": ""City Fertility""
  },
  {
    ""id"": 307,
    ""centreName"": ""Complete Fertility Centre Southampton""
  },
  {
    ""id"": 9147,
    ""centreName"": ""Concept Fertility""
  },
  {
    ""id"": 282,
    ""centreName"": ""Cornwall Centre for Reproductive Medicine (CCRM)""
  },
  {
    ""id"": 280,
    ""centreName"": ""Countess Of Chester Hospital""
  },
  {
    ""id"": 168,
    ""centreName"": ""County Durham ACU""
  },
  {
    ""id"": 294,
    ""centreName"": ""Craigavon Area Hospital""
  },
  {
    ""id"": 299,
    ""centreName"": ""CREATE Centre for Reproduction and Advanced Technology""
  },
  {
    ""id"": 9129,
    ""centreName"": ""CREATE, St Paul's London""
  },
  {
    ""id"": 199,
    ""centreName"": ""CRM CARE London""
  },
  {
    ""id"": 201,
    ""centreName"": ""Edinburgh Assisted Conception Unit""
  },
  {
    ""id"": 259,
    ""centreName"": ""Epsom And St Helier NHS Trust""
  },
  {
    ""id"": 5,
    ""centreName"": ""Fertility Exeter""
  },
  {
    ""id"": 9124,
    ""centreName"": ""Fertility in Community""
  },
  {
    ""id"": 291,
    ""centreName"": ""Fertility Unit Barking, Havering and Redbridge Hospitals Trust""
  },
  {
    ""id"": 9106,
    ""centreName"": ""GCRM - Belfast""
  },
  {
    ""id"": 250,
    ""centreName"": ""Glasgow Centre for Reproductive Medicine""
  },
  {
    ""id"": 115,
    ""centreName"": ""Glasgow Nuffield Hospital""
  },
  {
    ""id"": 37,
    ""centreName"": ""Glasgow Royal Infirmary""
  },
  {
    ""id"": 151,
    ""centreName"": ""Gloucestershire Hospitals NHS Trust""
  },
  {
    ""id"": 102,
    ""centreName"": ""Guys Hospital""
  },
  {
    ""id"": 9113,
    ""centreName"": ""Harley Street Fertility Clinic""
  },
  {
    ""id"": 320,
    ""centreName"": ""Hartshorne and Genesis Group""
  },
  {
    ""id"": 30,
    ""centreName"": ""Herts and Essex Fertility Centre""
  },
  {
    ""id"": 7,
    ""centreName"": ""Hewitt Fertility Centre""
  },
  {
    ""id"": 9149,
    ""centreName"": ""Hewitt Fertility Centre, Knutsford""
  },
  {
    ""id"": 153,
    ""centreName"": ""Homerton Fertility Centre""
  },
  {
    ""id"": 21,
    ""centreName"": ""Hull IVF Unit""
  },
  {
    ""id"": 245,
    ""centreName"": ""Human Genetics & Embryology Laboratories""
  },
  {
    ""id"": 249,
    ""centreName"": ""Institute of Reproductive and Developmental Biology""
  },
  {
    ""id"": 78,
    ""centreName"": ""IVF Hammersmith""
  },
  {
    ""id"": 196,
    ""centreName"": ""Jessop Fertility""
  },
  {
    ""id"": 109,
    ""centreName"": ""King’s Hewitt Fertility Centre""
  },
  {
    ""id"": 270,
    ""centreName"": ""Kingston Hospital ACU""
  },
  {
    ""id"": 98,
    ""centreName"": ""Lanarkshire Acute Hospital NHS Trust""
  },
  {
    ""id"": 68,
    ""centreName"": ""Leicester Fertility Centre""
  },
  {
    ""id"": 88,
    ""centreName"": ""London Fertility Centre""
  },
  {
    ""id"": 11,
    ""centreName"": ""London Sperm Bank""
  },
  {
    ""id"": 105,
    ""centreName"": ""London Women's Clinic""
  },
  {
    ""id"": 75,
    ""centreName"": ""London Women's Clinic, Darlington""
  },
  {
    ""id"": 301,
    ""centreName"": ""London Women's Clinic, Wales""
  },
  {
    ""id"": 33,
    ""centreName"": ""Manchester Fertility""
  },
  {
    ""id"": 9133,
    ""centreName"": ""Mechanochemical Cell Biology""
  },
  {
    ""id"": 8,
    ""centreName"": ""Midland Fertility Services""
  },
  {
    ""id"": 17,
    ""centreName"": ""Newcastle Fertility Centre at Life""
  },
  {
    ""id"": 321,
    ""centreName"": ""NewLife Fertility Centre""
  },
  {
    ""id"": 4,
    ""centreName"": ""Ninewells Hospital""
  },
  {
    ""id"": 289,
    ""centreName"": ""North Middlesex University Hospital (Reproductive Medicines Unit)""
  },
  {
    ""id"": 144,
    ""centreName"": ""Nuffield Health Woking Hospital""
  },
  {
    ""id"": 76,
    ""centreName"": ""NURTURE Fertility""
  },
  {
    ""id"": 200,
    ""centreName"": ""Origin Fertility Care""
  },
  {
    ""id"": 35,
    ""centreName"": ""Oxford Fertility""
  },
  {
    ""id"": 9112,
    ""centreName"": ""Oxford Heart Valve Bank""
  },
  {
    ""id"": 162,
    ""centreName"": ""Queens Medical Centre Fertility Unit""
  },
  {
    ""id"": 77,
    ""centreName"": ""Regional Fertility Centre, Belfast""
  },
  {
    ""id"": 206,
    ""centreName"": ""Reproductive Genetics Institute""
  },
  {
    ""id"": 9127,
    ""centreName"": ""Reproductive Health Group""
  },
  {
    ""id"": 276,
    ""centreName"": ""Reproductive Medicine Clinic, Bristol""
  },
  {
    ""id"": 167,
    ""centreName"": ""Reproductive Medicine Unit""
  },
  {
    ""id"": 149,
    ""centreName"": ""Royal Derby Hospital""
  },
  {
    ""id"": 159,
    ""centreName"": ""Royal Surrey County Hospital""
  },
  {
    ""id"": 197,
    ""centreName"": ""Salisbury Fertility Centre""
  },
  {
    ""id"": 163,
    ""centreName"": ""Shirley Oaks Hospital""
  },
  {
    ""id"": 148,
    ""centreName"": ""Shropshire and Mid-Wales Fertility Centre""
  },
  {
    ""id"": 9121,
    ""centreName"": ""Simply Fertility""
  },
  {
    ""id"": 179,
    ""centreName"": ""South West Centre for Reproductive Medicine""
  },
  {
    ""id"": 284,
    ""centreName"": ""Spire Bristol Hospital""
  },
  {
    ""id"": 198,
    ""centreName"": ""St Jude's Women's Hospital""
  },
  {
    ""id"": 67,
    ""centreName"": ""St Mary's Hospital""
  },
  {
    ""id"": 96,
    ""centreName"": ""Sunderland Fertility Centre""
  },
  {
    ""id"": 15,
    ""centreName"": ""Sussex Downs Fertility Centre""
  },
  {
    ""id"": 254,
    ""centreName"": ""The Agora Gynaecology and Fertility Centre""
  },
  {
    ""id"": 70,
    ""centreName"": ""The Bridge Centre""
  },
  {
    ""id"": 44,
    ""centreName"": ""The Centre for Reproductive and Genetic Health""
  },
  {
    ""id"": 9141,
    ""centreName"": ""The Fertility & Gynaecology Academy""
  },
  {
    ""id"": 246,
    ""centreName"": ""The Francis Crick Institute at Mill Hill""
  },
  {
    ""id"": 170,
    ""centreName"": ""The Gateshead Fertility Unit""
  },
  {
    ""id"": 9111,
    ""centreName"": ""The Gurdon Institute""
  },
  {
    ""id"": 55,
    ""centreName"": ""The James Cook University Hospital""
  },
  {
    ""id"": 314,
    ""centreName"": ""The Leeds Centre for Reproductive Medicine""
  },
  {
    ""id"": 6,
    ""centreName"": ""The Lister Fertility Clinic""
  },
  {
    ""id"": 258,
    ""centreName"": ""The Whittington Hospital Fertility Unit""
  },
  {
    ""id"": 298,
    ""centreName"": ""The Women's Unit, Cwm Taff NHS Trust""
  },
  {
    ""id"": 260,
    ""centreName"": ""Torbay Hospital""
  },
  {
    ""id"": 175,
    ""centreName"": ""University of Manchester""
  },
  {
    ""id"": 49,
    ""centreName"": ""Wales Fertility Institute - Cardiff""
  },
  {
    ""id"": 9107,
    ""centreName"": ""Wales Fertility Institute-Neath""
  },
  {
    ""id"": 319,
    ""centreName"": ""Wales Heart Research Institute""
  },
  {
    ""id"": 252,
    ""centreName"": ""Wellcome Trust Centre for Stem Cell Research University of Cambridge""
  },
  {
    ""id"": 57,
    ""centreName"": ""Wessex Fertility Limited""
  },
  {
    ""id"": 278,
    ""centreName"": ""Wrightington Wigan & Leigh Hewitt Fertility Partnership""
  },
  {
    ""id"": 283,
    ""centreName"": ""Yeovil District Hospital""
  }
]
";
        
    }
}
