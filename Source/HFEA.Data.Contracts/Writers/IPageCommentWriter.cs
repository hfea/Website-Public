using HFEA.Data.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Contracts.Writers
{
    public interface IPageCommentWriter
    {
        bool AddNewRecord(PageComment comment);

        bool DeleteComment(int commentId);

        bool UpdateComment(PageComment comment);
    }
}
