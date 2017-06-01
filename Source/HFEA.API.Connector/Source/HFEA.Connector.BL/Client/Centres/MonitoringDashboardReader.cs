using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.Centres;
using HFEA.Connector.Contracts.Constants;
using HFEA.Connector.Contracts.Tasks;
using HFEA.Connector.Service.Clients;
using HFEA.Connector.Service.Constants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Client.Centres
{
    public class MonitoringDashboardReader : BaseGetClient, IMonitoringDashboardReader
    {
        public MonitoringDashboardReader(IGetClientFactory client) : base(client)
        {
        }

        public List<TaskItem> GetClinicTasksByType(int clinicId, Centre.MonitoringItemType type)
        {
            var parameter = new NameValueCollection();
            parameter.Add(ApiParams.Id, clinicId.ToString());            
            parameter.Add(ApiParams.Type, type.ToString());
            return Factory.GetApiClient(ApiType.Centre.GetClinicTaskListByType).ExecuteRequest<List<TaskItem>>(parameter, null);
        }

        public Monitoring GetMonitoringItemsByClinicId(int clinicId)
        {
            var parameter = new NameValueCollection();
            parameter.Add(ApiParams.Id, clinicId.ToString());
            return Factory.GetApiClient(ApiType.Centre.GetPortalMonitoringDashboard).ExecuteRequest<Monitoring>(parameter, null);
        }
    }
}
