using System;
using System.Collections.Generic;
using SearchSource = HFEA.BL.Contracts.Constants.Search.SearchSource;

namespace HFEA.BL.Contracts.Search
{
    public interface ISearchDataSource
    {
        bool HasData { get; }

        SearchSource SourceType { get; }

        List<ISearchIndexItem> AllItemsList { get; }

        ISearchIndexItem GetItemById(int id);
    }
}
