using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CommonObjects
{
    public class IdNameDescription : IdNamePair
    {       
        public string Description { get; set; }
        /// HelpText is a new field and its useage is unclear. 
        /// It seems to be interchnageable with field "Description" 
        public string HelpText { get; set; }
    }
}
