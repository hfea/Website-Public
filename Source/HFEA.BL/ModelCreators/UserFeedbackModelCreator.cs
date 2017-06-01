using HFEA.Data.Contracts.Model;
using HFEA.Data.Contracts.Readers;
using HFEA.Web.ViewModel.UserFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HFEA.BL.ModelCreators
{
    public class UserFeedbackModelCreator : IUserFeedbackModelCreator
    {
        private readonly IPageRatingReader ratingReader;
        private readonly IPageCommentsReader commentsReader;

        public UserFeedbackModelCreator(IPageRatingReader ratingDataReader, IPageCommentsReader commentsDataReader)
        {
            if (ratingDataReader == null) throw new ArgumentNullException("rating data reader is null");
            if (commentsDataReader == null) throw new ArgumentNullException("comments data reader is null");

            this.ratingReader = ratingDataReader;
            this.commentsReader = commentsDataReader;
        }

        public CommentsViewModel GetPageComments(int pageId, int pageNumber, int itemsPerPage, bool oldFirst)
        {
            CommentsViewModel result = null;

            if (pageId > 0 && pageNumber > 0 && itemsPerPage > 0)
            {
                var rawData = this.commentsReader.GetCommentTreeListByPageId(pageId, oldFirst);
                result = new CommentsViewModel()
                {                    
                    ShowOldestCommentsFirst = oldFirst
                };

                if (rawData != null && rawData.Any())
                {
                    result.TotalComments = rawData.Count;

                    rawData = rawData.Take(pageNumber * itemsPerPage).ToList();

                    List<UserComment> commentList = new List<UserComment>();

                    foreach(var rawComment in rawData)
                    {
                        var comment = this.MapUserComment(rawComment);
                        if (comment != null && rawComment.PageComments != null && rawComment.PageComments.Any())
                        {
                            comment.ReplyList = rawComment.PageComments
                                .Where(x => x.IsApproved)
                                .Select(x => this.MapUserComment(x))
                                .ToList();
                        }

                        commentList.Add(comment);
                    }

                    result.CommentList = commentList;
                }
            }

            return result;
        }

        public PageRatingModel GetPageRating(int pageId)
        {
            double score;
            int totalRecords;
            score = this.ratingReader.GetRatingByPageId(pageId, out totalRecords);

            return new PageRatingModel()
            {
                TotalRecords = totalRecords,
                Score = score
            };
        }

        private UserComment MapUserComment(PageComment comment)
        {
            UserComment result = null;

            if (comment != null)
            {
                result = new UserComment()
                {
                    CommentId = comment.Id,
                    ReplyId = comment.ParentId ?? comment.Id,
                    CommentText = comment.Text,
                    Date = comment.CreatedDate,
                    FormattedDate = comment.CreatedDate.ToHFEADisplayShortDateString(),
                    FormattedTime = comment.CreatedDate.ToShortTimeString(),
                    Name = comment.Name,
                    Surname = comment.Lastname
                };
            }

            return result;
        }
    }
}
