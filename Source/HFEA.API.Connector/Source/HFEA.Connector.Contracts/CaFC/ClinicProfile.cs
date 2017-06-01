using HFEA.Connector.Contracts.CommonObjects;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HFEA.Connector.Contracts.CaFC
{
    public class ClinicProfile : BaseClinicProfile
    {
        public string IndicativeSuccessRate { get; set; }
        public string NationalAverage { get; set; }
        public string CentreEmail { get; set; }
        public string CentrePhone { get; set; }
        public string OtherCentrePhone { get; set; }
        public string Website { get; set; }
        public string Fax { get; set; }
        public string Description { get; set; }
        public string IndicativeSuccessRateCaveat { get; set; }
        public string SuccessRateSummaryCaveat { get; set; }
        public bool HasDetailedStatistics { get; set; }
        public List<Image> Images { get; set; }        
        public MapToolTip MapToolTip { get; set; }
        public CentreSuccessRateSummary CentreSuccessRateSummary { get; set; }
        public PatientExperiences PatientExperiences { get; set; }
        public InspectionRatings InspectionRatingProfile { get; set; }
        public Coordinates Coordinates { get; set; }
        public List<IdNamePair> CompanyType { get; set; }
        public List<IdNamePair> DonorSource { get; set; }
        public List<IdNameDescription> CentreInformation { get; set; }
        public List<IdNamePair> NonLicensedTreatmentsAndServices { get; set; }
        // Licensing Attributes
        public List<LicenceRoles> LicenceRoles { get; set; }
    }
}
