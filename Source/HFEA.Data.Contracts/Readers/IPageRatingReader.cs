using HFEA.Data.Contracts.DerivedModels;
using HFEA.Data.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Contracts.Readers
{
    public interface IPageRatingReader
    {
        PageRating GetPageRatingObject(int pageId, string identifier);

        List<PageRatingStatistics> GetAllPageStatistics(bool mostPopularFirst);

        double GetRatingByPageId(int pageId, out int totalRecords);
    }
}
