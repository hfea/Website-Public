using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Configuration.Elements
{
    public class GenericElement : ConfigurationElement
    {
        [ConfigurationProperty("apiUrl")]
        public string ApiUrl
        {
            get { return this["apiUrl"].ToString(); }
        }

        [ConfigurationProperty("appInsightsId")]
        public string AppInsightsId
        {
            get { return this["appInsightsId"].ToString(); }
        }        
    }
}
