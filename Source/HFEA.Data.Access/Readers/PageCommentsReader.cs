using HFEA.Data.Contracts.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Data.Contracts.Model;

namespace HFEA.Data.Access.Readers
{
    public class PageCommentsReader : IPageCommentsReader
    {
        public List<PageComment> GetAllComments(bool oldFirst)
        {
            List<PageComment> result = null;

            using (var db = new DataContext())
            {
                IQueryable<PageComment> data = db.PageComments;

                if (oldFirst)
                {
                    data = data.OrderBy(x => x.CreatedDate);
                }
                else
                {
                    data = data.OrderByDescending(x => x.CreatedDate);
                }

                result = data.ToList();
            }

            return result;
        }

        public List<PageComment> GetCommentsByPageId(int pageId, bool oldFirst)
        {
            List<PageComment> result = null;

            using (var db = new DataContext())
            {
                IQueryable<PageComment> data = db.PageComments
                    .Where(x => x.PageId == pageId);

                if (oldFirst)
                {
                    data = data.OrderBy(x => x.CreatedDate);
                }
                else
                {
                    data = data.OrderByDescending(x => x.CreatedDate);
                }

                result = data.ToList();
            }

            return result;
        }

        public List<PageComment> GetCommentTreeListByPageId(int pageId, bool oldFirst)
        {
            List<PageComment> result = null;

            using (var db = new DataContext())
            {
                IQueryable<PageComment> data = db.PageComments
                    .Include("PageComments")
                    .Where(x => x.PageId == pageId && x.IsApproved && x.ParentId == null);

                if (oldFirst)
                {
                    data = data.OrderBy(x => x.CreatedDate);
                }
                else
                {
                    data = data.OrderByDescending(x => x.CreatedDate);
                }

                result = data.ToList();
            }

            return result;
        }

        public PageComment GetCommentById(int id)
        {
            PageComment result = null;

            using (var db = new DataContext())
            {
                result = db.PageComments
                    .Where(x => x.Id == id).FirstOrDefault();
            }

            return result;
        }
    }
}
