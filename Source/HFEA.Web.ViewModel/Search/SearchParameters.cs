using HFEA.Web.ViewModel.API;
using System.Collections.Generic;

namespace HFEA.Web.ViewModel.Search
{
    public class SearchParameters
    {
        public string SearchKeywords { get; set; }

        public string ContentTagsValue { get; set; }

        public string FilterDate { get; set; }

        public List<ContentTag> ContentTags { get; set; }

        public List<ContentTagValue> ProductFilters { get; set; }
    }
}
