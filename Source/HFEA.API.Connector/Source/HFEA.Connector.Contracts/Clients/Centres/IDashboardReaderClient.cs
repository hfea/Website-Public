using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.CentreDashboard;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface IDashboardReaderClient
    {
        Dashboard GetCentreDashboard(int centreId);
    }
}
