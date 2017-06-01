using HFEA.Connector.Contracts.Client;
using System;

namespace HFEA.Connector.Contracts.ClientFactories
{
    public interface IGetClientFactory
    {
        IApiGetClient GetApiClient(Enum apiType);
    }
}
