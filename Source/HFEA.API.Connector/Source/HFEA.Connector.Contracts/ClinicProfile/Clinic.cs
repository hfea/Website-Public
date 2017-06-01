using HFEA.Connector.Contracts.Centre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
    public class Clinic
    {
        #region Centre details
        public int Id { get; set; }
        public string CentreCode { get; set; }
        public string CentreName { get; set; }
        public string CentreTypeDescription { get; set; }
        public int CentreType { get; set; }
        public string FormattedCentreName { get; set; }
        public int CentreStatus { get; set; }
        public string CentreStatusDescription { get; set; }
        public string CentreEmail { get; set; }
        public string CentrePhone { get; set; }
        public string OtherCentrePhone { get; set; }
        public string Website { get; set; }
        public string Fax { get; set; }
        public string LicensedSince { get; set; }
        public int LicenceIdForUpdate { get; set; }

        public string Description { get; set; }
        public List<Image> Images { get; set; }
        public List<Link> Links { get; set; }
        public string ProfileImageUrl { get; set; }

        #endregion

        #region Centre Contact details
        public Address MainAddress { get; set; }
        public Address BillingAddress { get; set; }
        public Address CorrespondenceAddress { get; set; }
        public Coordinates Coordinates { get; set; }
        public DonorGameteWaitingTimes DonorGameteWaitingTimes { get; set; }
        public List<Licence> Licences { get; set; }
        public List<OpeningTime> OpeningTimes { get; set; }
        #endregion

        #region Centre Information
        public List<CentreInformationEntity> CentreInformation { get; set; }      
        public List<EntityAdditionalInformation> EligibilityAndFunding { get; set; }
        public List<EntityAdditionalInformation> Staff { get; set; }
        public List<EntityAdditionalInformation> Facilities { get; set; }
        public List<EntityAdditionalInformation> CompanyType { get; set; }
        public List<EntityAdditionalInformation> DonorSource { get; set; }
        #endregion

       
        public List<EntityAdditionalInformation> LicenceProcesses { get; set; }
        public List<EntityAdditionalInformation> StaffComplementByRole { get; set; }
        public List<EntityAdditionalInformation> EPRSSystem { get; set; }

        public List<EntityAdditionalInformation> CounsellingAndSupport { get; set; }
        public List<EntityAdditionalInformation> DonorServices { get; set; }
        public List<EntityAdditionalInformation> NonLicensedTreatmentsAndServices { get; set; }
        public List<EntityAdditionalInformation> ScreeningServices { get; set; }
        public List<EntityAdditionalInformation> OtherLookupItems { get; set; }
        public List<Role> Roles { get; set; }
        public List<Image> images { get; set; }

        public PermissionMatrix DataBlockPermissionMatrix { get; set; }

    }
}
