using HFEA.Web.ViewModel.CaFC.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HFEA.Web.ViewModel.CaFC
{
    public class CaFCFiltersViewModel
    {
        public int? DistanceAsNullableInt
        {
            get
            {
                int? result = null;
                int tmp;
                if (!string.IsNullOrEmpty(this.Distance) 
                    && char.IsDigit(this.Distance[0]) 
                    && int.TryParse(this.Distance, out tmp))
                {
                    result = tmp;
                }

                return result;
            }
        }

        public string Location { get; set; }
               
        public string Distance { get; set; }
        
        public List<DynamicFilter> DynamicFilters { get; set; }

        public List<SelectListItem> DistanceOptionsList { get; set; }
    }
}
