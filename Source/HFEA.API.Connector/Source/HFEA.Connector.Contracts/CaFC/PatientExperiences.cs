using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class PatientExperiences
    {
        public double OverallScore { get; set; } 
        public int NumberOfReviews { get; set; }

        public List<UserRating> ShortRatingsList { get; set; }

        public UserRating AccuracyOfCostEstimate { get; set; }
    }
}
