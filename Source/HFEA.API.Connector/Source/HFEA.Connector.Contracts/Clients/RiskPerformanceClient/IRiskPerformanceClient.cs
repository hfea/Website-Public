using HFEA.Connector.Contracts.RiskPerformance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.RiskPerformanceClient
{
    public interface IRiskPerformanceClient
    {
        List<GPIPerformanceDataItems> GetGPIPerformanceData();
        PerformanceGPIChartModel GetGPIPerformanceChartData(int performanceId);
        List<KRIPerformanceDataItems> GetKRIPerformanceData();
        List<PerformanceKRISectionModel> GetKRIPerformanceDetails(string performanceId);
        //List<GPIMonths> GetGPIPerformanceChartMonths(int performanceId);
    }
}
