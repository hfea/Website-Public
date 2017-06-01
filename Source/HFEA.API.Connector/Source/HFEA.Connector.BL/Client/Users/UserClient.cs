using HFEA.Connector.Contracts.Client.Users;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Users;
using HFEA.Connector.Service.Constants;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System;
using HFEA.Connector.Contracts.ClinicProfile;

namespace HFEA.Connector.Service.Clients.Users
{
    public class UserClient : BaseGetClient, IUserReader
    {
        private const ApiType.Security AllUsers = ApiType.Security.GetUserList;
        private const ApiType.Security GetUserInfo = ApiType.Security.GetUserInfo;
        private const ApiType.Security GetMeInfo = ApiType.Security.GetMe;
        private const ApiType.Centre GetCentreInfo = ApiType.Centre.GetPortalCentreDetails;

        public UserClient(IGetClientFactory factory) : base(factory)
        {
        }

        public List<User> GetAllUserList()
        {
            return this.Factory.GetApiClient(AllUsers).ExecuteRequest<List<User>>();
        }

        /// <summary>
        /// This is a temporary method for getting user object. There will be an API which gets user by email/login
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public User GetUserByEmail(string email)
        {
            User result = null;
            var allUsers = this.GetAllUserList();

            if (allUsers != null)
            {
                result = allUsers.Where(x => x.PrincipalName == email).FirstOrDefault();
            }

            return result;
        }

        public User GetUser(string userId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(ApiParams.Id, userId);

            var user = this.Factory.GetApiClient(GetUserInfo).ExecuteRequest<User>(parameters, null);
            // Mapping of user role fiels. As of 05/2016 the API works with 2 different 
            // properties: Name and KnownName. Here we sync them to be same
            if (user != null && user.Roles.Any())
            {
#pragma warning disable 618
                for (int i = 0; i < user.Roles.Count; i++)
                {
                    if (user.Roles[i].KnownName == Contracts.Constants.Security.KnownRole.Unknown)
                    {
                        user.Roles[i].KnownName = user.Roles[i].Name;
                    }
                }
#pragma warning restore 618
            }
            return user;
        }

        public User GetMe()
        {
            var cl = this.Factory.GetApiClient(GetMeInfo);
            return cl.ExecuteRequest<User>(null, null);
        }

        public string GetCentreName(int centreId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(ApiParams.Id, centreId.ToString());
            var clinic = this.Factory.GetApiClient(GetCentreInfo).ExecuteRequest<Clinic>(parameters, null);
            return clinic.CentreName;
        }
    }
}
