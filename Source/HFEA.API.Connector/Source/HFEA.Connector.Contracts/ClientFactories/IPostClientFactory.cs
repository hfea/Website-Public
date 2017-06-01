using HFEA.Connector.Contracts.Client;
using System;

namespace HFEA.Connector.Contracts.ClientFactories
{
    public interface IPostClientFactory
    {
        IApiPostClient GetApiClient(Enum apiType);
    }
}
