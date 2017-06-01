using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Service.Constants;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System;
using HFEA.Connector.Service.Extensions;
using HFEA.Connector.Global;

namespace HFEA.Connector.Service.Client.CaFC
{
    public class ClinicFeedbackReadClientCachedAdaptor : ClinicFeedbackReadClient
    {
        private readonly IContentCacheService cacher;

        // default cache expiration is set to 15 minutes
        private readonly TimeSpan cacheTimeout = new TimeSpan(0, 15, 0);

        public ClinicFeedbackReadClientCachedAdaptor(IGetClientFactory client, IContentCacheService cacheProvider) : base(client)
        {
            if (cacheProvider == null) throw new ArgumentNullException("Profile reader cache provider is null");
            this.cacher = cacheProvider;
        }

        public override List<ClinicFeedbackQuestion> GetClinicFeedbackQuestions()
        {
            string key = Helpers.UrlHelper.GetUrlWithParameters(ApiType.CaFCFeedback.LoadCaFCFeedback.GetDescription(), null, null);

            Func<List<ClinicFeedbackQuestion>> client = () => base.GetClinicFeedbackQuestions();
            var result = this.cacher.GetResultsOrSetCache<List<ClinicFeedbackQuestion>>(key, client);

            return result;
        }
    }
}
