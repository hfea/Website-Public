using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile.PostUpdateModel
{
    public class UpdateAddressEntity
    {
        public string AddressType { get; set; }
        public string SubDwelling { get; set; }
        public string NumberName { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string Postcode { get; set; }
    }
}
