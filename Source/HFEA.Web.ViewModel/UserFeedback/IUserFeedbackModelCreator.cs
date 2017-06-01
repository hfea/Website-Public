using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.UserFeedback
{
    public interface IUserFeedbackModelCreator
    {
        PageRatingModel GetPageRating(int pageId);

        CommentsViewModel GetPageComments(int pageId, int pageNumber, int itemsPerPage, bool sortByDateDesc);        
    }
}
