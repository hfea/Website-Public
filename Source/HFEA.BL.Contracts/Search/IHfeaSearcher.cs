using HFEA.BL.Contracts.Search;
using System.Collections.Generic;

namespace HFEA.BL.Contracts.Search
{
    public interface IHfeaSearcher
    {
        List<ISearchResultItem> Search(SearchFilters filters);

        bool FindUpdateNodeIdOrGetNewId(CompositeId id, out int result);
    }
}
