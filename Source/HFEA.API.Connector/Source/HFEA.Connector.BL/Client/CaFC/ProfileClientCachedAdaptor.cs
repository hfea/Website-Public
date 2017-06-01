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

namespace HFEA.Connector.Service.Clients.CaFC
{
    public class ProfileClientCachedAdaptor : ProfileClient
    {
        private readonly IContentCacheService cacher;

        // default cache expiration is set to 15 minutes
        private readonly TimeSpan cacheTimeout = new TimeSpan(0, 15, 0);

        public ProfileClientCachedAdaptor(IGetClientFactory client, IContentCacheService cacheProvider) : base(client)
        {
            if (cacheProvider == null) throw new ArgumentNullException("Profile reader cache provider is null");
            this.cacher = cacheProvider;
        }

        public override ClinicProfile GetClinicProfile(int clinicId)
        {
            var param = this.GetParams(clinicId);
            string key = Helpers.UrlHelper.GetUrlWithParameters(ApiType.Centre.GetCaFCCentreDetails.GetDescription(), param, null);

            Func<ClinicProfile> client = () => base.GetClinicProfile(clinicId);
            var result = this.cacher.GetResultsOrSetCache<ClinicProfile>(key, client);

            return result;
        }
    }
}
