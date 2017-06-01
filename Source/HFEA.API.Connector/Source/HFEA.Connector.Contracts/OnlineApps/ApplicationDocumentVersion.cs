using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.OnlineApps
{
    public class ApplicationDocumentVersion
    {
        //
        // Summary:
        //     Is document active
        [JsonProperty("active")]
        public bool Active { get; set; }
        //
        // Summary:
        //     Collection of document controls
        [JsonProperty("applicationDocumentControls")]
        public List<ApplicationDocumentControl> ApplicationDocumentControls { get; set; }
        //
        // Summary:
        //     Document ID
        [JsonProperty("DocumentID")]
        public int DocumentID { get; set; }
        //
        // Summary:
        //     Document Version ID
        [JsonProperty("id")]
        public int DocumentVersionID { get; set; }
    }
}
