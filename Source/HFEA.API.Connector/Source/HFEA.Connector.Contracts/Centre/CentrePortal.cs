using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Centre
{
    public class CentrePortal
    {
        public int Id { get; set; }
        public string CentreCode { get; set; }
        public string CentreName { get; set; }
        public string CentreTypeDescription { get; set; }
        public int CentreType { get; set; }
        public string FormattedCentreName { get; set; }
        public string CentreStatus { get; set; }

        public List<Address> Addresses { get; set; }

        public List<EntityAdditionalInformation> CentreInformation { get; set; }

        public List<EntityAdditionalInformation> CompanyType { get; set; }

        public List<Contact> Contacts { get; set; }

        public LocationCoordinates Coordinates { get; set; }

        public List<EntityAdditionalInformation> EligibilityAndFunding { get; set; }

        public List<EntityAdditionalInformation> Facilities { get; set; }

        public ImageDetail Image { get; set; }

        public List<EntityAdditionalInformation> LicenceProcesses { get; set; }

        public List<Licence> Licences { get; set; }

        public string LicensedSince { get; set; }

        public List<EntityAdditionalInformation> OpeningHours { get; set; }

        public List<EntityAdditionalInformation> Staff { get; set; }

        public PermissionMatrix DataBlockPermissionMatrix { get; set; }
    }
}
