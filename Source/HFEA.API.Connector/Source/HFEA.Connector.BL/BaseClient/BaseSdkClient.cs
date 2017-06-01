using HFEA.Connector.Global;
using HFEA.Connector.Service.Helpers;
using HFEA.SDK;
using System;

namespace HFEA.Connector.Service.BaseClient
{
    public class BaseSdkClient
    {
        private readonly Uri uri = new Uri(UrlHelper.BaseApiUrl);
        
        public BaseSdkClient(ITokenResolver tokenResolver, IHfeaLogger logger)
        {
            if (tokenResolver == null) throw new ArgumentNullException("tokenresolver is null");
            if (logger == null) throw new ArgumentNullException("logger is null");

            this.ApiClient = new IfqApiClient(uri);
            this.ApiClient.JwtToken = tokenResolver.GetJwtToken();
            this.Log = logger;     
        }

        protected IHfeaLogger Log { get; private set; }

        protected IfqApiClient ApiClient { get; private set; }
    }
}
