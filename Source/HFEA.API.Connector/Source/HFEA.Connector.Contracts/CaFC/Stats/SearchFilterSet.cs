using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC.Stats
{
    public class SearchFilterSet
    {
        public KeyValuePair<string, string> Year { get; set; }
        public KeyValuePair<string, string> Age { get; set; }
        public KeyValuePair<string, string> Treatment { get; set; }
        public KeyValuePair<string, string> Source { get; set; }
    }
}
