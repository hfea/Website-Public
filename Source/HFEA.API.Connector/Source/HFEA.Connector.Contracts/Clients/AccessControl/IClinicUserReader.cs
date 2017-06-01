using HFEA.Connector.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.AccessControl
{
    public interface IClinicUserReader
    {
        List<User> GetClinicUserList(int clinicId);
    }
}
