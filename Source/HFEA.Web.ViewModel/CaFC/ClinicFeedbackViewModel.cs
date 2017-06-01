using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public class ClinicFeedbackViewModel
    {
        public string IpAddress { get; set; }
        public string CentreId { get; set; }
        public List<ClinicFeedbackQuestion> QuestionList { get; set; }
    }
}
