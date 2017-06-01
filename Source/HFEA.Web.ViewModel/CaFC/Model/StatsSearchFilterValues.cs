using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    [DataContract(Name = "valueSet")]
    public class StatsSearchFilterValues
    {
        [DataMember(Name = "clinicId")]
        public int ClinicId { get; set; }

        [DataMember(Name = "step")]
        public int CurrentStep { get; set; }

        [DataMember(Name = "showYear")]
        public bool ShowYearDropDown { get; set; }

        [DataMember(Name = "showAge")]
        public bool ShowAgeDropDown { get; set; }

        [DataMember(Name = "showTreatment")]
        public bool ShowTreatmentDropDown { get; set; }

        [DataMember(Name = "showSource")]
        public bool ShowSourceDropDown { get; set; }

        [DataMember(Name = "years")]
        public List<IdValuePair> Years { get; set; }

        [DataMember(Name = "ages")]
        public List<IdValuePair> Ages { get; set; }

        [DataMember(Name = "treatments")]
        public List<IdValuePair> Treatments { get; set; }

        [DataMember(Name = "sources")]
        public List<IdValuePair> Sources { get; set; }        
    }
}
