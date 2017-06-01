using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HFEA.Core.Configuration.Elements
{
    public class SearchProviderElement : ConfigurationElement
    {
        [ConfigurationProperty("indexer")]
        public string Indexer
        {
            get { return this["indexer"].ToString(); }
        }

        [ConfigurationProperty("provider")]
        public string Provider
        {
            get { return this["provider"].ToString(); }
        }
    }
}
