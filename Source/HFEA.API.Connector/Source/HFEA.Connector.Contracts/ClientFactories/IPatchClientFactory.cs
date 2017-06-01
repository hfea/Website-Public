using HFEA.Connector.Contracts.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClientFactories
{
    public interface IPatchClientFactory
    {
        IApiPatchClient GetClientApi(Enum apiType);
    }
}
