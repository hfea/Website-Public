using HFEA.Connector.Contracts.Clients.COP;
using HFEA.Connector.Contracts.Clients.ReferenceData;
using HFEA.Connector.Contracts.COP;
using HFEA.BL.Contracts.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SearchSource = HFEA.BL.Contracts.Constants.Search.SearchSource;
using HFEA.Web.ViewModel.COP;
using HFEA.Core.Extensions;
using HFEA.Connector.Contracts.Clients.AccessControl;

namespace HFEA.BL.SearchProvider.DataSources
{
    public class CopSource : BaseSearchDataSource
    {
        private readonly ICOPReaderClient dataReader;
        private readonly ICOPUrlResolver urlResolver;

        public CopSource(ICOPReaderClient refDataReader, ICOPUrlResolver copUrlResolver, ITagsReader tagsSource) : base(SearchSource.COP, tagsSource)
        {
            if (refDataReader == null) throw new ArgumentNullException("Reference data reader is null");
            if (copUrlResolver == null) throw new ArgumentNullException("Reference URL resolver is null");

            this.dataReader = refDataReader;
            this.urlResolver = copUrlResolver;
        }
        
        protected override List<ISearchIndexItem> GetListFromSource()
        {
            List<ISearchIndexItem> result = new List<ISearchIndexItem>();
            
            var groups = this.dataReader.GetAllGroups();
            if (groups != null && groups.COPGroups != null && groups.COPGroups.Any())
            {
                var allSections = groups.COPGroups.SelectMany(x => x.COPSections);
                List<int> sectionIdList = allSections
                    .Select(x => x.SectionNumberInt)
                    .Where(x => x != 0)
                    .ToList();

                foreach (int id in sectionIdList)
                {
                    var data = this.dataReader.GetSection(id);
                    COPSection section = data != null && data.COPSections != null && data.COPSections.Any()
                        ? data.COPSections[0]
                        : null;

                    var searchIndexItem = this.GetSectionAsSearchIndexItem(section);
                    if (searchIndexItem != null)
                    {
                        result.Add(searchIndexItem);
                    }
                }                    
            }

            return result;
        }

        private SearchIndexItem GetSectionAsSearchIndexItem(COPSection item)
        {
            SearchIndexItem result = null;

            if (item != null)
            {
                result = new SearchIndexItem()
                {
                    Id = item.SectionNumberInt,
                    Title = item.SectionName,
                    Body = this.GetSectionText(item),
                    SourceType = this.SourceType,
                    Summary = string.Empty, // TODO?
                    Tags = this.ContentTagsToTagIdCommaSeparated(item.CommaSeparatedSearchTags),
                    ProductTags = this.ProductTagStringFromSource,
                    // PublishDate = DateTime.MinValue // TODO
                };
            }

            return result;
        }

        private string GetSectionText(COPSection item)
        {
            var sb = new StringBuilder();
            
            Action<List<COPContent>, Func<COPContent, IEnumerable<COPContent>>> addToText = (data, selector) =>
            {
                if (data != null)
                {
                    List<string> descriptions =
                        data.FlattenBy(x => selector(x), true)
                        .Select(x => x.Description)
                        .ToList();

                    if (descriptions.Any())
                    {
                        string res = string.Join(" ", descriptions);
                        sb.AppendLine(res);
                    }
                }
            };

            if (item != null)
            {
                addToText(item.COPActs, x => x.COPVersionDatas);
                addToText(item.COPReferences, x => x.COPVersionDatas);
                addToText(item.COPLicenceConditions, x => x.COPVersionDatas);
                addToText(item.COPVersionDatas, x => x.COPVersionDatas);
            }

            return sb.ToString();
        }
    }
}
