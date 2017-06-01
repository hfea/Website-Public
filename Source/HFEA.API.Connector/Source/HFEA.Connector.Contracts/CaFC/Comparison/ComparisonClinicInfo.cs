using HFEA.Connector.Contracts.CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC.Comparison
{
    public class ComparisonClinicInfo : BaseClinicProfile
    {
        public int InspectionRating { get; set; }
        public string InspectionRatingLicensedUntil { get; set; }
        public double? PatientRating { get; set; }
        public double? PatientRatingNumberOfRatings { get; set; }
        public int? IvfBirthRateAllAges { get; set; }
        public int? DiBirthRateAllAges { get; set; }
        public int? IuiBirthRateAllAges { get; set; }
        public int? MultipleBirthRateAllAges { get; set; }
    }
}
