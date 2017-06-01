using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class ClinicFeedbackSubmissionQuestion
    {
        public int QuestionId { get; set; }
        public int Score { get; set; }
        public string AdditionalText { get; set; }
    }
}
