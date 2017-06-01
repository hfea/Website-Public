using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class DynamicFilter
    {
        public CaFCConstants.DynamicFilterType Type { get; set; }

        public string Title { get; set; }

        public List<FilterItem<bool>> ItemList { get; set; }
    }
}
