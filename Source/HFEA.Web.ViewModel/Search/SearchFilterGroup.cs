using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.Search
{
    public class SelectFilterGroup
    {
        public string GroupTitle { get; set; }

        public List<SelectFilterItem> FilterItemList { get; set; }
    }
}
