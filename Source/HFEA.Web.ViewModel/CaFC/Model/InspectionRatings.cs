using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class InspectionRatings
    {
        public int OverallScore { get; set; }
        public string InspectionSummary { get; set; }
        public string CentreProfile { get; set; }
        public string LicenceExpires { get; set; }
        public string LastInspected { get; set; }
        public DateTime LicensedSince { get; set; }
    }
}
