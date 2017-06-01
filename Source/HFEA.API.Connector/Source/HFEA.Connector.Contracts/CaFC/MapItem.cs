using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class MapItem
    {
        public int CentreId { get; set; }
        public string CentreName { get; set; }
        public string CentreType { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public List<Link> Links { get; set; }
    }
}
