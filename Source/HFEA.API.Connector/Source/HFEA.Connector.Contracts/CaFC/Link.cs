using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class Link
    {
        public int CentreLinkId { get; set; }
        public int ParentCentreId { get; set; }
        public string ParentCentreName { get; set; }
        public int LinkCentreId { get; set; }
        public string LinkCentreName { get; set; }
        public int LinkType { get; set; }
        public string LinkTypeDescription { get; set; }
        public MainAddress LinkCentreAddress { get; set; }
        public string LinkCentrePhone { get; set; }
    }
}
