using Autofac;
using Autofac.Extras.CommonServiceLocator;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using HFEA.BL;
using HFEA.BL.Contracts;
using HFEA.BL.Contracts.Mapper;
using HFEA.BL.Contracts.Search;
using HFEA.BL.DataWriters;
using HFEA.BL.Emailer;
using HFEA.BL.ModelCreators;
using HFEA.BL.ModelCreators.API;
using HFEA.BL.Readers;
using HFEA.BL.SearchProvider;
using HFEA.BL.SearchProvider.DataSources;
using HFEA.BL.Serialization;
using HFEA.CMS.Mapper;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.AccessControl;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Contracts.Clients.COP;
using HFEA.Connector.Contracts.Clients.ReferenceData;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Client.Api;
using HFEA.Connector.Service.Client.COP;
using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Service.Clients.CaFC;
using HFEA.Connector.Service.Clients.ReferenceData;
using HFEA.Data.Access.Readers;
using HFEA.Data.Access.Writers;
using HFEA.Data.Contracts.Readers;
using HFEA.Data.Contracts.Writers;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.COP;
using HFEA.Web.ViewModel.PGD;
using HFEA.Web.ViewModel.Search;
using HFEA.Web.ViewModel.UserFeedback;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web;

namespace HFEA.References
{
    public static class Init
    {
        public static void InitDependencies()
        {
            BL.AutoMapperInit.Init();

            Data.Access.DbInit.Do();

            ContentService.Published += ContentService_Published;
            ContentService.UnPublished += ContentService_UnPublished;
            MediaService.Saved += MediaService_Saved;
        }

        public static void IocRegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<ConfigHelper>().As<IConfigValues>();

            builder.RegisterType<JsonSerializer>().As<IJsonSerializer>();

            builder.RegisterType<ApiGetClientFactoryNonSecure>().As<IGetClientFactory>();
            builder.RegisterType<ApiPostClientFactory>().As<IPostClientFactory>();
            builder.RegisterType<ClinicSearch>().As<ICaFCSearch>();            

            builder.RegisterType<CaFCSearchModelCreator>().As<ICaFCSearchFiltersModelCreator>();
            builder.RegisterType<CaFCSearchModelCreator>().As<ICaFCSearchResultsModelCreator>();
            builder.RegisterType<CaFCSearchModelCreator>().As<ICaFCNameSearchModelCreator>();            

            builder.RegisterType<TagsReaderCachedAdaptor>().As<ITagsReader>();
            builder.RegisterType<TagsApiModelCreator>().As<ITagsApiModelCreator>();

            builder.RegisterType<EmailSender>().As<IEmailSender>();
            builder.RegisterType<UmbracoHelper>();
            builder.RegisterType<MappingUtility>().As<IMapper>();

            builder.RegisterType<COPReaderClientCachedAdaptor>().As<ICOPReaderClient>();
            builder.RegisterType<COPModelCreator>().As<ICOPModelCreator>();
            
            builder.RegisterType<ReferenceDataReaderCachedAdaptor>().As<IReferenceDataReader>();            

            builder.RegisterType<ProfileClientCachedAdaptor>().As<ICaFCProfileClient>();
            builder.RegisterType<CaFCProfileModelCreator>().As<ICaFCProfileModelCreator>();

            builder.RegisterType<PageRatingWriter>().As<IPageRatingWriter>();
            builder.RegisterType<PageRatingReader>().As<IPageRatingReader>();
            builder.RegisterType<PageRatingApiSubmitter>().As<IPageRatingUpdater>();

            builder.RegisterType<UserFeedbackModelCreator>().As<IUserFeedbackModelCreator>();
            builder.RegisterType<PageCommentsReader>().As<IPageCommentsReader>();
            builder.RegisterType<PageCommentWriter>().As<IPageCommentWriter>();
            builder.RegisterType<PageCommentsSubmitter>().As<IPageCommentsSubmitter>();

            builder.RegisterType<PageRatingUtility>().As<IPageRatingUtility>();
            builder.RegisterType<PageCommentsUtility>().As<IPageCommentsUtility>();

            builder.RegisterType<CaFCStatsModelCreator>().As<IClinicStatsModelCreator>();
            builder.RegisterType<CaFCStatsClientCachedAdaptor>().As<ICaFCStatsClient>();

            builder.RegisterType<CaFCComparisonClient>().As<ICaFCComparisonClient>();
            builder.RegisterType<CaFCComparisonModelCreator>().As<ICaFCComparisonModelCreator>();

            builder.RegisterType<CopSource>();
            builder.RegisterType<UmbracoSource>();
            builder.RegisterType<CaFCProfileSource>();

            builder.RegisterType<FullSearchDataSourceProvider>().As<IFullSearchDataSourceProvider>();
            builder.RegisterType<FullSearchDataService>().PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            builder.RegisterType<Searcher>().As<IHfeaSearcher>();
            builder.RegisterType<SearchModelCreator>().As<ISearchViewModelReader>();
                        
            builder.RegisterType<Connector.Service.Client.CaFC.ClinicFeedbackReadClientCachedAdaptor>().As<IClinicFeedbackReadClient>();
            builder.RegisterType<Connector.Service.Client.CaFC.ClinicFeedbackFormSubmitClient>().As<IClinicFeedbackFormSubmitClient>();
            builder.RegisterType<BL.CaFC.ClinicFeedbackReader>().As<IClinicFeedbackReader>();
            builder.RegisterType<BL.CaFC.ClinicFeedbackWriter>().As<IClinicFeedbackWriter>();
            builder.RegisterType<ApiPostClientFactoryNonSecure>().As<IPostClientFactory>();

            builder.RegisterType<PgdListingModelCreator>().As<IPgdListingModelCreator>();
        }

        private static void ContentService_UnPublished(Umbraco.Core.Publishing.IPublishingStrategy sender, Umbraco.Core.Events.PublishEventArgs<IContent> e)
        {
            var indexer = new FullSearchDataService();

            foreach (IContent node in e.PublishedEntities)
            {
                var id = new CompositeId() { Source = BL.Contracts.Constants.Search.SearchSource.CMS, ItemId = node.Id };
                indexer.DeleteIndex(id);
            }
        }

        private static void ContentService_Published(Umbraco.Core.Publishing.IPublishingStrategy sender, Umbraco.Core.Events.PublishEventArgs<Umbraco.Core.Models.IContent> e)
        {
            var indexer = new FullSearchDataService();

            foreach (IContent node in e.PublishedEntities)
            {
                var id = new CompositeId() { Source = BL.Contracts.Constants.Search.SearchSource.CMS, ItemId = node.Id };
                indexer.UpdateIndex(id);
            }
        }

        private static void MediaService_Saved(IMediaService sender, Umbraco.Core.Events.SaveEventArgs<IMedia> e)
        {
            var indexer = new FullSearchDataService();

            foreach (var mediaItem in e.SavedEntities)
            {
                bool deleteFromIndex = false;
                if (mediaItem.ContentType.Alias == "File")
                {
                    Property property = mediaItem.Properties["excludeFromSearch"];
                    deleteFromIndex = property != null
                        && property.Value != null
                        && property.Value.ToString() == "1";
                }

                var id = new CompositeId() { Source = BL.Contracts.Constants.Search.SearchSource.CMS, ItemId = mediaItem.Id };
                if (deleteFromIndex)
                {
                    indexer.DeleteIndex(id);
                }
                else
                {
                    indexer.UpdateIndex(id);
                }
            }
        }
    }
}
