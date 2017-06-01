using HFEA.Connector.Contracts.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface IMonitoringDashboardReader
    {
        Monitoring GetMonitoringItemsByClinicId(int clinicId);
        List<TaskItem> GetClinicTasksByType(int clinicId, Constants.Centre.MonitoringItemType type);
    }
}
