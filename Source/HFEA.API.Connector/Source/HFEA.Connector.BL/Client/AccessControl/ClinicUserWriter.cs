using HFEA.Connector.Contracts.Clients.AccessControl;
using HFEA.Connector.Global;
using HFEA.Connector.Contracts.Users;
using HFEA.Connector.Service.BaseClient;
using System;

namespace HFEA.Connector.Service.Clients.AccessControl
{
    public class ClinicUserWriter : BaseSdkClient, IClinicUserWriter
    {
        public ClinicUserWriter(ITokenResolver tokenResolver, IHfeaLogger logger) : base(tokenResolver, logger)
        {
        }

        public bool Create(User user, out string userId)
        {
            userId = string.Empty;
            bool result = false;
            try
            {
                var mappedUser = this.GetSdkUserObject(user);
                mappedUser = this.ApiClient.CreateUser(mappedUser);

                result = !string.IsNullOrEmpty(mappedUser.Id);
                userId = mappedUser.Id;
            }
            catch(Exception ex)
            {
                this.Log.Error("cannot create user", ex);                
            }

            return result;
        }

        public bool Update(User user)
        {
            bool result = false;

            try
            {
                var mapped = this.GetSdkUserObject(user);
                this.ApiClient.UpdateUser(mapped);

                result = true;
            }
            catch(Exception ex)
            {
                Log.Error("Cannot update user", ex);
            }

            return result;
        }

        public bool Delete(Guid userId)
        {
            bool result = false;

            try
            {
                this.ApiClient.DeleteUser(userId.ToString());
                result = true;
            }
            catch (Exception ex)
            {
                Log.Error("Cannot delete user", ex);
            }

            return result;
        }

        public bool ResetPassword(Guid userId)
        {
            throw new NotImplementedException();
        }

        public bool Unlock(Guid userId)
        {
            throw new NotImplementedException();
        }

        private SDK.Model.User GetSdkUserObject(User user)
        {
            return AutoMapper.Mapper.Map<SDK.Model.User>(user);
        }
    }
}
