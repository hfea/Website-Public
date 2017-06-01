using HFEA.Connector.Contracts.Centre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
   public class BillingDetails
    {
        public int CentreId { get; set; }
        public List<AbsBillingSummary> AbsBillingSummarys { get; set; }
        public List<EntityAdditionalInformation> PurchaseOrderNumbers { get; set; }
    }
}
