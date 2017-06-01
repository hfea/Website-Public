using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace HFEA.Web.Controllers
{
    public class MasterSurfaceController : SurfaceController
    {
        public ActionResult RenderBetaCookie()
        {
            try
            {
                var settings = Umbraco.TypedContent(HFEA.Core.Config.Settings.KeyPages.Settings).Children.Where(c => c.DocumentTypeAlias == "Dictionary").First();
                return PartialView("_BetaBanner", settings);
            }
            catch
            {
                return PartialView("_BetaBanner", null);
            }
        }
        public ActionResult RenderCookieFooter()
        {
           try
            {
                var settings = Umbraco.TypedContent(HFEA.Core.Config.Settings.KeyPages.Settings).Children.Where(c => c.DocumentTypeAlias == "Dictionary").First();
                return PartialView("_CookieBanner", settings);
            } catch
            {
                return PartialView("_CookieBanner", null);
            }
        }
    }
}