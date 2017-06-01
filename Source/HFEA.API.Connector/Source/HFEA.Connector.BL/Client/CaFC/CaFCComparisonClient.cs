using HFEA.Connector.Contracts.CaFC.Comparison;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Service.Constants;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace HFEA.Connector.Service.Clients.CaFC
{
    public class CaFCComparisonClient : BaseGetClient, ICaFCComparisonClient
    {
        public CaFCComparisonClient(IGetClientFactory factory) : base(factory) { }

        public List<ComparisonClinicInfo> GetComparisonData(params int[] clinicIds)
        {
            if (clinicIds != null && clinicIds.Any())
            {
                var qry = new NameValueCollection();
                var concat = "id=" + string.Join("&id=", clinicIds);
                qry.Add(ApiParams.Id, concat);

                return this.Factory.GetApiClient(ApiType.Centre.GetClinicComparisonStats).ExecuteRequest<List<ComparisonClinicInfo>>(qry, null);
            }

            return null;   
        }
    }
}
