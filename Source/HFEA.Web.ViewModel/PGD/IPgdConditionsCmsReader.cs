using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.PGD
{
    public interface IPgdConditionsCmsReader
    {
        List<PgdItem> GetAllConditionByListingPageId(int listingPageId);
    }
}
