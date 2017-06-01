using HFEA.BL.Contracts.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.SearchProvider.DataSources
{
    public class FullSearchDataSourceProvider : IFullSearchDataSourceProvider
    {
        private readonly ISearchDataSource _copSource;
        private readonly ISearchDataSource _umbracoSource;
        private readonly ISearchDataSource _cafcProfileSource;
        public FullSearchDataSourceProvider(CopSource copSource, UmbracoSource umbracoSource, CaFCProfileSource cafcProfileSource)
        {
            if (copSource == null) throw new ArgumentNullException("search data source copSource is null");
            if (umbracoSource == null) throw new ArgumentNullException("search data source umbracoSource is null");
            if (cafcProfileSource == null) throw new ArgumentNullException("search data source cafcProfileSource is null");
            this._copSource = copSource;
            this._umbracoSource = umbracoSource;
            this._cafcProfileSource = cafcProfileSource;
        }

        public List<ISearchDataSource> AllDataSources
        {
            get
            {
                var list = new List<ISearchDataSource>
                {
                     this._copSource,
                     this._umbracoSource,
                     this._cafcProfileSource
                }
                .ToList();

                return list;
            }
        }
    }
}
