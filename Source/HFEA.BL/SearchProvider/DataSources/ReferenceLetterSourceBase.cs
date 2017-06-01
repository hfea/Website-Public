using HFEA.Connector.Contracts.Clients.ReferenceData;
using HFEA.Connector.Contracts.ReferenceData;
using HFEA.BL.Contracts.Search;
using HFEA.CP.Web.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SearchSource = HFEA.BL.Contracts.Constants.Search.SearchSource;

namespace HFEA.BL.SearchProvider.DataSources
{
    public abstract class ReferenceLetterSourceBase : BaseSearchDataSource
    {
        public ReferenceLetterSourceBase(SearchSource searchSource) : base(searchSource)
        {
        }
        
        protected List<ISearchIndexItem> MapRawDataToSeachIndexList(List<ListingDataItem> rawData, Func<string, string> letterByIdUrlResolver)
        {
            List<ISearchIndexItem> result = new List<ISearchIndexItem>();

            foreach (var data in rawData)
            {
                var item = new SearchIndexItem()
                {
                    Id = data.Id,
                    Title = data.Title,
                    Summary = data.Summary,
                    Body = data.Summary,
                    SourceType = this.SourceType,
                    Tags = data.CommaSeparatedSearchTags,
                    ProductTags = this.ProductTagStringFromSource,
                    IsKnowledgeBaseContent = this.IsKnowledgeBaseDataSourceType,
                    PublishDate = data.ReleaseDate.ToDateFromIsoString()                    
                };

                result.Add(item);
            }

            return result;
        }
    }
}
