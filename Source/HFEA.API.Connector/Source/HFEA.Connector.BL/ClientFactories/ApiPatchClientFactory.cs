using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Attributes;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.Constants;
using System;

namespace HFEA.Connector.Service.ClientFactories
{
    public class ApiPatchClientFactory : BaseClientFactory, IPatchClientFactory
    {
        private readonly string authToken;

        public ApiPatchClientFactory(ITokenResolver securityTokenResolver) : base(HttpMethod.PATCH)
        {
            this.authToken = securityTokenResolver?.GetJwtToken();
        }

        public ApiPatchClientFactory(string token) : base(HttpMethod.PATCH)
        {
            this.authToken = token;
        }

        public IApiPatchClient GetClientApi(Enum apiType)
        {
            IApiPatchClient result = null;
            CallType callType = null;

            if (this.ValidateCallType(apiType, out callType))
            {
                string url = this.GetUrl(apiType);

                result = new PatchClient(url, this.authToken);
            }

            return result;
        }
    }
}
