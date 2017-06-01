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
    public class ClinicStatsGenericViewModel
    {
        public List<GenericStatsItem> TopRowDataList { get; set; }
        public GenericStatsItem EmbryoTransferredAverage { get; set; }
        public List<GenericStatsItem> ChartData { get; set; }
    }
}
