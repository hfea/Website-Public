using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.CommonObjects;
using HFEA.Connector.Contracts.ReferenceData;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.Extensions;
using System;
using System.Collections.Generic;

namespace HFEA.Connector.Service.Clients.ReferenceData
{
    public class ReferenceDataReaderCachedAdaptor : ReferenceDataReader
    { 
        private readonly IContentCacheService cacher;
        
        public ReferenceDataReaderCachedAdaptor(IGetClientFactory factory, IContentCacheService cacheProvider) : base(factory)
        {
            if (cacheProvider == null) throw new ArgumentNullException("Tags reader cache provider is null");
            this.cacher = cacheProvider;
        }

        public override Document GetDocument(int id)
        {
            var parameters = this.GetIdParameter(id);
            string key = Helpers.UrlHelper.GetUrlWithParameters(
                ApiType.ReferenceData.GetDocument.GetDescription(), 
                parameters, 
                null);

            Func<Document> client = () => base.GetDocument(id);

            return this.cacher.GetResultsOrSetCache<Document>(key, client);
        }

        public override List<ListingDataItem> GetCeoLettersData()
        {
            Func<List<ListingDataItem>> client = () => base.GetCeoLettersData();
            string key = ApiType.ReferenceData.GetCeoLetters.GetDescription();

            return this.cacher.GetResultsOrSetCache<List<ListingDataItem>>(key, client);
        }

        public override List<ListingDataItem> GetCeoLettersData(int year)
        {
            var param = this.GetYearParameter(year);
            string key = Helpers.UrlHelper.GetUrlWithParameters(
                ApiType.ReferenceData.GetCeoLettersByYear.GetDescription(),
                param,
                null);

            Func<List<ListingDataItem>> client = () => base.GetCeoLettersData(year);

            return this.cacher.GetResultsOrSetCache<List<ListingDataItem>>(key, client);
        }

        public override List<ListingDataItem> GetChairLettersData()
        {
            Func<List<ListingDataItem>> client = () => base.GetChairLettersData();
            string key = ApiType.ReferenceData.GetChairLetters.GetDescription();

            return this.cacher.GetResultsOrSetCache<List<ListingDataItem>>(key, client);
        }

        public override List<ListingDataItem> GetChairLettersData(int year)
        {
            var param = this.GetYearParameter(year);
            string key = Helpers.UrlHelper.GetUrlWithParameters(
                ApiType.ReferenceData.GetChairLettersByYear.GetDescription(),
                param,
                null);

            Func<List<ListingDataItem>> client = () => base.GetChairLettersData(year);

            return this.cacher.GetResultsOrSetCache<List<ListingDataItem>>(key, client);
        }

        public override ReferenceDataContainer GetDirectionsData()
        {
            Func<ReferenceDataContainer> client = () => base.GetDirectionsData();
            string key = ApiType.ReferenceData.GetDirections.GetDescription();

            return this.cacher.GetResultsOrSetCache<ReferenceDataContainer>(key, client);
        }

        public override List<LicenceConditionsData> GetLicenseConditionsData()
        {
            Func<List<LicenceConditionsData>> client = () => base.GetLicenseConditionsData();
            string key = ApiType.ReferenceData.GetLicenceConditionsResearch.GetDescription();

            return this.cacher.GetResultsOrSetCache<List<LicenceConditionsData>>(key, client);
        }

        public override List<LicenceConditionsData> GetLicenseConditionTreatmentStorageData()
        {
            Func<List<LicenceConditionsData>> client = () => base.GetLicenseConditionTreatmentStorageData();
            string key = ApiType.ReferenceData.GetLicenceConditionsTreatmentStorage.GetDescription();

            return this.cacher.GetResultsOrSetCache<List<LicenceConditionsData>>(key, client);
        }

        public override List<RegulatoryPrincipleItem> GetRegulatoryPrincipleData()
        {
            Func<List<RegulatoryPrincipleItem>> client = () => base.GetRegulatoryPrincipleData();
            string key = ApiType.ReferenceData.GetRegulatoryPrinciples.GetDescription();

            return this.cacher.GetResultsOrSetCache<List<RegulatoryPrincipleItem>>(key, client);
        }

        public override List<IdNameDescription> GetPgdConditionsData()
        {
            Func<List<IdNameDescription>> client = () => base.GetPgdConditionsData();
            string key = ApiType.ReferenceData.GetPgdConditions.GetDescription();

            return this.cacher.GetResultsOrSetCache<List<IdNameDescription>>(key, client);
        }
    }
}