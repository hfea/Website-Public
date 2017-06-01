using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public class ClinicFeedbackQuestion
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int Score { get; set; }
        public List<KeyValuePair<int, string>> QuestionOptions { get; set; }
        public bool HasAdditionalTextField { get; set; }
        public string AdditionalTextLabel { get; set; }
        public string AdditionalText { get; set; }
        public string QuestionType { get; set; }
    }
}
