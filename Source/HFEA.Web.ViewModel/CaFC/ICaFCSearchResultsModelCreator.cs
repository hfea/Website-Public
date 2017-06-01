using System.Collections.Generic;

namespace HFEA.Web.ViewModel.CaFC
{
    public interface ICaFCSearchResultsModelCreator
    { 
        CaFCSearchViewModel GetCaFCResultsViewModel(SearchParameters filterList);
    }
}