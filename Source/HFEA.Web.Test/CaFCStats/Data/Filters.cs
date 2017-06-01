using HFEA.Connector.Contracts.CaFC.Stats;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.CaFCStats.Data
{
    public class Filters
    {
        public static ClinicStatsFilterCombinations Data
        {
            get
            {
                return JsonConvert.DeserializeObject<ClinicStatsFilterCombinations>(JSON);
            }
        } 

        public static string JSON
        {
            get
            {
                return @"
{
  ""initialPageLoadDataCombination"": {
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
  ""availableDataCombinations"": [
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
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
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
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
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
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
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2012"",
        ""Value"": ""2012 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
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
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
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
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
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
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2013"",
        ""Value"": ""2013 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""iui"",
        ""Value"": ""iui""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
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
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
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
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
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
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2014"",
        ""Value"": ""2014 Q2""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
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
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
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
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
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
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2015"",
        ""Value"": ""2015 Q2 (Pregnancies only)""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""all_ivf"",
        ""Value"": ""all ivf""
      },
      ""source"": {
        ""Key"": ""ALL_EMB"",
        ""Value"": ""all embryos""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""all"",
        ""Value"": ""all cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""stim"",
        ""Value"": ""stimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""di"",
        ""Value"": ""di""
      },
      ""source"": {
        ""Key"": ""unstim"",
        ""Value"": ""unstimulated cycles""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""icsi"",
        ""Value"": ""icsi only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""35-37"",
        ""Value"": ""35-37""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""b35"",
        ""Value"": ""under 35 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf"",
        ""Value"": ""ivf only""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
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
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""38-39"",
        ""Value"": ""38-39""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""40-42"",
        ""Value"": ""40-42""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""43-44"",
        ""Value"": ""43-44""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""ALL"",
        ""Value"": ""all ages""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
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
        ""Key"": ""DEF"",
        ""Value"": ""fresh embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
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
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
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
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
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
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""DEFER"",
        ""Value"": ""frozen embryos, donor eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FERO"",
        ""Value"": ""frozen embryos, patient's eggs""
      }
    },
    {
      ""year"": {
        ""Key"": ""2999"",
        ""Value"": ""2014 Q2 3 year aggregate data""
      },
      ""age"": {
        ""Key"": ""o44"",
        ""Value"": ""over 44 years""
      },
      ""treatment"": {
        ""Key"": ""ivf_icsi"",
        ""Value"": ""ivf and icsi""
      },
      ""source"": {
        ""Key"": ""FSO"",
        ""Value"": ""fresh embryos, patient's eggs""
      }
    }
  ]
}
";

            }
        }

    }
}
