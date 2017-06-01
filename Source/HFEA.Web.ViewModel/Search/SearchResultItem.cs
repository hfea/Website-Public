using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;

namespace HFEA.Web.ViewModel.Search
{
    public class SearchResultItem
    {
        public string Id { get; set; }

        public string Summary { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public BL.Contracts.Constants.Search.SearchSource Source { get; set; }

        public List<ContentTag> ContentTagList {get; set; }

        public List<ContentTag> ProductTagList { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
