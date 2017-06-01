using HFEA.Connector.Contracts.Centre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface ILicenceReader
    {
        Task<Licence> GetLicence(int clinicId, int licenceId);

        Task<List<Licence>> GetCenterLicenceList(int clinicId);
    }
}
