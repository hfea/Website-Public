using HFEA.Connector.Contracts.Clients.ReferenceData;
using HFEA.Connector.Contracts.ReferenceData;
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
    public class LicenceResearchSource : BaseLicenseSource
    {
        private const int Id = 0;
        private const string Title = "Research licence conditions";
        private readonly IReferenceDataReader dataReader;
        private readonly IReferenceDataUrlResolver urlResolver;

        public LicenceResearchSource(IReferenceDataReader refDataReader, IReferenceDataUrlResolver refUrlResolver) : base(SearchSource.LicenceResearch)
        {
            if (refDataReader == null) throw new ArgumentNullException("Reference data reader is null");
            if (refUrlResolver == null) throw new ArgumentNullException("Url resolver is null");

            this.dataReader = refDataReader;
            this.urlResolver = refUrlResolver;
        }

        protected override List<ISearchIndexItem> GetListFromSource()
        {
            List<ISearchIndexItem> result = new List<ISearchIndexItem>();
            List<LicenceConditionsData> rawData = this.dataReader.GetLicenseConditionsData();

            var item = this.GetResultItem(
                rawData,
                Id,
                Title
                );

            result.Add(item);

            return result;
        }
    }
}
