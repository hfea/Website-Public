using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.OnlineApps
{
    public class ApplicationDocumentControlDependency
    {
        public int DependencyID { get; set; }
        
        public Constants.OnlineApps.DependencyType DependencyTypeID { get; set; }

        //
        // Summary:
        //     If this value in Dependent Control, then perform action on document Control
        [JsonProperty("dependencyValue")]
        public int DependencyValue { get; set; }
        //
        // Summary:
        //     Dependent Control, typically radio button, which has certain value which causes
        //     action on Control
        [JsonProperty("dependentDocumentControlID")]
        public int DependentDocumentControlID { get; set; }
        //
        // Summary:
        //     Document Control ID - Typically FieldGroup
        [JsonProperty("documentControlID")]
        public int DocumentControlID { get; set; }
    }
}
