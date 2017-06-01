using System.Collections.Generic;

using KnownRole = HFEA.Connector.Contracts.Constants.Security.KnownRole;

namespace HFEA.Connector.Service.Constants
{
    public class UserManagement
    {
        private static List<KnownRole> managedUserRoles = new List<KnownRole>()
        {
            KnownRole.Finance, KnownRole.EdiDataEntry, KnownRole.User, KnownRole.UserAdmin
        };

        public static List<KnownRole> ManagedUserRoles { get { return managedUserRoles; } }
    }
}
