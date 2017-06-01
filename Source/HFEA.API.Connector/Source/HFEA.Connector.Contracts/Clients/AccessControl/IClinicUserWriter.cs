using System;
using HFEA.Connector.Contracts.Users;

namespace HFEA.Connector.Contracts.Clients.AccessControl
{
    public interface IClinicUserWriter
    {
        bool Create(User user, out string userId);
        bool Delete(Guid userId);
        bool ResetPassword(Guid userId);
        bool Update(User user);
    }
}