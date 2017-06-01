using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class StatsApiSearchFilters
    {
        public int ClinicId { get; set; }

        public IdValuePair Year { get; set; }

        public IdValuePair Treatment { get; set; }

        public IdValuePair Age { get; set; }

        public IdValuePair Source { get; set; }
    }
}
