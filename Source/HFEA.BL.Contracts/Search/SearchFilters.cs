using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.Contracts.Search
{
    public class SearchFilters
    {
        public string SearchKeywords { get; set; }

        public List<int> ProductTagIds { get; set; }

        public List<int> ContentTagIds { get; set; }

        public DateTime FilterMonth { get; set; }
    }
}
