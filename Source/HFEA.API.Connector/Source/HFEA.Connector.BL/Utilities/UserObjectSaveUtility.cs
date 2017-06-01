using HFEA.Connector.Contracts.Client.Users;
using HFEA.Connector.Contracts.Clients.AccessControl;
using HFEA.Connector.Contracts.Users;
using HFEA.Connector.Contracts.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.Connector.Service.Utilities
{
    public class UserObjectSaveUtility : IUserObjectSaveUtility
    {
        private readonly IUserReader readClient;
        private readonly IClinicUserWriter writeClient;

        public UserObjectSaveUtility(IUserReader readerClient, IClinicUserWriter writerClient)
        {
            if (readerClient == null) throw new ArgumentNullException("client reader is null");
            if (writerClient == null) throw new ArgumentNullException("client writer is null");

            this.readClient = readerClient;
            this.writeClient = writerClient;
        }

        public bool UpdateUser(User user)
        {
            bool result = false;

            if (user != null)
            {
                var apiUser = this.readClient.GetUser(user.Id);

                if (apiUser != null)
                {
                    apiUser.FirstName = user.FirstName;
                    apiUser.LastName = user.LastName;
                    apiUser.EmailAddress = user.EmailAddress;
                    apiUser.DisplayName = string.Format("{0} {1}", user.FirstName, user.LastName);
                    apiUser.IsEnabled = user.IsEnabled;

                    List<SecurityRole> addRoles = new List<SecurityRole>();
                    if (user.Roles != null)
                    {
                        addRoles = user.Roles
                            .Where(x => Constants.UserManagement.ManagedUserRoles.Contains(x.KnownName))
                            .ToList();
                    }

                    if (apiUser.Roles != null)
                    {
                        apiUser.Roles.RemoveAll(x => Constants.UserManagement.ManagedUserRoles.Contains(x.KnownName));
                        apiUser.Roles.AddRange(addRoles);
                    }
                    else
                    {
                        apiUser.Roles = addRoles;
                    }

                    result = this.writeClient.Update(apiUser);
                }
            }

            return result;
        }

        public bool UnlockUser(Guid userId)
        {
            bool result = false;
            var apiUser = this.readClient.GetUser(userId.ToString());

            if (apiUser != null)
            {
                apiUser.IsEnabled = true;
                result = this.writeClient.Update(apiUser);
            }

            return result;
        }
    }
}
