using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class ClinicService
    {
        public CaFCConstants.ClinicServiceType ServiceType { get; set; }

        public string CmsFieldAlias { get; set; }

        public List<ServiceList> ServiceList { get; set; }
    }
}
