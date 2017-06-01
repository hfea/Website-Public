using HFEA.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.Search
{
    public class SearchBoxViewModel
    {
        public bool IsEmpty
        {
            get
            {
                return this.SearchParams == null
                    || (string.IsNullOrWhiteSpace(SearchParams.SearchKeywords)
                        && SearchParams.ContentTags.IsNullOrEmpty()
                        && (SearchParams.ProductFilters.IsNullOrEmpty() || SearchParams.ProductFilters.All(x => !x.IsChecked))); 
            }
        }
        public SearchParameters SearchParams { get; set; }
        
        public string SearchBoxLabel { get; set; }

        public string SearchButtonLabel { get; set; }
    }
}
