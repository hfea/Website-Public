using HFEA.Core;
using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace HFEA.Web.Controllers
{
    /// <summary>
    /// This controller/action resolves to url: "/umbraco/backoffice/api/userratingdashboard/[action]"
    /// </summary>
    public class UserRatingDashboardController : UmbracoAuthorizedApiController
    {
        private const int PageSize = 15;
        private readonly IPageRatingUtility utility;

        public UserRatingDashboardController(IPageRatingUtility pageRatingUtility)
        {
            if (pageRatingUtility == null) throw new ArgumentNullException("rating utility is null");

            this.utility = pageRatingUtility;
        }

       
        [AcceptVerbs("GET")]
        public PageRatingApiViewModel GetPage(int page, bool sortDesc)
        {
            return this.utility.GetRatingsData(page, PageSize, sortDesc);
        }

        [AcceptVerbs("POST")]
        public bool DeletePageRatings(int pageId)
        {
            if(Security.CurrentUser.UserType.Name == "Contributor")
            {
                return false;
            } else
            {
                return this.utility.DeletePageRatings(pageId);
            }
        }
    }
}