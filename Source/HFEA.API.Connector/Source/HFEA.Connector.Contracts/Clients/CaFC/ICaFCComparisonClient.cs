using HFEA.Connector.Contracts.CaFC.Comparison;
using System.Collections.Generic;

namespace HFEA.Connector.Contracts.Clients.CaFC
{ 
    public interface ICaFCComparisonClient
    {
        List<ComparisonClinicInfo> GetComparisonData(params int[] clinicId);
    }
}