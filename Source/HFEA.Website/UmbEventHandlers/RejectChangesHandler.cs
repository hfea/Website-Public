using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Web.Trees;
using HFEA.Core.Constants;
using Umbraco.Web.Models.Trees;

namespace HFEA.Web.UmbEventHandlers
{
    public class RejectChangesHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            TreeControllerBase.MenuRendering += this.TreeControllerBase_MenuRendering;
            base.ApplicationStarted(umbracoApplication, applicationContext);
        }

        void TreeControllerBase_MenuRendering(TreeControllerBase sender, MenuRenderingEventArgs e)
        {
            if (sender.TreeAlias == "content" 
                && UmbracoConstants.ContentChangeApproverUserTypes.Contains(sender.Security.CurrentUser.UserType.Alias))
            {
                var newMenu = new MenuItem("rejectChangesAction", "Reject Changes");
                newMenu.Icon = "stop-hand";
                newMenu.LaunchDialogView("/App_plugins/RejectChanges/rejectChangesAction.html", "Some title");
                e.Menu.Items.Add(newMenu);
            }
           
        }
    }
}