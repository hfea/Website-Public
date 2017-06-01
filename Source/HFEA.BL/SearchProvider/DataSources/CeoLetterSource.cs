using HFEA.Connector.Contracts.Clients.ReferenceData;
using HFEA.BL.Contracts.Search;
using HFEA.Web.ViewModel.Constants;
using HFEA.Web.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SearchSource = HFEA.BL.Contracts.Constants.Search.SearchSource;


namespace HFEA.BL.SearchProvider.DataSources
{
    public class CeoLetterSource : ReferenceLetterSourceBase
    {
        private readonly IReferenceDataReader dataReader;
        private readonly IReferenceDataUrlResolver urlResolver;

        public CeoLetterSource(IReferenceDataReader refDataReader, IReferenceDataUrlResolver refUrlResolver) : base(SearchSource.CeoLetter)
        {
            if (refDataReader == null) throw new ArgumentNullException("Reference data reader is null");
            if (refUrlResolver == null) throw new ArgumentNullException("Url resolver is null");

            this.dataReader = refDataReader;
            this.urlResolver = refUrlResolver;
        }
        
        protected override List<ISearchIndexItem> GetListFromSource()
        {
            var rawData = this.dataReader.GetCeoLettersData();
            List<ISearchIndexItem> result = this.MapRawDataToSeachIndexList(rawData, this.urlResolver.GetCeoLetterUrl);

            return result;
        }
    }
}
