using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ReferenceData
{
    public class LicenceConditionsData
    {
        public int ItemId { get; set; }
        public string LicenceCondition { get; set; }
        public string Description { get; set; }

        [JsonProperty("licenceconditiondatas")]
        public List<LicenceConditionsData> LicenceConditionsDataList { get; set; }

        public string CommaSeparatedSearchTags { get; set; }
    }
}
