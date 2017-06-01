using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
    public class DonorWaitingTime
    {
        public string EthnicGroupId { get; set; }
        public string EthnicGroupDescription { get; set; }
        public string WaitingTimeId { get; set; }
        public string WaitingTimeDescription { get; set; }
    }
}
