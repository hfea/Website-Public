using HFEA.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.Search
{
    public class SearchViewModel
    {
        public PagedList<SearchResultItem> ResultList { get; set; }

        public List<SelectFilterGroup> DateFilters { get; set; }

        public SearchBoxViewModel SearchParameters { get; set; }
    }
}