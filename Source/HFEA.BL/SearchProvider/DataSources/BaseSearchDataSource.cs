using HFEA.Connector.Contracts.Api;
using HFEA.BL.Contracts.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SearchSource = HFEA.BL.Contracts.Constants.Search.SearchSource;
using HFEA.Connector.Contracts.Clients.AccessControl;

namespace HFEA.BL.SearchProvider.DataSources
{
    public abstract class BaseSearchDataSource : ISearchDataSource
    {
        private const int CopProductTagId = 3476;
        private List<ISearchIndexItem> allItemsList;
        private readonly ITagsReader tagsReader;

        public BaseSearchDataSource(SearchSource source, ITagsReader tagsSource)
        {
            if (source == SearchSource.Unknown) throw new ArgumentOutOfRangeException("data source type is Unknown");
            if (tagsSource == null) throw new ArgumentNullException("tags source is null");
            this.SourceType = source;
            this.tagsReader = tagsSource;
            
            if (source == SearchSource.COP)
            {
                this.ProductTagStringFromSource = CopProductTagId.ToString();
            }
        }

        public SearchSource SourceType { get; private set; }
                
        protected string ProductTagStringFromSource { get; private set; }

        public List<ISearchIndexItem> AllItemsList
        {
            get
            {
                if (this.allItemsList == null)
                {
                    this.allItemsList = this.GetListFromSource();
                }

                return this.allItemsList;
            }            
        }
        
        public bool HasData
        {
            get
            {
                return this.AllItemsList != null && this.AllItemsList.Any();
            }
        }

        protected abstract List<ISearchIndexItem> GetListFromSource();

        public virtual ISearchIndexItem GetItemById(int id)
        {
            if (this.HasData)
            {
                return this.AllItemsList.FirstOrDefault(x => x.Id == id);
            }

            return null;
        }

        protected string ContentTagsToTagIdCommaSeparated(string commaSeparatedTags)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(commaSeparatedTags))
            {
                var tags = commaSeparatedTags.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                result = this.ContentTagsToTagIdCommaSeparated(tags);
            }

            return result;
        }

        protected string ContentTagsToTagIdCommaSeparated(IEnumerable<string> tags)
        {
            string result = string.Empty;

            if (tags != null && tags.Any())
            {
                var allTags = this.tagsReader.GetContentTagList();

                IEnumerable<int> validIds = allTags
                    .Where(x => tags.Any(r => string.Equals(x.Description, r, StringComparison.InvariantCultureIgnoreCase)))
                    .Select(x => x.Id);

                if (validIds.Any())
                {
                    result = string.Join(",", validIds);
                }
            }

            return result;
        }
    }
}
