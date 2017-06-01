using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.Contracts.Search
{
    public interface ISearchResultItem
    {
        int NodeId { get; }
        float Score { get; }
        int Id { get; }
        string Title { get; }
        string Summary { get; }
        string Body { get; }
        string Url { get; }
        List<int> Tags { get; }
        List<int> ProductTags { get; }        
        Constants.Search.SearchSource SourceType { get; }     
        DateTime PublishDate { get; }
    }
}
