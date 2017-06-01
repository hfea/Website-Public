using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC.Stats
{
    public class ClinicStatsFilterCombinations
    {
        public SearchFilterSet InitialPageLoadDataCombination { get; set; }
        public List<SearchFilterSet> AvailableDataCombinations { get; set; }
    }
}
