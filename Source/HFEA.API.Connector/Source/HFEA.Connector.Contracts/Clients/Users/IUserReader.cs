using HFEA.Connector.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Client.Users
{
    public interface IUserReader
    {
        List<User> GetAllUserList();

        User GetUser(string userId);

        User GetMe();

        string GetCentreName(int CentreId);
    }
}
