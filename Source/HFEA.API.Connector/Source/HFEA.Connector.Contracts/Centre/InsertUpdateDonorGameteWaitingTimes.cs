using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Centre
{
    public class InsertUpdateDonorGameteWaitingTimes
    {
        public int EthnicGroupLookupId { get; set; }
        public int SpermDonorWaitingTimeLookupId { get; set; }
        public int EggDonorWaitingTimeLookupId { get; set; }
        public int EmbryoDonorWaitingTimeLookupId { get; set; }
    }
}
