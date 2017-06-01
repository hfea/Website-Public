using HFEA.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.PGD
{
    public class PgdListingViewModel
    {
        public PagedList<PgdItem> ItemList { get; set; }

        public PgdSearchFilters SearchFilters { get; set; }
    }
}
