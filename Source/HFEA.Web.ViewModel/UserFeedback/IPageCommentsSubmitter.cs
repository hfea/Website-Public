using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.UserFeedback
{
    public interface IPageCommentsSubmitter
    {
        bool SubmitPageComment(CommentFormModel comment, int pageId);
    }
}
