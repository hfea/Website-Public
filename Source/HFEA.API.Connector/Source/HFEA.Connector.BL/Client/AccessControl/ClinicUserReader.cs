using AutoMapper;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.AccessControl;
using HFEA.Connector.Global;
using HFEA.Connector.Contracts.Users;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.Constants;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Clients.AccessControl
{
    public class ClinicUserReader : BaseSdkClient, IClinicUserReader
    {
        public ClinicUserReader(ITokenResolver tokenResolver, IHfeaLogger logger) : base(tokenResolver, logger)
        {
        }

        public List<User> GetClinicUserList(int clinicId)
        {
            if (clinicId <= 0) { throw new ArgumentOutOfRangeException("Clinic ID value is invalid"); }

            var users = this.ApiClient.GetCentreUsers(clinicId.ToString(), 0, int.MaxValue);
            List<User> result = Mapper.Map<List<User>>(users);
           
            return result; 
        }
    }
}
