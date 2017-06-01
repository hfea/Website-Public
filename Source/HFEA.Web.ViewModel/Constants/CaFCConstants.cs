using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.Constants
{
    public class CaFCConstants
    {
        /// <summary>
        /// Dynamic filters for CaFC search
        /// DO NOT RENAME ENUM VALUES! They must correspond to values returned by API
        /// </summary>
        public enum DynamicFilterType
        {
            Unknown = 0,
            Treatments,
            EligibilityAndFunding,
            DonorRecruitment,
            ScreeningServices,
            CounsellingAndSupport,
            // AK: 1/3/2016: this option has been removed. Check API later and delete as appropriate
            // NonLicensedTreatmentsAndServices 
        }

        public enum ClinicServiceType
        {
            Unknown = 0,
            Treat,
            Treatments,
            DonorServices,
            ScreeningServices,
            CounsellingAndSupport,
            Staffing,
            Facilities
        }

        /// <summary>
        /// Compare to national average options
        /// Description attribute value is being rendered as label on CAFC profile page
        /// </summary>
        public enum ComparableToAverage
        {
            Unknown = 0,
            [Description("Consistent with")]
            Consistent,
            [Description("Above")]
            Above,
            [Description("Below")]
            Below
        }

        public enum TreatmentType
        {
            Unknown = 0,
            Treats,
            Treatments,
            Staffing,
            InspectionRating
        }

        public enum EligibilityAndFunding
        {
            Unknown = 0,
            ForeignPatients,
            NHS,
            Private
            
        }

        public enum Staffing
        {
            Unknown = 0,
            NamedNurseSystem,
            FemaleDoctorAvailable            
        }

        public enum ClinicType
        {
            Unknown = 0,
            Satellite,
            Transport
        }

        public enum StatsTreatmentType
        {
            Unknown = 0,
            PerTreatmentCycle,
            PerEmbryoTransferred
        }
    }
}
