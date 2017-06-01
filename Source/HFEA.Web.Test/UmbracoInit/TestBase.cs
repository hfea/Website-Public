using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using umbraco.NodeFactory;
using Umbraco.Core;


namespace HFEA.Web.Test.UmbracoInit
{
    public class TestBase
    {
        protected int HomepageNodeID = Core.Config.Settings.KeyPages.Homepage;

        public virtual void Init()
        {
            if (ApplicationContext.Current == null)
            {
                var application = new ApplicationBase();
                application.Start(application, new EventArgs());
            }
        }

        //[TestMethod]
        //public void InitTest_ContentNodeExists()
        //{
        //    var node = new Node(HomepageNodeID);

        //    Assert.IsTrue(node.Id != 0);

        //    Assert.IsNotNull(node.GetProperty("pageTitle"));
        //}
    }
}
