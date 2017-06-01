using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.UserFeedback
{
    public class UserComment
    {
        public int CommentId { get; set; }

        public int ReplyId { get; set; } 

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.Name, this.Surname).Trim();
            }
        }

        public DateTime Date { get; set; }

        public string FormattedDate { get; set; }

        public string FormattedTime { get; set; }

        public string CommentText { get; set; }

        public List<UserComment> ReplyList { get; set; }
    }
}
