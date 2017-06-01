using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.COP;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Extensions;
using System;

namespace HFEA.Connector.Service.Client.COP
{
    public class COPReaderClientCachedAdaptor : COPReaderClient
    {         
        private readonly IContentCacheService cacher;

        // default cache expiration is set to 15 minutes
        private readonly TimeSpan cacheTimeout = new TimeSpan(0, 15, 0); 
        
        public COPReaderClientCachedAdaptor(IGetClientFactory factory, IContentCacheService cacheProvider) : base(factory)
        {
            if (cacheProvider == null) throw new ArgumentNullException("COP cache provide is null");

            this.cacher = cacheProvider;
        }

        public override COPItem GetAllGroups()
        {
            string key = GroupsApi.GetDescription();

            var result = this.cacher.Get<COPItem>(key);

            if (result == null)
            {
                result = base.GetAllGroups();
                this.cacher.Set<COPItem>(key, result, cacheTimeout);
            }

            return result;
        }

        public override COPItem GetSection(int sectionId)
        {
            var parameters = this.GetSectionUrlParameters(sectionId);
            string key = Helpers.UrlHelper.GetUrlWithParameters(SectionApi.GetDescription(), null, parameters);

            COPItem result = new COPItem();
            try
            {
                result = this.cacher.Get<COPItem>(key);
            }
            catch { }
            if (result == null)
            {
                result = base.GetSection(sectionId);
                this.cacher.Set<COPItem>(key, result, cacheTimeout);
            }
  //}
            //catch { }
            return result;
        }
    }
}
