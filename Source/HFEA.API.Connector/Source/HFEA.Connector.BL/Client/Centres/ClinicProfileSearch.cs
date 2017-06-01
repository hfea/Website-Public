using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Service.Constants;
using System.Collections.Specialized;
using HFEA.Connector.Contracts.ClinicProfile;
using HFEA.Connector.Contracts.Clients.Centres;

namespace HFEA.Connector.Service.Clients.Centres
{
    public class ClinicProfileSearch : BaseGetClient, IClinicProfileSearch
    {
        public ClinicProfileSearch(IGetClientFactory client) : base(client)
        {
        }

        public Clinic GetClinicProfile(int clinicId)
        {
            var parameter = new NameValueCollection();
            parameter.Add(ApiParams.Id, clinicId.ToString());

            return Factory.GetApiClient(ApiType.Centre.GetPortalCentreDetails).ExecuteRequest<Clinic>(parameter, null);
        }
    }
}
