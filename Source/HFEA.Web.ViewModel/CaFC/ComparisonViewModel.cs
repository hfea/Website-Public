using HFEA.Core.Extensions;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC.Model.Comparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public class ComparisonViewModel
    {
        public string NotAvailableString = "n/a";
        
        public bool AssociatedClinicsExist
        {
            get
            {
                return this.ClinicList != null
                    && this.ClinicList.Any(x => !(x.SatelliteClinicList.IsNullOrEmpty() && x.TransportClinicList.IsNullOrEmpty()));
            }
        }

        public List<int> ClinicIds {
            get
            {
                if (ClinicList != null)
                {
                    return ClinicList.Select(x => x.ClinicId).ToList();
                }

                return null;
            }
        }
        public List<ComparisonClinic> ClinicList { get; set; }

        public List<IdValuePairInt> EligibilityItems { get; set; }

        public List<IdValuePairInt> TreatmentItems { get; set; }

        public List<IdValuePairInt> DonorServiceItems { get; set; }

        public List<IdValuePairInt> CounsellingItems { get; set; }

        public List<IdValuePairInt> StaffingItems { get; set; }

        public List<IdValuePairInt> FacilitiesItems { get; set; }
    }
}
