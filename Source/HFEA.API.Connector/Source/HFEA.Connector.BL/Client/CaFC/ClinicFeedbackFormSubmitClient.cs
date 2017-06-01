using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Service.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.CaFC;
using System.Collections.Specialized;
using HFEA.Connector.Service.Constants;


namespace HFEA.Connector.Service.Client.CaFC
{
    public class ClinicFeedbackFormSubmitClient : BasePostClient, IClinicFeedbackFormSubmitClient
    {
        public ClinicFeedbackFormSubmitClient(IPostClientFactory factory) : base(factory){}

        public bool SetClinicFeedbackAnswers(Contracts.CaFC.ClinicFeedback FeedBackAnswers)
        {
            bool result = this.Factory.GetApiClient(ApiType.CaFCFeedback.PostCaFCFeedback).ExecuteRequest(FeedBackAnswers);
            return result;
        }
    }
}
