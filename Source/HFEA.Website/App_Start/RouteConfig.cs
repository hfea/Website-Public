using HFEA.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using umbraco.NodeFactory;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace HFEA.Web
{
    public class RouteConfig
    {
        private const string ClinicIdParameter = "{clinicId}";
        private static CafcProfileUrlHelper cafcUrlHelper = new CafcProfileUrlHelper();

        public static void RegisterRoutes(RouteCollection routes)
        {
            // routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);          

            // TODO: this is a temporary route until COP page design changes
            // most likely it'll be removed later. If it stays then we need to make all hardcoded 
            // values manageable from CMS
            routes.MapUmbracoRoute(
            "codeOfPractice",
            GetRouteUrl(Core.Config.Settings.KeyPages.CodeOfPractice) + "{groupId}",
            new
            {
                controller = "CodeOfPractice",
                action = "CodeOfPractice",
                groupId = UrlParameter.Optional
            },
            new UmbracoVirtualNodeByIdRouteHandler(Core.Config.Settings.KeyPages.CodeOfPractice),
            new { groupId = @"(^$|^\d+$)" }  //integer or empty
            );

            routes.MapUmbracoRoute(
            "cafcProfileById",
            GetProfileRouteUrl(),
            new
            {
                controller = "CaFCClinicProfile",
                action = "CaFCClinicProfile"
            },
            new UmbracoVirtualNodeByIdRouteHandler(cafcUrlHelper.ClinicProfileNode?.Id ?? 0));

            // Rules for Feedback - IR
            routes.MapUmbracoRoute("cafcProfileFeedback", GetProfileFeedbackRouteUrl(),
            new
            {
                controller = "CAFCClinicFeedback",
                action = "FeedbackForm"
            },
            new UmbracoVirtualNodeByIdRouteHandler(cafcUrlHelper.CafcFeedbackNode?.Id ?? 0)
            );
                       
           routes.MapUmbracoRoute("cafcStatsPage", GetCafcStatsPageRouteUrl(),
           new
           {
               controller = "CaFCStatistics",
               action = "CaFCStatistics"
           },
           new UmbracoVirtualNodeByIdRouteHandler(cafcUrlHelper.CafcStatsPageNode?.Id ?? 0)
           );

           // Rule for All clinics search a to z
           routes.MapUmbracoRoute(
            "clinicSearchAZ",
            GetCafCAlphaSearchRouteUrl(Core.Config.Settings.KeyPages.AllCentres, "{alpha}"),
            new
            {
                controller = "AllClinics",
                action = "AllClinics",
                alpha = UrlParameter.Optional
            },
            new UmbracoVirtualNodeByIdRouteHandler(Core.Config.Settings.KeyPages.AllCentres)
            //new { groupId = @"(^$|^\d+$)" }  //integer or empty
            );

            //Clinic Search -IR
            //routes.MapUmbracoRoute("cafcSearchByAlphabet", GetCafCAlphaSearchRouteUrl(),
            //new
            //{
            //    controller = "CaFCAlphabetSearchSurfaceController",
            //    action = "RenderAllCentresPage",
            //    alph = UrlParameter.Optional
            //},
            //new UmbracoVirtualNodeByIdRouteHandler(Core.Config.Settings.KeyPages.AllCentres),
            //new { alph = @"^[a-zA-Z]$" }  // a letter A to Z
            //);


        }

        private static string GetRouteUrl(int node)
        {
            string result = EnsureNoStartingForwardSlash(Helpers.CmsHelper.GetUrlById(node));

            return result;
        }

        private static string GetProfileRouteUrl()
        {
            var url = cafcUrlHelper.GetPageUrl(ClinicIdParameter);
            return EnsureNoStartingForwardSlash(url);
        }
        private static string GetProfileFeedbackRouteUrl()
        {
            var url = cafcUrlHelper.GetFeedBackUrl(ClinicIdParameter);
            return EnsureNoStartingForwardSlash(url);
        }
        private static string GetCafcStatsPageRouteUrl()
        {
            var url = cafcUrlHelper.GetStatsPageUrl(ClinicIdParameter);
            return EnsureNoStartingForwardSlash(url);
        }
        private static string GetCafCAlphaSearchRouteUrl(int node, string parameter)
        {
            var url = new Node(node).NiceUrl + parameter;
            return EnsureNoStartingForwardSlash(url);
        }

        private static string EnsureNoStartingForwardSlash(string url)
        {
            if (url != null && url.StartsWith("/"))
            {
                url = url.Remove(0, 1);
            }

            return url;
        }
    }
}
