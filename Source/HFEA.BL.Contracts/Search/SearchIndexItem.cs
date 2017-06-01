using System;

namespace HFEA.BL.Contracts.Search
{
    public class SearchIndexItem : ISearchIndexItem
    {
        public string Body { get; set; }

        public int Id { get; set; }

        public Contracts.Constants.Search.SearchSource SourceType { get; set; }

        public string Tags { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string ProductTags { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
