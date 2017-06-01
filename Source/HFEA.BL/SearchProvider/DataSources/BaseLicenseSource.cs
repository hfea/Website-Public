using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.BL.Contracts.Search;
using HFEA.BL.Contracts.Constants;
using HFEA.Connector.Contracts.ReferenceData;

namespace HFEA.BL.SearchProvider.DataSources
{
    public abstract class BaseLicenseSource : BaseSearchDataSource
    {
        public BaseLicenseSource(Search.SearchSource source) : base(source)
        { 
        }

        protected SearchIndexItem GetResultItem(List<LicenceConditionsData> rawData, 
            int searchId,
            string title)
        {
            SearchIndexItem result = null;
           
            if (rawData != null)
            {
                var flattened = rawData.FlattenBy(x => x.LicenceConditionsDataList).ToList();
                string body = string.Join(" ", flattened.Select(x => x.Description));
                result = new SearchIndexItem()
                {
                    Id = searchId,
                    Title = title,
                    Body = body,
                    SourceType = this.SourceType,
                    Tags = this.GetDistinctTags(flattened),
                    ProductTags = this.ProductTagStringFromSource,
                    IsKnowledgeBaseContent = this.IsKnowledgeBaseDataSourceType,
                    PublishDate = DateTime.MinValue // TODO
                };
            }

            return result;
        }

        private string GetDistinctTags(List<LicenceConditionsData> dataList)
        {
            string result = string.Empty;

            List<string> tagsList = new List<string>();

            foreach (var item in dataList)
            {
                if (!string.IsNullOrEmpty(item.CommaSeparatedSearchTags))
                {
                    tagsList.AddRange(
                        item.CommaSeparatedSearchTags.Split(
                            new char[] { ',' },
                            StringSplitOptions.RemoveEmptyEntries));
                }
            }

            if (tagsList.Any())
            {
                result = string.Join(",", tagsList.Distinct());
            }

            return result;
        }
    }
}
