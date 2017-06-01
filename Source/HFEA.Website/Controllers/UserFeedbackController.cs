using HFEA.Web.Constants;
using HFEA.Web.ViewModel.UserFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class UserFeedbackController : SurfaceController
    {
        public const string DataWriterError = "DataWriterError";
        private const int CommentsPerPage = 10;
        private const string PageRatingView = "PageRating";
        private const string PageCommentsView = "PageComments";

        private const QueryString.QueryParams PageQry = QueryString.QueryParams.page;
        private const QueryString.QueryParams OldFirstQry = QueryString.QueryParams.oldfirst;

        private readonly IUserFeedbackModelCreator feedbackReader;
        private readonly IPageCommentsSubmitter dataSubmitter;

        public UserFeedbackController(IUserFeedbackModelCreator modelCreator, IPageCommentsSubmitter commentsSubmitter)
        {
            if (modelCreator == null) throw new ArgumentNullException("user feedback model creator is null");
            if (commentsSubmitter == null) throw new ArgumentNullException("comment submitter is null");
            this.feedbackReader = modelCreator;
            this.dataSubmitter = commentsSubmitter;

            
        }

        [ChildActionOnly]
        public ActionResult GetRatingData()
        {
            var data = this.feedbackReader.GetPageRating(CurrentPage.Id);

            return PartialView(PageRatingView, data);
        }

        [ChildActionOnly]
        public ActionResult GetCommentsData()
        {
            var data = this.feedbackReader.GetPageComments(
                CurrentPage.Id, 
                PageQry.GetQryParamValueOrDefault<int>(1), 
                CommentsPerPage, 
                OldFirstQry.QueryExistsAndEquals(QueryString.QueryValues.yes));

            this.FixPageActionUrls(data);

            return PartialView(PageCommentsView, data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitComment(CommentFormModel form)
        {
            bool result = this.dataSubmitter.SubmitPageComment(form, CurrentPage.Id);

            if (result)
            {
                TempData.Add("success", Umbraco.GetDictionaryValue("New Comment Confirmation").ToString());
                return Redirect(CurrentPage.Url + "#commentform");
            }
            else
            {
                this.ModelState.AddModelError(DataWriterError, string.Empty);
                return CurrentUmbracoPage();
            }
        }

        private void FixPageActionUrls(CommentsViewModel model)
        {
            if (model != null)
            {
                string pageUrl = this.CurrentPage.Url;

                model.SortNewestFirstUrl = pageUrl;
                model.SortOldestFirstUrl = Helpers.UrlQueryHelper.AddUpdateQuery(pageUrl, OldFirstQry.ToString(), QueryString.QueryValues.yes.ToString());

                if (OldFirstQry.QueryExistsAndEquals(QueryString.QueryValues.yes))
                {
                    pageUrl = Helpers.UrlQueryHelper.AddUpdateQuery(pageUrl, OldFirstQry.ToString(), QueryString.QueryValues.yes.ToString());
                }

                int currentPage;
                if (PageQry.TryGetQryParamValue<int>(out currentPage) && currentPage > 0)
                {
                    pageUrl = Helpers.UrlQueryHelper.AddUpdateQuery(pageUrl, PageQry.ToString(), currentPage.ToString());
                }
                else
                {
                    currentPage = 1;
                }
                
                model.NextCommentsPageUrl = Helpers.UrlQueryHelper.AddUpdateQuery(pageUrl, PageQry.ToString(), (currentPage + 1).ToString());             
                model.ReplyCommentBaseUrl = Helpers.UrlQueryHelper.AddUpdateQuery(pageUrl, QueryString.QueryParams.replyOn.ToString(), "{0}");                
            }
        }
    }
}
