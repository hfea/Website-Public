using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.ReferenceData;
using HFEA.Connector.Service.Constants;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using HFEA.Connector.Contracts.ReferenceData;
using System;
using HFEA.Connector.Contracts.CommonObjects;

namespace HFEA.Connector.Service.Clients.ReferenceData
{
    public class ReferenceDataReader : BaseGetClient, IReferenceDataReader
    {
        public ReferenceDataReader(IGetClientFactory client) : base(client)
        {
        }

        public virtual Document GetDocument(int id)
        {
            var param = this.GetIdParameter(id);

            return this.Factory.GetApiClient(ApiType.ReferenceData.GetDocument)
                .ExecuteRequest<Document>(param, null);
        }

        public virtual List<ListingDataItem> GetCeoLettersData()
        {
            return this.Factory.GetApiClient(ApiType.ReferenceData.GetCeoLetters)
                .ExecuteRequest<List<ListingDataItem>>();
        }

        public virtual List<ListingDataItem> GetCeoLettersData(int year)
        {
            var param = this.GetYearParameter(year);

            return this.Factory.GetApiClient(ApiType.ReferenceData.GetCeoLettersByYear)
                .ExecuteRequest<List<ListingDataItem>>(param, null);
        }

        public virtual List<ListingDataItem> GetChairLettersData()
        {
            return this.Factory.GetApiClient(ApiType.ReferenceData.GetChairLetters)
                .ExecuteRequest<List<ListingDataItem>>();
        }

        public virtual List<ListingDataItem> GetChairLettersData(int year)
        {
            var param = this.GetYearParameter(year);
            return this.Factory.GetApiClient(ApiType.ReferenceData.GetChairLettersByYear)
                .ExecuteRequest<List<ListingDataItem>>(param, null);
        }

        public virtual ReferenceDataContainer GetDirectionsData()
        {
            return this.Factory.GetApiClient(ApiType.ReferenceData.GetDirections)
                .ExecuteRequest<ReferenceDataContainer>();
        }

        public virtual List<LicenceConditionsData> GetLicenseConditionsData()
        {
            return this.Factory.GetApiClient(ApiType.ReferenceData.GetLicenceConditionsResearch)
                .ExecuteRequest<List<LicenceConditionsData>>();
        }

        public virtual List<LicenceConditionsData> GetLicenseConditionTreatmentStorageData()
        {
            return this.Factory.GetApiClient(ApiType.ReferenceData.GetLicenceConditionsTreatmentStorage)
               .ExecuteRequest<List<LicenceConditionsData>>();
        }

        public virtual List<RegulatoryPrincipleItem> GetRegulatoryPrincipleData()
        {
            return this.Factory.GetApiClient(ApiType.ReferenceData.GetRegulatoryPrinciples)
               .ExecuteRequest<List<RegulatoryPrincipleItem>>();
        }

        public virtual List<IdNameDescription> GetPgdConditionsData()
        {
            return this.Factory.GetApiClient(ApiType.ReferenceData.GetPgdConditions)
               .ExecuteRequest<List<IdNameDescription>>();
        }

        protected NameValueCollection GetYearParameter(int year)
        {
            var result = new NameValueCollection();
            result.Add(ApiParams.Year, year.ToString());

            return result;
        }

        protected NameValueCollection GetIdParameter(int id)
        {
            var param = new NameValueCollection();
            param.Add(ApiParams.Id, id.ToString());

            return param;
        }

        public List<ListingDataItem> GetAlertsData()
        {
            return this.Factory.GetApiClient(ApiType.ReferenceData.GetAlerts)
               .ExecuteRequest<List<ListingDataItem>>();
        }
    }
}
