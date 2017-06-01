using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class PatientRatingInfo
    {
        public bool IsValid { get { return OverallScore > 0d; } }
        public double OverallScore { get; set; }
        public int NumberOfReviews { get; set; }
        public List<UserRating> ShortRatingsList { get; set; }
        public UserRating AccuracyOfCostEstimate { get; set; }
        public string FeedBackLink { get; set; }
    }
}
