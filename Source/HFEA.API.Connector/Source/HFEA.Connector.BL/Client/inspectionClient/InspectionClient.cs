using HFEA.Connector.Service.Constants;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System;
using HFEA.Connector.Service.Clients;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.InspectionClient;
using HFEA.Connector.Contracts.Inspection;
using static HFEA.Connector.Service.Constants.ApiType;
using Newtonsoft.Json;
using HFEA.Connector.Contracts.CaFC;

namespace HFEA.Connector.Service.Client.InspectionClient
{
    public class InspectionClient : BaseGetClient, IInspectionClient
    {
        public InspectionClient(IGetClientFactory factory) : base(factory) { }

        public InspectionReport GetInspectionReport(int clinicId)
        {
            var apiParameter = new NameValueCollection();
            apiParameter.Add(ApiParams.Id, clinicId.ToString());
            var report = this.Factory.GetApiClient(ApiType.Inspection.TreatmentInspectionReports).ExecuteRequest<InspectionReport>(apiParameter, null);
            return report;
        }
        public InspectorDetails GetInspectorDetails(int clinicId)
        {
            var apiParameter = new NameValueCollection();
            apiParameter.Add(ApiParams.Id, clinicId.ToString());
            var report = this.Factory.GetApiClient(ApiType.Inspection.TreatmentInspectionReports)
                .ExecuteRequest<InspectorDetails>(apiParameter, null);
            InspectorDetails inspector = new InspectorDetails();
            return report;
        }
        public LCELPMinutes GetLCELPMinutes(int clinicId)
        {
            var apiParameter = new NameValueCollection();
            apiParameter.Add(ApiParams.Id, clinicId.ToString());
            var TreatmentReport = this.Factory.GetApiClient(ApiType.Inspection.TreatmentInspectionReports)
                .ExecuteRequest<LCELPMinutes>(apiParameter, null);
            return TreatmentReport;
        }

        public InspectionRatingModel GetInspectionRating(int clinicId)
        {
            var apiParameter = new NameValueCollection();
            apiParameter.Add(ApiParams.Id, clinicId.ToString());
            var InspectionRating = this.Factory.GetApiClient(ApiType.Inspection.TreatmentInspectionReports)
                .ExecuteRequest<InspectionRatingModel>(apiParameter, null);
            return InspectionRating;
        }
    }
}
