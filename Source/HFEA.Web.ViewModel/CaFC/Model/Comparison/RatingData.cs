using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model.Comparison
{
    public class RatingData
    {
        public int InspectionRating { get; set; }
        public DateTime? InspectionRatingLicensedUntil { get; set; }
        public double PatientRating { get; set; }
        public int PatientRatingCount { get; set; }        
        public StatisticsItem IVF { get; set; }
        public StatisticsItem IUI { get; set; }
        public StatisticsItem DI { get; set; }
        public StatisticsItem MultipleRate { get; set; }        
    }
}
