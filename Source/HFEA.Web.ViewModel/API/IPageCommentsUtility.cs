using HFEA.Core;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    public interface IPageCommentsUtility
    {
        PageCommentsApiViewModel GetCommentsData(int page, int pageSize, int? pageId, ApiConstants.ApprovalStatusFilter approvalStatus);
        bool DeleteComment(int commentId);
        bool UpdateComment(PageCommentsItem comment);
    }
}
