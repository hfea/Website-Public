using HFEA.Core.Configuration.Elements;
using HFEA.Core.Configuration.Sections;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core
{
    public class Config : ConfigurationSection
    {
        private static readonly object Padlock = new object();
        private static Config instance = null;

        private Config()
        {
        }

        public static Config Settings
        {
            get
            {
                lock (Padlock)
                {
                    if (instance == null)
                    {
                        instance = (Config)ConfigurationManager.GetSection("hfea");
                    }

                    return instance;
                }
            }
        }

        [ConfigurationProperty("generic")]
        public GenericElement Generic
        {
            get { return (GenericElement)this["generic"]; }
        }

        [ConfigurationProperty("keyPages")]
        public KeyPagesElement KeyPages
        {
            get { return (KeyPagesElement)this["keyPages"]; }
        }

        [ConfigurationProperty("keyDocTypes")]
        public KeyDocTypesElement KeyDocTypes
        {
            get { return (KeyDocTypesElement)this["keyDocTypes"]; }
        }

        [ConfigurationProperty("search")]
        public SearchSection Search
        {
            get { return (SearchSection)this["search"]; }
        }

        [ConfigurationProperty("regex")]
        public RegexElement Regex
        {
            get { return (RegexElement)this["regex"]; }
        }
    }
}
