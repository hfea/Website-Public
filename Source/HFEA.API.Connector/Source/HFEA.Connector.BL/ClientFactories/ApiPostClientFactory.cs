using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Attributes;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.Extensions;
using System;

namespace HFEA.Connector.Service.ClientFactories
{
    public class ApiPostClientFactory : BaseClientFactory, IPostClientFactory
    {
        private readonly string authToken;
        public ApiPostClientFactory(ITokenResolver securityTokenResolver) : base(HttpMethod.POST)
        {
            this.authToken = securityTokenResolver?.GetJwtToken();
        }

        public ApiPostClientFactory(string securityToken) : base(HttpMethod.POST)
        {
            this.authToken = securityToken;
        }

        public IApiPostClient GetApiClient(Enum apiType)
        {   
            IApiPostClient result = null;
            CallType callType = null;

            if (this.ValidateCallType(apiType, out callType))
            {
                string url = this.GetUrl(apiType);

                result = new PostClient(url, this.authToken);
            }

            return result;
        }
    }
}
