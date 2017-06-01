using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    public class PageRatingApiViewModel
    {
        public List<PageRatingStatsItem> Pages { get; set; }
        
        public PaginationModel PaginationData { get; set; }
    }
}
