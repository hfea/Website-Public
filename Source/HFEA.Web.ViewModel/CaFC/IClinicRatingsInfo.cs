namespace HFEA.Web.ViewModel.CaFC
{
    public interface IClinicRatingsInfo
    {
        string RatingType { get; }
        string IndicativeSuccessRate { get; }
        string IndicativeSuccessRateCaveat { get; }
        int InspectionRating { get; }
        string NationalSuccessRate { get; }
        int NumberOfUserReviews { get; }
        double UserRating { get; }
        //bool HasUserRatingInfo { get; }
        bool IsSatelliteOrTransportClinic { get; }
        bool HasSuccessRateInfo { get; }
        int? ClinicSuccessRateValue { get; }
        string GenericTreatmentTitle { get; set; }
        string FeedBackLink { get; set; }
    }
}