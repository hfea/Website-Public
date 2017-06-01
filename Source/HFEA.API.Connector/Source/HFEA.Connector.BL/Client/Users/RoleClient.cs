using HFEA.Connector.Contracts.Client.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.Users;
using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Contracts.ClientFactories;

namespace HFEA.Connector.Service.Clients.Users
{
    public class RoleClient : BaseGetClient, IRoleReader
    {
        private const ApiType.Security AllRoles = ApiType.Security.GetRoleList;

        public RoleClient(IGetClientFactory client) : base (client)
        {
        }

        public List<SecurityRole> GetAllRoles()
        {
            var client = this.Factory.GetApiClient(AllRoles);                
            return client.ExecuteRequest<List<SecurityRole>>();
        }
    }
}
