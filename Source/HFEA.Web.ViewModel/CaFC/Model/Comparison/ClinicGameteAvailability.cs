using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model.Comparison
{
    public class ClinicGameteAvailability
    {
        public GameteAvailabilityStats White { get; set; }

        public GameteAvailabilityStats Black { get; set; }

        public GameteAvailabilityStats Asian { get; set; }

        public GameteAvailabilityStats Mixed { get; set; }

        public GameteAvailabilityStats Other { get; set; }
    }
}
