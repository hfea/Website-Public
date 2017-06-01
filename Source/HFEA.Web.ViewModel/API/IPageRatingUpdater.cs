using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    public interface IPageRatingUpdater
    {
        bool AddUpdatePageRating(int pageId, int rating, string identifier);
    }
}
