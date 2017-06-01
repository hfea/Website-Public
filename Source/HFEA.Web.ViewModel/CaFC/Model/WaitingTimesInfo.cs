using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class WaitingTimesInfo
    {
        public WaitingTimes EggDonors { get; set; }

        public WaitingTimes SpermDonors { get; set; }

        public WaitingTimes EmbryoDonors { get; set; }

        public List<string> DonorSource { get; set; }
        public bool HasData { get; set; }
    }
}
