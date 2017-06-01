using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class WaitingTimes
    {
        public string White { get; set; }

        public string Black { get; set; }

        public string Asian { get; set; }

        public string Mixed { get; set; }

        public string Other { get; set; }
        public bool HasData { get; set; }
    }
}
