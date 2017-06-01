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
    public class BasePostClient 
    {
        protected IPostClientFactory Factory { get; private set; }

        public BasePostClient(IPostClientFactory factory)
        {
            if (factory == null) throw new ArgumentNullException("No valid HTTP client factory provided");

            this.Factory = factory;
        }
    }
}
