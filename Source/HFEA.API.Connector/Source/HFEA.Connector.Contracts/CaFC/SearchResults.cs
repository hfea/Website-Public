using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class SearchResults
    {
        public SubmittedSearchParameters SubmittedSearchParameters { get; set; }
        public List<CentreSearchResultItem> CentreSearchResultItems { get; set; }
        public List<MapItem> CentreSearchResultMapItems { get; set; }
    }
}
