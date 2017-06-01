using System;
using Umbraco.Core;

namespace HFEA.Web.Test.UmbracoInit
{
    /// <summary>
    /// Extends the UmbracoApplicationBase, which is needed to start the application with out own BootManager.
    /// </summary>
    public class ApplicationBase : UmbracoApplicationBase
    {
        protected override IBootManager GetBootManager()
        {
            return new BootManager(this);
        }

        public void Start(object sender, EventArgs e)
        {
            base.Application_Start(sender, e);
        }
    }
}