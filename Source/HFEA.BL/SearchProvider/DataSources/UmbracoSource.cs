using HFEA.BL.Contracts.Search;
using HFEA.Connector.Contracts.Clients.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;

using SearchSource = HFEA.BL.Contracts.Constants.Search.SearchSource;

namespace HFEA.BL.SearchProvider.DataSources
{
    public class UmbracoSource : BaseSearchDataSource
    {
        private readonly IUmbracoContentReader dataReader;

        public UmbracoSource(IUmbracoContentReader nodeReader, ITagsReader tagsSource) : base(SearchSource.CMS, tagsSource)
        {
            if (nodeReader == null) throw new ArgumentNullException("Umbraco node reader is null");

            this.dataReader = nodeReader;
        }
        
        protected override List<ISearchIndexItem> GetListFromSource()
        {
            List<ISearchIndexItem> result = null;
                
            var data = this.dataReader.GetValidUmbracoNodeData();
            if (data != null)
            {
                result = new List<ISearchIndexItem>();

                foreach (var item in data)
                {
                    result.Add(new SearchIndexItem()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Summary = item.Summary,
                        Body = item.Body,
                        Tags = item.Tags,
                        ProductTags = item.ProductTags,
                        SourceType  = item.SourceType,
                        PublishDate = item.PublishDate
                    });
                }
            }

            return result;
        }

        public override ISearchIndexItem GetItemById(int id)
        {
            return this.dataReader.GetValidUmbracoNodeDataById(id);
        }
    }
}
