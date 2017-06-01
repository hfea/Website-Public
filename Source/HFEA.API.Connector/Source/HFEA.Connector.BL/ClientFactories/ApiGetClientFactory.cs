using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Attributes;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.Constants;
using System;

namespace HFEA.Connector.Service.ClientFactories
{
    public class ApiGetClientFactory : BaseClientFactory, IGetClientFactory
    {
        private string authToken;

        public ApiGetClientFactory(ITokenResolver securityTokenResolver) : base(HttpMethod.GET)
        {
            this.authToken = securityTokenResolver?.GetJwtToken();
        }

        public ApiGetClientFactory(string securityToken) : base(HttpMethod.GET)
        {
            this.authToken = securityToken;
        }

        public IApiGetClient GetApiClient(Enum apiType)
        {
            IApiGetClient result = null;
            CallType callType = null;

            if (this.ValidateCallType(apiType, out callType))
            {
                string url = this.GetUrl(apiType);

                result = new GetClient(url, this.authToken);
            }

            return result;
        }
    }
}
