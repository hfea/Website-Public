using HFEA.Connector.Contracts.ClinicProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface IBillingDetailsReaderClient
    {
        BillingDetails GetBillingData(int centreId);

        AbsBillingImage GetFileData(int docId);
    }
}
