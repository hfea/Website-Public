using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Inspection
{
    public class InspectionRatingModel
    {
        public InspectionRating InspectionRating { get; set; }
    }
    public class InspectionRating
    {
        public int CentreId { get; set; }
        public int? OverallScore { get; set; }
        public string InspectionSummary { get; set; }
        public string CentreProfile { get; set; }
        public string LicenceExpires { get; set; }
        public string LastInspected { get; set; }
        public string LicensedSince  { get; set; }
    }
}
