using HFEA.Connector.Contracts.COP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.COP
{
    public interface ICOPReaderClient
    {
        COPItem GetAllGroups();

        COPItem GetSection(int sectionId);
    }
}
