using HFEA.Connector.Contracts.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CentreDashboard
{
    public class PatientExperiences
    {
        public double overallScore { get; set; }
        public double numberOfReviews { get; set; }
        public List<UserRating> shortRatingsList { get; set; }
        public UserRating accuracyOfCostEstimate { get; set; }
        public string lastUpdated { get; set; }
    }
}
