namespace HFEA.Web.ViewModel.CaFC
{
    public interface ICafcQueryStringHelper
    {
        SearchParameters GetFilterValuesFromString(string location, string distance, string options, string page, string sort);
        string GetQueryString(CaFCFiltersViewModel filters);
        string GetQueryString(SearchParameters filters);
    }
}