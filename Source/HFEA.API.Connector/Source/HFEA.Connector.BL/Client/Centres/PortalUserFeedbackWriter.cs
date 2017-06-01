using HFEA.Connector.Contracts.Clients.Centres;
using HFEA.Connector.Global;
using HFEA.Connector.Service.BaseClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.UserFeedback;

namespace HFEA.Connector.Service.Client.Centres
{
    public class PortalUserFeedbackWriter : BaseSdkClient, IPortalUserFeedbackWriter
    {
        public PortalUserFeedbackWriter(ITokenResolver tokenResolver, IHfeaLogger logger) : base(tokenResolver, logger)
        {
        }

        public bool InsertUserFeedback(List<ExperienceSubmissionQuestionInsertModel> quesions, int CentreId, string ipAddress)
        {
            bool result = false;
            SDK.Model.ExperienceSubmission experienceSubmission = new SDK.Model.ExperienceSubmission();
            experienceSubmission.CentreId = CentreId.ToString();
            experienceSubmission.IpAddress = ipAddress;
            experienceSubmission.ExperienceSubmissionQuestions = new List<SDK.Model.ExperienceSubmissionQuestion>();
            foreach (var item in quesions)
            {
                experienceSubmission.ExperienceSubmissionQuestions.Add(
                    new SDK.Model.ExperienceSubmissionQuestion
                    {
                        AdditionalText = item.AdditionalText,
                        QuestionId = item.QuestionId,
                        Score = item.Score
                    });
            }
            try
            {
                result = this.ApiClient.InsertPortalUserFeedback(experienceSubmission);
            }
            catch (Exception ex)
            {
                Log.Error("error inserting feedback", ex);
            }

            return result;
        }
    }
}
