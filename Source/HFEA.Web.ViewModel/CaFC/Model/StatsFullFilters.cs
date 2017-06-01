using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class StatsFullFilters : StatsApiSearchFilters
    {
        public CaFCConstants.StatsTreatmentType TreatmentType { get; set; }
    }
}
