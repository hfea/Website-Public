using HFEA.Data.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Contracts.Readers
{
    public interface IPageCommentsReader
    {
        PageComment GetCommentById(int id);

        List<PageComment> GetAllComments(bool oldFirst);

        List<PageComment> GetCommentsByPageId(int pageId, bool oldFirst);

        List<PageComment> GetCommentTreeListByPageId(int pageId, bool oldFirst);
    }
}
