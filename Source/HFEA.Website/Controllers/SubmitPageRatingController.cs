using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace HFEA.Web.Controllers.API
{
    /// <summary>
    /// This controller/action resolves to url: "/umbraco/api/submitpagerating/[action]"
    /// </summary>
    public class SubmitPageRatingController : UmbracoApiController
    {
        private readonly IPageRatingUpdater updater;

        public SubmitPageRatingController(IPageRatingUpdater ratingUpdater)
        {
            if (ratingUpdater == null) throw new ArgumentNullException("rating updater is null");

            this.updater = ratingUpdater;
        }

       
        [AcceptVerbs("GET")]
        public bool Do(int pageId, int rating, string sessionId, string tempId)
        {
            if (pageId > 0 && rating > 0 && rating <= 5 && Helpers.SecurityHelper.IsValidHash(sessionId, pageId.ToString(), tempId))
            {
                return this.updater.AddUpdatePageRating(pageId, rating, sessionId);
            }

            return false;
        }
    }
}