using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.UserFeedback
{
    public class CommentsViewModel
    {
        public List<UserComment> CommentList { get; set; }

        public int TotalComments { get; set; }

        public bool ShowOldestCommentsFirst { get; set; }

        public string SortOldestFirstUrl { get; set; }

        public string SortNewestFirstUrl { get; set; }

        public string NextCommentsPageUrl { get; set; }

        public string ReplyCommentBaseUrl { get; set; }

        public bool HasComments
        {
            get
            {
                return this.CommentList != null && this.CommentList.Any();
            }
        }

        public bool HasMoreComments
        {
            get
            {
                return this.HasComments && this.CommentList.Count < this.TotalComments;
            }
        }
    }
}
