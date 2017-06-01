using HFEA.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.PGD
{
    public interface IPgdListingModelCreator
    {
        PgdListingViewModel GetData(int currentPageId, PgdSearchFilters searchParameters);
    }
}
