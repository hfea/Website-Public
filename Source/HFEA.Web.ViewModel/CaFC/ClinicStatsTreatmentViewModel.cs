using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public class ClinicStatsTreatmentViewModel
    {
        public List<GenericStatsItem> CancellationBeforeCollectionData { get; set; }
        public List<GenericStatsItem> CancellationBeforeTransferData { get; set; }
        public List<GenericStatsItem> EmbryosTransferredData { get; set; }
    }
}
