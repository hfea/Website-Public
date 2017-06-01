using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Umbraco.Web;

namespace HFEA.Web
{
    public class Global : UmbracoApplication
    {
        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            IoCConfig.InitIoC();

            References.Init.InitDependencies();

        }
    }
}