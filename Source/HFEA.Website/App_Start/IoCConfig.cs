using Autofac;
using Autofac.Extras.CommonServiceLocator;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using HFEA.BL.Contracts.Search;
using HFEA.Connector.Global;
using HFEA.Web.Caching;
using HFEA.Web.Helpers;
using HFEA.Web.SearchProvider;
using HFEA.Web.Utilities;
using HFEA.Web.ViewModel;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.COP;
using HFEA.Web.ViewModel.PGD;
using Microsoft.Practices.ServiceLocation;
using System.Web.Http;
using System.Web.Mvc;
using Umbraco.Forms.Web.Trees;
using Umbraco.Web;

namespace HFEA.Web
{
    public class IoCConfig
    {
        public static void InitIoC()
        {
            var builder = new ContainerBuilder();
            
            References.Init.IocRegisterTypes(builder);

            builder.RegisterType<Logger>().As<IHfeaLogger>();
            builder.RegisterType<CafcProfileUrlHelper>().As<ICafcProfileUrlHelper>();
            builder.RegisterType<CafcQueryStringHelper>().As<ICafcQueryStringHelper>();
            builder.RegisterType<CopUrlResolver>().As<ICOPUrlResolver>();
            builder.RegisterType<UmbracoContentReader>().As<IUmbracoContentReader>();
            builder.RegisterType<ContentCacheService>().As<IContentCacheService>();
            builder.RegisterType<CmsUrlResolver>().As<ICmsUrlResolver>();
            builder.RegisterType<PgdConditionsCmsReader>().As<IPgdConditionsCmsReader>();
            
            //register all controllers found in this assembly
            builder.RegisterControllers(typeof(Global).Assembly);

            //register umbraco webapi controllers used by the admin site
            builder.RegisterApiControllers(typeof(UmbracoApplication).Assembly);
            builder.RegisterApiControllers(typeof(Global).Assembly);
            // Umbraco forms controllers
            builder.RegisterApiControllers(typeof(FormTreeController).Assembly);

            var container = builder.Build();

            var csl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => csl);

            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
