using HFEA.Connector.Contracts.Users;
using System;

namespace HFEA.Connector.Contracts.Utilities
{
    public interface IUserObjectSaveUtility
    {
        bool UpdateUser(User user);

        bool UnlockUser(Guid userId);
    }
}