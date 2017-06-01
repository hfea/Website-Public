namespace HFEA.Web.ViewModel.Search
{
    public interface ISearchViewModelReader
    {
        SearchViewModel GetViewModel(SearchParameters searchParams, int page, int pageSize);

        SearchBoxViewModel GetSearchBoxViewModel(SearchParameters searchParams);
    }
}
