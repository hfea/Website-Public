using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.Contracts.Search
{
    public interface ISearchIndexItem
    {
        int Id { get; }
        string Title { get; }
        string Summary { get; }
        string Body { get; }
        string Tags { get; }
        string ProductTags { get; }    
        Constants.Search.SearchSource SourceType { get; }  
        DateTime PublishDate { get; }
    }
}
