using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class ClinicGeneralInfo : IClinicRatingsInfo
    {
        public int Id { get; set; }

        public string CentreName { get; set; }

        public string CentreDescription { get; set; }

        public string ImageUrl { get; set; }

        public double UserRating { get; set; }

        public int NumberOfUserReviews { get; set; }

        public int InspectionRating { get; set; }

        public string IndicativeSuccessRate { get; set; }

        public string IndicativeSuccessRateCaveat { get; set; }

        public string SuccessRateSummaryCaveat { get; set; }

        public string NationalSuccessRate { get; set; }        

        public bool IsSatelliteOrTransportClinic { get; set; }

        public int? ClinicSuccessRateValue { get; set; }

        public string RatingType { get; set; }

        public string GenericTreatmentTitle { get; set; }
        public string FeedBackLink { get; set; }

        public bool HasUserRatingInfo { get; set; }
        public bool HasSuccessRateInfo { get; set; }
        public bool HasInspectorRatingInfo { get; set; }
    }
}
