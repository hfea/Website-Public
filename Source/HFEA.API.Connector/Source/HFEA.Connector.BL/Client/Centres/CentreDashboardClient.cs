using HFEA.Connector.Contracts.CentreDashboard;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.Centres;
using HFEA.Connector.Service.Clients;
using HFEA.Connector.Service.Constants;
using System;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Client.Centres
{
    public class CentreDashboardClient : BaseGetClient, IDashboardReaderClient
    {
        private const ApiType.Centre GetDashboardData = ApiType.Centre.GetPortalDashboard;

        public CentreDashboardClient(IGetClientFactory factory) : base(factory)
        {
        }

        public Dashboard GetCentreDashboard(int centreId)
        {
            if (centreId <= 0)
            {
                throw new ArgumentOutOfRangeException("Centre id is not valid.");
            }

            var parameters = new NameValueCollection();
            parameters.Add(ApiParams.Id, centreId.ToString());

            return this.Factory.GetApiClient(GetDashboardData).ExecuteRequest<Dashboard>(parameters, null);          
        }
    }
}
