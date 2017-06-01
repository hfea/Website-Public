using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Service.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Service.Constants;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Client.CaFC
{
    public class ClinicFeedbackReadClient : BaseGetClient, IClinicFeedbackReadClient
    {
        public ClinicFeedbackReadClient(IGetClientFactory factory) : base(factory) { }

        public virtual List<ClinicFeedbackQuestion> GetClinicFeedbackQuestions()
        {
            var report = this.Factory.GetApiClient(ApiType.CaFCFeedback.LoadCaFCFeedback).ExecuteRequest<List<Contracts.CaFC.ClinicFeedbackQuestion>>(null, null);
            return report;
        }
    }
}
