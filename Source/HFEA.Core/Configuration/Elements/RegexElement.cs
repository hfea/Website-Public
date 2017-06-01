
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Configuration.Elements
{
    public class RegexElement : ConfigurationElement
    {
        [ConfigurationProperty("email")]
        public string Email
        {
            get { return this["email"].ToString(); }
        }
        
    }
}