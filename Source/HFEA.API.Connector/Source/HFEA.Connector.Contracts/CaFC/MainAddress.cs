using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class MainAddress
    {
        public string AddressType { get; set; }
        public string EntityType { get; set; }
        public string SubDwelling { get; set; }
        public string NumberName { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Country { get; set; }
        public string ComputedBS7666Address { get; set; }
    }
}
