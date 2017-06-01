using HFEA.Connector.Contracts.CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class CentreSearchResultItem
    {
        public int Id { get; set; }
        public string CentreName { get; set; }
        public int CentreType { get; set; }
        public string MainPhoneNumber { get; set; }
        public string Town { get; set; }
        public string CentreTypeDescription { get; set; }
        public double DistanceFromSource { get; set; }
        public string IndicativeSuccessRate { get; set; }
        public string IndicativeSuccessRateCaveat { get; set; }
        public string NationalAverage { get; set; }
        public string ProfileImageURL { get; set; }
        public int InspectionRating { get; set; }
        public double UserRating { get; set; }
        public int NumberOfUserReviews { get; set; }
        public Coordinates Coordinates { get; set; }
        public List<IdNamePair> TreatmentsOffered { get; set; }
        public List<IdNamePair> EligibilityAndFunding { get; set; }
        public List<IdNamePair> Staffing { get; set; }
        public List<Link> Links { get; set; }
        public MapToolTip MapToolTip { get; set; }
        public string IndicativeSuccessRateTitle { get; set; }
        //public string GenericTreatmentTitle { get; set; }
    }
}
