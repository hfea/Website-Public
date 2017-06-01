using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients;
using HFEA.Connector.Contracts.UserFeedback;
using HFEA.Connector.Service.Clients;
using HFEA.Connector.Service.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Client.Centres
{
    public class PortalUserFeedbackClient: BaseGetClient, IPortalUserFeedbackClient
    {
        private const ApiType.Centre GetPortalUserFeedbackData = ApiType.Centre.GetPortalFeedback;

        public PortalUserFeedbackClient(IGetClientFactory factory) : base(factory)
        {
        }

        public List<ExperienceSubmissionQuestion> GetExperienceSubmissionData()
        {
            return this.Factory.GetApiClient(GetPortalUserFeedbackData).ExecuteRequest<List<ExperienceSubmissionQuestion>>(null, null);
        }
    }
}
