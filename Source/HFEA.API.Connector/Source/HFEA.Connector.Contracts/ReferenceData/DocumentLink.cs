using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ReferenceData
{
    public class DocumentLink
    {
        public int PlaceholderId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string LinkText { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Constants.ReferenceData.DocumentLinkType LinkType { get; set; }
    }
}
