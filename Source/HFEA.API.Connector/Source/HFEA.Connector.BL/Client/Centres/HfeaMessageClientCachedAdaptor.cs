using HFEA.Connector.Contracts.CentreDashboard;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Client.Centres
{
    public class HfeaMessageClientCachedAdaptor : HfeaMessageClient
    { 
        private readonly IContentCacheService cacher;

        // default cache expiration is set to 15 minutes
        private readonly TimeSpan cacheTimeout = new TimeSpan(0, 15, 0); 
        
        public HfeaMessageClientCachedAdaptor(IGetClientFactory factory, IContentCacheService cacheProvider) : base(factory)
        {
            if (cacheProvider == null) throw new ArgumentNullException("COP cache provide is null");

            this.cacher = cacheProvider;
        }

        public override List<Message> GetClinicMessages(int clinicId)
        {
            var parameters = this.GetArchiveCallParameters(clinicId);
            string key = Helpers.UrlHelper.GetUrlWithParameters(ApiType.Centre.GetMessageArchive.GetDescription(), parameters, null);

            Func<List<Message>> client = () => base.GetClinicMessages(clinicId);
            var result = this.cacher.GetResultsOrSetCache<List<Message>>(key, client);

            return result;
        }

        public override Message GetMessageById(int clinicId, int messageId)
        {
            var parameters = this.GetMessageCallParameters(clinicId, messageId);
            string key = Helpers.UrlHelper.GetUrlWithParameters(ApiType.Centre.GetMessage.GetDescription(), parameters, null);

            Func<Message> client = () => base.GetMessageById(clinicId, messageId);
            var result = this.cacher.GetResultsOrSetCache<Message>(key, client);

            return result;
        }        
    }
}
