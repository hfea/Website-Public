using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
    public class DonorGameteWaitingTimes
    {
        public List<DonorWaitingTime> EggDonorWaitingTimes { get; set; }
        public List<DonorWaitingTime> SpermDonorWaitingTimes { get; set; }
        public List<DonorWaitingTime> EmbryoDonorWaitingTimes { get; set; }
    }
}
