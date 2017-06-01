using HFEA.Connector.Service.Constants;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System;
using HFEA.Connector.Service.Clients;
using static HFEA.Connector.Service.Constants.ApiType;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.RiskPerformanceClient;
using HFEA.Connector.Contracts.RiskPerformance;

namespace HFEA.Connector.Service.Client.RiskPerformanceClient
{
    public class RiskPerformanceClient : BaseGetClient, IRiskPerformanceClient
    {
        public RiskPerformanceClient(IGetClientFactory factory) : base(factory) { }

        public List<GPIPerformanceDataItems> GetGPIPerformanceData()
        {
            var report = this.Factory.GetApiClient(ApiType.RiskPerformance.GPIPerformanceData).ExecuteRequest<List<GPIPerformanceDataItems>>();
            return report;
        }

        public PerformanceGPIChartModel GetGPIPerformanceChartData(int performanceId)
        {
            var apiParameter = new NameValueCollection();
            apiParameter.Add(ApiParams.Id, performanceId.ToString());

            var result = this.Factory.GetApiClient(ApiType.RiskPerformance.GPIPerformanceDataChart).ExecuteRequest<PerformanceGPIChartModel>(apiParameter, null);
            return result;
        }

        public List<KRIPerformanceDataItems> GetKRIPerformanceData()
        {
            var report = this.Factory.GetApiClient(ApiType.RiskPerformance.KRIPerformanceData).ExecuteRequest<List<KRIPerformanceDataItems>>();
            return report;
        }

        public List<PerformanceKRISectionModel> GetKRIPerformanceDetails(string clinicId)
        {
            var apiParameter = new NameValueCollection();
            apiParameter.Add(ApiParams.Id, clinicId.ToString());
            var report = this.Factory.GetApiClient(ApiType.RiskPerformance.KRIPerformanceDataDetails).ExecuteRequest<List<PerformanceKRISectionModel>>(apiParameter, null);
            return report;
        }
    }
}
