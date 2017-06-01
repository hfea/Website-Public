using HFEA.Connector.Contracts.UserFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface IPortalUserFeedbackWriter
    {
        bool InsertUserFeedback(List<ExperienceSubmissionQuestionInsertModel> quesions,int CentreId, string ipAddress);
    }
}
