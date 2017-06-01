using HFEA.Connector.Contracts.CaFC;
using HFEA.Core.Extensions;
using HFEA.Web.ViewModel.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.CaFC
{
    public class ClinicFeedbackWriter : IClinicFeedbackWriter
    {
        readonly Connector.Contracts.Clients.CaFC.IClinicFeedbackFormSubmitClient client;
        public ClinicFeedbackWriter(Connector.Contracts.Clients.CaFC.IClinicFeedbackFormSubmitClient apiClient)
        {
            if (apiClient == null) throw new ArgumentNullException("api client is null");
            this.client = apiClient;
        }
        public bool SaveClinicFeedbackAnswers(ClinicFeedbackViewModel model)
        {
            bool result = false;

            if (model != null && !model.QuestionList.IsNullOrEmpty())
            {
                var submitData = new ClinicFeedback()
                {
                    CentreId = model.CentreId,
                    IpAddress = model.IpAddress,
                    ExperienceSubmissionQuestions = model.QuestionList.Select(
                         x => new ClinicFeedbackSubmissionQuestion()
                         {
                             QuestionId = x.QuestionId,
                             Score = x.Score,
                             AdditionalText = x.AdditionalText
                         }).ToList()
                };

                result = this.client.SetClinicFeedbackAnswers(submitData);
            }
            
            return result;
        }
    }
}
