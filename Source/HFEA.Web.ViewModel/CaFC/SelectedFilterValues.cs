using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public class SelectedFilterValues
    {
        public SelectedFilterValues()
        {
            this.DynamicIds = new List<int>();
        }

        public string Location { get; set; }

        public int Distance { get; set; }

        public List<int> DynamicIds { get; set; }
    }
}
