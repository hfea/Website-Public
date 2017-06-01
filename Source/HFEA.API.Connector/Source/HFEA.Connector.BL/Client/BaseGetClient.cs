using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Service.ClientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Clients
{
    public class BaseGetClient
    {
        private IPostClientFactory postfactory;

        protected IGetClientFactory Factory { get; private set; }

        public BaseGetClient(IGetClientFactory factory)
        {
            if (factory == null) throw new ArgumentNullException("No valid HTTP client provided");

            this.Factory = factory;
        }

        public BaseGetClient(IPostClientFactory postfactory)
        {
            this.postfactory = postfactory;
        }
    }
}
