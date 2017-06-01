using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class ClinicDetailsInfo
    {
       // public string AdditionalClinicInfo { get; set; }
        public string CentreTypeDescription { get; set; }
        public string ImageUrl { get; set; }
        public string CentreEmail { get; set; }
        public string CentrePhone { get; set; }
        public string OtherCentrePhone { get; set; }
        public string Website { get; set; }
        public string WebsiteUri { get; set; }
        public string Fax { get; set; }

        public List<ClinicService> ClinicServiceList { get; set; }

        public MapInformation MapInfo { get; set; }
        
        public List<string> AddressLinesList { get; set; }

        public List<SatelliteClinicInfo> SatelliteClinicList { get; set; }

        public List<SatelliteClinicInfo> TransportClinicList { get; set; }
        
        public List<OpenTimeItem> OpeningHoursList { get; set; }
        

        public bool HasSatelliteClinics {
            get
            {
                return this.SatelliteClinicList != null && this.SatelliteClinicList.Any();
            }   
        }

        public bool HasTransportClinics
        {
            get
            {
                return this.TransportClinicList != null && this.TransportClinicList.Any();
            }
        }
        
        public List<LicenseRoles> LicensePRRolesModel { get; set; }
    }
}
