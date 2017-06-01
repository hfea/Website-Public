using HFEA.Connector.Contracts.ClientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.ClientFactories
{
    public class ApiGetClientFactoryNonSecure : ApiGetClientFactory, IGetClientFactory
    {
        public ApiGetClientFactoryNonSecure() : base(string.Empty)
        { }
    }
}
