using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    public class PageCommentsApiViewModel
    {
        public List<PageCommentsItem> Comments { get; set; }
        
        public PaginationModel PaginationData { get; set; }
    }
}
