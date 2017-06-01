using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HFEA.Connector.Contracts.CaFC
{
    public class ClinicFeedback
    {
        public string IpAddress { get; set; }
        public string CentreId { get; set; }
        public List<ClinicFeedbackSubmissionQuestion> ExperienceSubmissionQuestions { get; set; }
    }
}
