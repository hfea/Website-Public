using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface ICentreImageUpdateClient
    {
        bool UpdateImage(int centreId, string contentMimeType, byte[] data);
    }
}
