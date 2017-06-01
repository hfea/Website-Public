using HFEA.Connector.Contracts.Clients.ReferenceData;
using HFEA.BL.Contracts.Search;
using HFEA.CP.Web.ViewModel.Constants;
using HFEA.CP.Web.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SearchSource = HFEA.BL.Contracts.Constants.Search.SearchSource;


namespace HFEA.BL.SearchProvider.DataSources
{
    public class DirectionsSource : BaseSearchDataSource
    {
        private readonly IReferenceDataReader dataReader;

        public DirectionsSource(IReferenceDataReader refDataReader) : base(SearchSource.Directions)
        {
            if (refDataReader == null) throw new ArgumentNullException("Reference data reader is null");

            this.dataReader = refDataReader;
        }
        
        protected override List<ISearchIndexItem> GetListFromSource()
        {
            List<ISearchIndexItem> result = new List<ISearchIndexItem>();
            var rawData = this.dataReader.GetDirectionsData();            

            if (rawData != null && rawData.ReferenceDatas != null)
            {
                foreach(var data in rawData.ReferenceDatas)
                {
                    var item = new SearchIndexItem()
                    {
                        Id = data.ItemId,
                        Title = data.Title,
                        Summary = string.Empty,
                        Body = data.Description,
                        SourceType = this.SourceType,
                        Tags = string.Empty, // TODO no tags in directions data yet
                        ProductTags = this.ProductTagStringFromSource,
                        IsKnowledgeBaseContent = this.IsKnowledgeBaseDataSourceType,
                        PublishDate = data.ReleaseDate.ToNullableDate().GetValueOrDefault()
                    };

                    result.Add(item);
                }
            }

            return result;
        }
    }
}
