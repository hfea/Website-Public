using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Web.ViewModel.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.CaFC
{
    public class ClinicFeedbackReader : IClinicFeedbackReader
    {
        readonly IClinicFeedbackReadClient client;
        readonly ICaFCProfileClient profileClient;

        public ClinicFeedbackReader(IClinicFeedbackReadClient apiClient, ICaFCProfileClient profileReader)
        {
            if (apiClient == null) throw new ArgumentNullException("api client is null");
            if (profileReader == null) throw new ArgumentNullException("cafc profile reader client is null");
            this.client = apiClient;
            this.profileClient = profileReader;
        }

        public ClinicFeedbackViewModel GetClinicFeedbackQuestions()
        {
            ClinicFeedbackViewModel result = null;
            var data = this.client.GetClinicFeedbackQuestions();
            
            if (data != null)
            {
                result = new ClinicFeedbackViewModel()
                {
                    QuestionList = new List<ClinicFeedbackQuestion>()
                };

                foreach(var item in data)
                {
                    var q = new ClinicFeedbackQuestion()
                    {
                        QuestionId = item.QuestionId,
                        QuestionType = item.QuestionType,
                        Question = item.Question,
                        AdditionalTextLabel = item.AdditionalText,
                        HasAdditionalTextField = !string.IsNullOrEmpty(item.AdditionalText),
                        QuestionOptions = new List<KeyValuePair<int, string>>()
                        {
                            new KeyValuePair<int, string>(1, item.ScoreValue1Text),
                            new KeyValuePair<int, string>(2, item.ScoreValue2Text),
                            new KeyValuePair<int, string>(3, item.ScoreValue3Text),
                            new KeyValuePair<int, string>(4, item.ScoreValue4Text),
                            new KeyValuePair<int, string>(5, item.ScoreValue5Text)
                        }                    
                    };

                    result.QuestionList.Add(q);
                }

            }

            return result;            
        }

        public string GetClinicName(int ClinicId)
        {
            var profile = this.profileClient.GetClinicProfile(ClinicId);

            return profile?.CentreName;
        }
    }
}
