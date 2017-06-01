using HFEA.Connector.Contracts.UserFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients
{
    public interface IPortalUserFeedbackClient
    {
        List<ExperienceSubmissionQuestion> GetExperienceSubmissionData();
    }
}
