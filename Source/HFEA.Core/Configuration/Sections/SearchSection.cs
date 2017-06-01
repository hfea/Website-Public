using HFEA.Core.Configuration.Elements;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Configuration.Sections
{
    public class SearchSection : ConfigurationElement
    {
        [ConfigurationProperty("searchProvider")]
        public SearchProviderElement SearchProvider
        {
            get { return (SearchProviderElement)this["searchProvider"]; }
        }

        [ConfigurationProperty("indexedDocTypes")]
        public NameElementFieldsCollection IndexedDocTypes
        {
            get { return (NameElementFieldsCollection)(this["indexedDocTypes"]); }
        }

        [ConfigurationProperty("indexedSearchFields")]
        public NameElementFieldsCollection IndexedSearchFields
        {
            get { return (NameElementFieldsCollection)(this["indexedSearchFields"]); }
        }
    }
}
