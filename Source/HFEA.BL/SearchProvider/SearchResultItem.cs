using HFEA.BL.Contracts.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.SearchProvider
{
    public class SearchResultItem : ISearchResultItem
    {
        public string Body { get; set; }

        public int Id { get; set; }

        public Contracts.Constants.Search.SearchSource SourceType { get; set; }

        public List<int> Tags { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Url { get; set; }

        public List<int> ProductTags { get; set; }

        public DateTime PublishDate { get; set; }

        public int NodeId { get; set; }

        public float Score { get; set; }
    }
}
