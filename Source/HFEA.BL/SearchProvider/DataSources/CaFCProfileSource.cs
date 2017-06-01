using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.BL.Contracts.Constants;
using HFEA.BL.Contracts.Search;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Contracts.Clients.AccessControl;

namespace HFEA.BL.SearchProvider.DataSources
{
    public class CaFCProfileSource : BaseSearchDataSource
    {
        private readonly ICafcProfileUrlHelper clinicProfileUrlResolver;
        private readonly ICaFCSearch clinicProfileSearch;
        public CaFCProfileSource(ICaFCSearch searchDataReader, ICafcProfileUrlHelper urlResolver, ITagsReader tagsSource) : base(Search.SearchSource.Clinic, tagsSource)
        {
            if (urlResolver == null) throw new ArgumentNullException("CaFC url resolver is null");
            if (searchDataReader == null) throw new ArgumentNullException("CaFC search client is null");
            this.clinicProfileUrlResolver = urlResolver;
            this.clinicProfileSearch = searchDataReader;
        }

        protected override List<ISearchIndexItem> GetListFromSource()
        {
            List<ISearchIndexItem> result = new List<ISearchIndexItem>();
            var allClinics = clinicProfileSearch.GetAllSearchClinicList();
            if (allClinics != null && allClinics.Any())
            {
                List<int> CaFCProfileIdList = allClinics.Select(x => x.Id).ToList();
                foreach (var item in allClinics)
                {
                    result.Add(new SearchIndexItem()
                    {
                        Id = item.Id,
                        Title = item.CentreName,
                        Summary = item.ProfileText,
                        SourceType = this.SourceType
                    });
                }
            }
            return result;
        }
    }
}
