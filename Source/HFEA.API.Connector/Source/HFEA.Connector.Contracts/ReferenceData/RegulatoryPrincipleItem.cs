using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ReferenceData
{
    public class RegulatoryPrincipleItem
    {
        public int ItemID { get; set; }
        public string Principle { get; set; }
        public string Description { get; set; }
        public string CommaSeparatedSearchTags { get; set; }
        public List<RegulatoryPrincipleItem> RegulatoryPrinciples { get; set; }
    }
}
