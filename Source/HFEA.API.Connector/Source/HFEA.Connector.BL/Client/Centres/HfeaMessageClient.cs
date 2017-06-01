using HFEA.Connector.Contracts.CentreDashboard;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.Centres;
using HFEA.Connector.Service.Clients;
using HFEA.Connector.Service.Constants;
using System;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace HFEA.Connector.Service.Client.Centres
{
    public class HfeaMessageClient : BaseGetClient, IHfeaMessageClient
    {
        public HfeaMessageClient(IGetClientFactory factory) : base(factory)
        {
        }
        
        public virtual List<Message> GetClinicMessages(int clinicId)
        {
            var parameters = GetArchiveCallParameters(clinicId);

            return this.Factory.GetApiClient(ApiType.Centre.GetMessageArchive)
                .ExecuteRequest<List<Message>>(parameters, null);
        }

        public virtual Message GetMessageById(int clinicId, int messageId)
        {
            var parameters = this.GetMessageCallParameters(clinicId, messageId);

            return this.Factory.GetApiClient(ApiType.Centre.GetMessage)
                .ExecuteRequest<Message>(parameters, null);
        }

        protected NameValueCollection GetArchiveCallParameters(int clinicId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(ApiParams.CentreId, clinicId.ToString());

            return parameters;
        }

        protected NameValueCollection GetMessageCallParameters(int clinicId, int messageId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(ApiParams.MessageId, messageId.ToString());
            parameters.Add(ApiParams.CentreId, clinicId.ToString());

            return parameters;
        }
    }
}
