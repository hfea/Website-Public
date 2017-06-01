using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Service.Constants;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System;

namespace HFEA.Connector.Service.Clients.CaFC
{
    public class ProfileClient : BaseGetClient, ICaFCProfileClient
    {
        public ProfileClient(IGetClientFactory client) : base(client)
        {
        }

        public virtual ClinicProfile GetClinicProfile(int clinicId)
        {

            var parameters = this.GetParams(clinicId);
            try
            {
                var rtn = Factory.GetApiClient(ApiType.Centre.GetCaFCCentreDetails).ExecuteRequest<ClinicProfile>(parameters, null);

                return rtn;
            }
            catch {               
                return null;
            }
        }
        
        protected NameValueCollection GetParams(int clinicId)
        {
            var result = new NameValueCollection();
            result.Add(ApiParams.Id, clinicId.ToString());

            return result;
        }
    }
}
