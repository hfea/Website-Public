using HFEA.Connector.Contracts.Clients.Centres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.ClinicProfile;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Service.Clients;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Client.Centres
{
    public class BillingDetailsReaderClient : BaseGetClient,IBillingDetailsReaderClient
    {
        private const ApiType.Billing BillingData = ApiType.Billing.GetBillingDetails;
        private const ApiType.Billing AbsImage = ApiType.Billing.GetFile;

        public BillingDetailsReaderClient(IGetClientFactory factory) : base(factory)
        {

        }

        public BillingDetails GetBillingData(int centreId)
        {
            if (centreId <= 0)
            {
                throw new ArgumentOutOfRangeException("Centre id is not valid.");
            }
            var parameters = new NameValueCollection();
            parameters.Add(ApiParams.Id, centreId.ToString());
            return this.Factory.GetApiClient(BillingData).ExecuteRequest<BillingDetails>(parameters, null);
             //return this.Factory.GetApiClient(BillingData).ExecuteRequest<BillingDetails>();
        }

        public AbsBillingImage GetFileData(int docId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(ApiParams.Id, docId.ToString());
            var result = this.Factory.GetApiClient(AbsImage).ExecuteRequest<AbsBillingImage>(parameters, null);

            return result;
        }
    }
}
