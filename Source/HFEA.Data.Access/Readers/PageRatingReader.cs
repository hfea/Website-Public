using HFEA.Data.Contracts.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Data.Contracts.Model;
using HFEA.Data.Contracts.DerivedModels;

namespace HFEA.Data.Access.Readers
{
    public class PageRatingReader : IPageRatingReader
    {
        public List<PageRatingStatistics> GetAllPageStatistics(bool mostPopularFirst)
        {
            List<PageRatingStatistics> result = null;

            using (var db = new DataContext())
            {
                var pre = db.PageRatings
                    .GroupBy(g => g.CmsId)
                    .Select(x => new PageRatingStatistics()
                    {
                        PageId = x.Key,
                        Title = x.FirstOrDefault().CmsPageName,
                        AverageScore = x.Average(a => a.Score),
                        VoteCount = x.Count(),
                        LastSubmissionDate = x.Max(d => d.DateCreated)
                    });

                if (mostPopularFirst)
                {
                    result = pre.OrderByDescending(x => x.AverageScore).ToList();
                }
                else
                {
                    result = pre.OrderBy(x => x.AverageScore).ToList();
                }
            }

            return result;
        }

        public PageRating GetPageRatingObject(int pageId, string identifier)
        {
            PageRating result = null;

            using (var db = new DataContext())
            {
                result = db.PageRatings.FirstOrDefault(x => x.CmsId == pageId && x.UserIdentifier == identifier);
            }

            return result;
        }

        public double GetRatingByPageId(int pageId, out int totalRecords)
        {
            double result = 0f;
            totalRecords = 0;

            using (var db = new DataContext())
            {
                var dbSet = db.PageRatings
                    .Where(x => x.CmsId == pageId);

                totalRecords = dbSet.Count();
                if (totalRecords > 0)
                {
                    result = dbSet.Average(x => x.Score);
                }                
            }

            return result;
        }
    }
}
