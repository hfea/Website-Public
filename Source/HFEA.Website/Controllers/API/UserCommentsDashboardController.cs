using HFEA.Core;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace HFEA.Web.Controllers
{
    /// <summary>
    /// This controller/action resolves to url: "/umbraco/backoffice/api/userCommentsDashboard/[action]"
    /// </summary>
    public class UserCommentsDashboardController : UmbracoAuthorizedApiController
    {
        private const int PageSize = 15;
        private readonly IPageCommentsUtility utility;

        public UserCommentsDashboardController(IPageCommentsUtility pageCommentsUtility)
        {
            if (pageCommentsUtility == null) throw new ArgumentNullException("comments utility is null");

            this.utility = pageCommentsUtility;
        }
       
        [AcceptVerbs("GET")]
        public PageCommentsApiViewModel GetPage(int page, ApiConstants.ApprovalStatusFilter approvalStatus, int? pageId)
        {
            return this.utility.GetCommentsData(page, PageSize, pageId, approvalStatus);
        }

        [AcceptVerbs("POST")]
        public bool UpdateComment(PageCommentsItem comment)
        {
            if (Security.CurrentUser.UserType.Name == "Contributor")
            {
                return false;
            }
            else
            {
                return this.utility.UpdateComment(comment);
            }
        }

        [AcceptVerbs("POST")]
        public bool DeleteComment(int commentId)
        {
            if (Security.CurrentUser.UserType.Name == "Contributor")
            {
                return false;
            }
            else
            {
                return this.utility.DeleteComment(commentId);
            }
        }
    }
}