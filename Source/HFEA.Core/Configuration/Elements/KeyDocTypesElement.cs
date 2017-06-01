using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Configuration.Elements
{
    public class KeyDocTypesElement : ConfigurationElement
    {
        [ConfigurationProperty("cafcSearchResults")]
        public string CaFCSearchResults
        {
            get { return this["cafcSearchResults"].ToString(); }
        }

        [ConfigurationProperty("treatmentSearchContainer")]
        public string TreatmentSearchContainer
        {
            get { return this["treatmentSearchContainer"].ToString(); }
        }

        [ConfigurationProperty("treatmentSearchOption")]
        public string TreatmentSearchOption
        {
            get { return this["treatmentSearchOption"].ToString(); }
        }

        [ConfigurationProperty("clinicStats")]
        public string ClinicStatistics
        {
            get { return this["clinicStats"].ToString(); }
        }
        
        [ConfigurationProperty("pgdDetails")]
        public string PgdDetails
        {
            get { return this["pgdDetails"].ToString(); }
        }

    }
}