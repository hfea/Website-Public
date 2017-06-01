using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class LinkItem
    {
        public CaFCConstants.ClinicType Type { get; set; }

        public int ClinicId { get; set; }

        public string ClinicName { get; set; }

        public string Url { get; set; }
    }
}
