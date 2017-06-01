using HFEA.Connector.Contracts.ClientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Client
{
    public class BasePatchClient
    {
        protected IPatchClientFactory Factory { get; private set; }
        public BasePatchClient(IPatchClientFactory factory)
        {
            if (factory == null) throw new ArgumentNullException ("No valid HTTP client factory provided");
            this.Factory = factory;
        }
    }
}
