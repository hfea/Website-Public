using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
    public class OpeningTime
    {
        public bool IsOpened { get; set; }
        public int Day { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
    }
}
