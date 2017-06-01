using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class ClinicItem : IClinicRatingsInfo
    {   
        public int Id { get; set; }
        
        public int CentreType { get; set; }
        
        public string CentreName { get; set; }

        public string MainPhoneNumber { get; set; }

        public string CentreTypeDescription { get; set; }

        public double DistanceFromSource { get; set; }

        public double UserRating { get; set; }

        public int NumberOfUserReviews { get; set; }

        public string IndicativeSuccessRate { get; set; }

        public int? ClinicSuccessRateValue { get; set; }
        
        public string IndicativeSuccessRateCaveat { get; set; }

        public string NationalSuccessRate { get; set; }
        
        public int InspectionRating { get; set; }

        public string RatingType { get; set; }

        public string ProfilePageUrl { get; set; }

        public string ImageUrl { get; set; }

        public MapInformation MapInfo { get; set; }

        public string Town { get; set; }

        //public bool HasUserRatingInfo
        //{
        //    get { return this.UserRating > 0 || this.NumberOfUserReviews > 0; }
        //}

        public bool HasSuccessRateInfo
        {
            get { return !string.IsNullOrEmpty(this.IndicativeSuccessRate); } 
        }

        public bool HasMapInfo
        {
            get { return this.MapInfo != null; }
        }

        public bool HasTreatsInfo
        {
            get { return this.IsNhsClinic || this.IsPrivateClinic; }
        }

        public bool HasStaffingInfo
        {
            get { return this.IsFemaleDoctorAvailable || this.HasNamedNurseSystem; }
        }

        public bool HasLinkedLinks
        {
            get { return this.LinkItemList != null && this.LinkItemList.Any(); }
        }

        public bool IsSatelliteOrTransportClinic { get; set; }

        public bool IsForeignerFriendly { get; set; }

        public bool IsNhsClinic { get; set; }

        public bool IsPrivateClinic { get; set; }

        public bool IsFemaleDoctorAvailable { get; set; }

        public bool HasNamedNurseSystem { get; set; }

        public Dictionary<int, string> TreatmentDictionary { get; set; }
        
        public List<LinkItem> LinkItemList { get; set; }

        public string GenericTreatmentTitle { get; set; }

        public string FeedBackLink { get; set; }
    }
}
