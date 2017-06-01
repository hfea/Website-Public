using HFEA.Web.ViewModel.CaFC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public class CaFCProfileViewModel
    {
        public bool IsValidModel { get { return this.GeneralInfo != null && this.GeneralInfo.Id != 0; } }

        public ClinicGeneralInfo GeneralInfo { get; set; }
        public PatientRatingInfo PatientExperiences { get; set; }
        public InspectionRatingInfo InspectionRatings { get; set; }
        public BirthStatisticsInfo BirthStatsInfo { get; set; }
        public WaitingTimesInfo WaitingTimesInfo { get; set; }
        public ClinicDetailsInfo ClinicDetailsInfo { get; set; }  
    }
}
