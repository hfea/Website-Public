using HFEA.Connector.Global;
using HFEA.Data.Contracts.Model;
using HFEA.Data.Contracts.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Access.Writers
{
    public class PageRatingWriter : IPageRatingWriter
    {
        private readonly IHfeaLogger log;
        public PageRatingWriter(IHfeaLogger logger)
        {
            if (logger == null) throw new ArgumentNullException("logger is null");
            this.log = logger;
        }

        public bool AddNewRecord(int pageId, int rating, string identifier)
        {
            bool result = false;

            try
            {
                using (var db = new DataContext())
                {
                    var record = new PageRating()
                    {
                        CmsId = pageId,
                        DateCreated = DateTime.UtcNow,
                        Score = rating,
                        UserIdentifier = identifier
                    };

                    db.PageRatings.Add(record);
                    result = db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                this.log.Error("error writing to pagecomments table", ex);
            }

            return result;
        }

        public bool DeletePageRatings(int pageId)
        {
            bool result = false;

            try
            {
                using (var db = new DataContext())
                {
                    var toDelete = db.PageRatings.Where(x => x.CmsId == pageId);
                    db.PageRatings.RemoveRange(toDelete);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                this.log.Error("error writing to pagecomments table", ex);
            }

            return result;
        }

        public bool UpdateRecord(int id, int rating)
        {
            bool result = false;

            try
            {
                using (var db = new DataContext())
                {
                    var found = db.PageRatings.First(x => x.Id == id);
                    
                    found.Score = rating;                   
                    db.SaveChanges();

                    result = true;
                }
            }
            catch (Exception ex)
            {
                this.log.Error("error writing to pagecomments table", ex);
            }

            return result;
        }
    }
}
