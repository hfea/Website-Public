using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class WaitingTimes
    {
        public string White { get; set; }

        public string Black { get; set; }

        public string Asian { get; set; }

        public string Mixed { get; set; }

        [JsonProperty(PropertyName = "Other ethnic groups")]
        public string Other { get; set; }
    }
}
