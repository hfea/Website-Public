using HFEA.Data.Contracts.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Data.Contracts.Model;
using HFEA.Connector.Global;

namespace HFEA.Data.Access.Writers
{
    public class PageCommentWriter : IPageCommentWriter
    {
        private readonly IHfeaLogger log;
        public PageCommentWriter(IHfeaLogger logger)
        {
            if (logger == null) throw new ArgumentNullException("logger is null");
            this.log = logger;
        }

        public bool AddNewRecord(PageComment comment)
        {
            bool result = false;

            try
            {
                using (var db = new DataContext())
                {
                    db.PageComments.Add(comment);
                    result = db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                this.log.Error("error writing to pagecomments table", ex);
            }

            return result;
        }

        public bool DeleteComment(int commentId)
        {
            bool result = false;

            try
            {
                using (var db = new DataContext())
                {
                    var comment = db.PageComments.FirstOrDefault(x => x.Id == commentId);

                    if (comment != null)
                    {
                        db.PageComments.Remove(comment);
                        db.SaveChanges();
                    }
                    result = true;
                }
            }
            catch (Exception ex)
            {
                this.log.Error("error writing to pagecomments table", ex);
            }

            return result;
        }

        public bool UpdateComment(PageComment comment)
        {
            bool result = false;

            try
            {
                using (var db = new DataContext())
                {
                    db.Configuration.ProxyCreationEnabled = false;
                    var existing = db.PageComments.Find(comment.Id);
                    db.Entry(existing).CurrentValues.SetValues(comment);
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
