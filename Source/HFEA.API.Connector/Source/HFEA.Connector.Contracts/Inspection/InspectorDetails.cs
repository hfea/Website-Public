using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Inspection
{
    public class InspectorDetails
    {
        public string InspectorName { get; set; }
        public string InspectorEmail { get; set; }
        public string InspectorPhone { get; set; }
    }
    public class InspectionModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    }
}
