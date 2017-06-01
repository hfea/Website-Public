using HFEA.Connector.Contracts.CentreDashboard;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.OnlineApps;
using HFEA.Connector.Contracts.OnlineApps;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Client.OnlineApps
{
    public class OnlineAppsReaderClientCachedAdaptor : OnlineAppsReaderClient, IOnlineAppsReaderClientCached
    {
        private const string GetFirstPageKey = "GetFirstPageCache{0}";
        //private const string GetPrevPageKey = "GetPrevPageCache{0}-{1}";
        //private const string GetNextPageKey = "GetNextPageCache{0}-{1}";
        //private const string JumpToPageKey = "JumpToPageCache{0}-{1}-{2}";
        private const string GetPageValidationKey = "GetPageValidationCache{0}";
        private const string GetApplicationByAppIdKey = "GetApplicationByAppIdCache{0}";
        private const string GetApplicationByUserAppIdKey = "GetApplicationByUserAppIdCache{0}";
        private readonly IContentCacheService cacher;

        // default cache expiration is set to 15 minutes
        private readonly TimeSpan cacheTimeout = new TimeSpan(0, 15, 0); 
        
        public OnlineAppsReaderClientCachedAdaptor(ITokenResolver tokenResolver, IHfeaLogger logger, IContentCacheService cacheProvider) : base(tokenResolver, logger)
        {
            if (cacheProvider == null) throw new ArgumentNullException("Online App cache provider is null");

            this.cacher = cacheProvider;
        }

        public override async Task<ApplicationDocumentControl> GetFirstPage(Guid documentId)
        {
            string key = string.Format(GetFirstPageKey, documentId);
            
            ApplicationDocumentControl data = this.cacher.Get<ApplicationDocumentControl>(key);
            if (data == null)
            {
                data = await base.GetFirstPage(documentId);
                if (data != null)
                {
                    this.cacher.Set<ApplicationDocumentControl>(key, data, cacheTimeout, true);
                }
            }
            
            return data;
        }
        
        public override async Task<List<ApplicationDocumentControlValidation>> GetPageValidation(int pageId)
        {
            string key = string.Format(GetPageValidationKey, pageId);

            List<ApplicationDocumentControlValidation> data = this.cacher.Get<List<ApplicationDocumentControlValidation>>(key);
            if (data == null)
            {
                data = await base.GetPageValidation(pageId);
                if (data != null)
                {
                    this.cacher.Set<List<ApplicationDocumentControlValidation>>(key, data, cacheTimeout, true);
                }
            }

            return data;
        }

        public override async Task<UserApplication> GetUserApplicationByAppId(int id)
        {
            string key = string.Format(GetApplicationByAppIdKey, id);

            UserApplication data = this.cacher.Get<UserApplication>(key);
            if (data == null)
            {
                data = await base.GetUserApplicationByAppId(id);
                if (data != null)
                {
                    this.cacher.Set<UserApplication>(key, data, cacheTimeout, true);
                }
            }

            return data;
        }

        public override async Task<UserApplication> GetUserApplicationByUserAppId(Guid id)
        {
            string key = string.Format(GetApplicationByUserAppIdKey, id);

            UserApplication data = this.cacher.Get<UserApplication>(key);
            if (data == null)
            {
                data = await base.GetUserApplicationByUserAppId(id);
                if (data != null)
                {
                    this.cacher.Set<UserApplication>(key, data, cacheTimeout, true);
                }
            }

            return data;
        }
    }
}
