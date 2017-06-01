using Umbraco.Core;
using umbraco.editorControls;
using umbraco.interfaces;

namespace HFEA.Web.Test.UmbracoInit
{
    /// <summary>
    /// Extends the CoreBootManager for use in this Console app.
    /// </summary>
    public class BootManager : CoreBootManager
    {
        public BootManager(UmbracoApplicationBase umbracoApplication)
            : base(umbracoApplication)
        {
            //This is only here to ensure references to the assemblies needed for the DataTypesResolver
            //otherwise they won't be loaded into the AppDomain.
            var interfacesAssemblyName = typeof(IAction).Assembly.FullName;
#pragma warning disable 618
            var editorControlsAssemblyName = typeof(uploadField).Assembly.FullName;
#pragma warning restore 612, 618
        }

        /// <summary>
        /// Can be used to initialize our own Application Events
        /// </summary>
        protected override void InitializeApplicationEventsResolver()
        {
            base.InitializeApplicationEventsResolver();
        }

        /// <summary>
        /// Can be used to add custom resolvers or overwrite existing resolvers once they are made public
        /// </summary>
        protected override void InitializeResolvers()
        {
            base.InitializeResolvers();
        }
    }
}