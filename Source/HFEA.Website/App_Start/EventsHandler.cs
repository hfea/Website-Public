using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Publishing;
using Umbraco.Core.Services;
using Umbraco.Core.Persistence;
using Umbraco.Web;

namespace HFEA.Web.App_Start
{
    public class EventsHandler : IApplicationEventHandler
    {
        public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            //throw new NotImplementedException();
        }

        public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            //throw new NotImplementedException();
        }

        public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            //ContentService.Saving += ContentService_Saving;
        }
        //void ContentService_Saving(IContentService sender, Umbraco.Core.Events.SaveEventArgs<Umbraco.Core.Models.IContent> e)
        //{
        //    var test = e;
        //    var node = sender.GetById(e.SavedEntities.First().Id);
        //    var currentUser = ApplicationContext.Current.Services.UserService.GetByUsername(HttpContext.Current.User.Identity.Name);
        //    if (currentUser.UserType.Name == "Contributor")
        //    {
        //        if (e.SavedEntities.First().GetValue("enablePageRating").ToString() != node.GetValue("enablePageRating").ToString()
        //            || e.SavedEntities.First().GetValue("showCommenting").ToString() != node.GetValue("showCommenting").ToString()
        //            || e.SavedEntities.First().GetValue("enableCommentSubmissions").ToString() != node.GetValue("enableCommentSubmissions").ToString()
        //            )
        //        {
        //            e.CancelOperation(new Umbraco.Core.Events.EventMessage("Save", "You are not allowed to publish this content", Umbraco.Core.Events.EventMessageType.Error));
        //        }
        //    }
        //}
    }
}