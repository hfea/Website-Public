using HFEA.Connector.Contracts.Centre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface IClinicProfileReader
    {
        CentrePortal GetCentrePortalData(int centreId);
    }
}
