using HFEA.Connector.Contracts.Api;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.COP;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Extensions;
using System;
using System.Collections.Generic;

namespace HFEA.Connector.Service.Client.Api
{
    public class TagsReaderCachedAdaptor : TagsReader
    { 
        private readonly IContentCacheService cacher;
        
        public TagsReaderCachedAdaptor(IGetClientFactory factory, IContentCacheService cacheProvider) : base(factory)
        {
            if (cacheProvider == null) throw new ArgumentNullException("Tags reader cache provider is null");
            this.cacher = cacheProvider;
        }

        public override List<ContentTag> GetContentTagList()
        {
            string key = Constants.ApiType.Search.Tags.GetDescription();
            var result = this.cacher.GetResultsOrSetCache<List<ContentTag>>(key, base.GetContentTagList);

            return result;
        }

        public override List<ContentTag> GetPortalProductTagList()
        {
            string key = Constants.ApiType.Search.ProductTagsPortal.GetDescription();
            var result = this.cacher.GetResultsOrSetCache<List<ContentTag>>(key, base.GetPortalProductTagList);
            
            return result;
        }

        public override List<ContentTag> GetWebsiteProductTagList()
        {
            string key = Constants.ApiType.Search.ProductTagsWebsite.GetDescription();
            var result = this.cacher.GetResultsOrSetCache<List<ContentTag>>(key, base.GetWebsiteProductTagList);

            return result;
        }
    }
}