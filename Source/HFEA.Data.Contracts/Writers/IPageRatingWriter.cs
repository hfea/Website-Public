using HFEA.Data.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Contracts.Writers
{
    public interface IPageRatingWriter
    {
        bool AddNewRecord(int pageId, int rating, string identifier);

        bool UpdateRecord(int pageId, int rating);

        bool DeletePageRatings(int pageId);
    }
}
