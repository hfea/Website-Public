using HFEA.Connector.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Test.Services
{
    public class ConfigService : IConfigValues
    {
        public string baseApiUrl
        {
            get
            {
                return "http://somewebapi.azurewebsites.net";
            }
        }
    }
}
