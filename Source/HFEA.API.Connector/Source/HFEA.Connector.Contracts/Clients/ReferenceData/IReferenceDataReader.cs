using HFEA.Connector.Contracts.CommonObjects;
using HFEA.Connector.Contracts.ReferenceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.ReferenceData
{
    public interface IReferenceDataReader
    {
        ReferenceDataContainer GetDirectionsData();

        List<ListingDataItem> GetCeoLettersData();

        List<ListingDataItem> GetCeoLettersData(int year);

        List<ListingDataItem> GetChairLettersData();

        List<ListingDataItem> GetChairLettersData(int year);

        List<LicenceConditionsData> GetLicenseConditionsData();
        List<LicenceConditionsData> GetLicenseConditionTreatmentStorageData();
        List<RegulatoryPrincipleItem> GetRegulatoryPrincipleData();
        List<ListingDataItem> GetAlertsData();
        List<IdNameDescription> GetPgdConditionsData();
        Document GetDocument(int id);
    }
}