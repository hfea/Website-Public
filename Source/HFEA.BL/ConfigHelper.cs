using HFEA.Connector.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL
{
    public class ConfigHelper : IConfigValues
    {
        public string baseApiUrl
        {
            get
            {
                return Core.Config.Settings.Generic.ApiUrl;
            }
        }
    }
}
