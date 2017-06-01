using HFEA.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    public interface IPageRatingUtility
    {
        PageRatingApiViewModel GetRatingsData(int page, int pageSize, bool mostPopularFirst);
        bool DeletePageRatings(int pageId);        
    }
}
