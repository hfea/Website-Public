using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.UserFeedback
{
    public class ExperienceSubmissionQuestionInsertModel
    {
      
        public string AdditionalText { get; set; }
        public int QuestionId { get; set; }
        public int Score { get; set; }
    }
}
