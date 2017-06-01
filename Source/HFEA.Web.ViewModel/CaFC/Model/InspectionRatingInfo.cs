using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class InspectionRatingInfo
    {
        public bool IsValid
        {
            get
            {
                return this.OverallScore > 0 || !string.IsNullOrEmpty(InspectorProfile);
            }
        }

        public int Year
        {
            get
            {
                return LastInspectionDate?.Year ?? 0;
            }
        }

        public int OverallScore { get; set; }

        public string InspectorSummary { get; set; }

        public string InspectorProfile { get; set; }

        public DateTime? LastInspectionDate { get; set; }

        public DateTime? LicensedUntil { get; set; }

        // Additional from InspectionRatings.cs
        public string InspectionSummary { get; set; }
        public string CentreProfile { get; set; }
        public string LicenceExpires { get; set; }
        public string LastInspected { get; set; }
        public DateTime LicensedSince { get; set; }

    }
}
