using HFEA.Connector.Global;
using System;
using Umbraco.Core;

namespace HFEA.Web.Caching
{
    public class ContentCacheService : IContentCacheService
    {
        // default cache expiration is set to 15 minutes
        private readonly TimeSpan cacheTimeout = new TimeSpan(0, 15, 0);

        public TimeSpan? CacheTimeout
        {
            get
            {
                return cacheTimeout;
            }
        }

        public T Get<T>(string key) where T : class, new()
        {
            Attempt<T> cache;
            try
            {
                if ((cache = ApplicationContext.Current.ApplicationCache.RuntimeCache.GetCacheItem(key).TryConvertTo<T>())
                    && cache.Success)
                {
                    return cache.Result;
                }
            }
            catch { }
            return default(T);
        }
        public string Get(string key)
        {
            Attempt<string> cache;
            try
            {
                if ((cache = ApplicationContext.Current.ApplicationCache.RuntimeCache.GetCacheItem(key).TryConvertTo<string>())
                    && cache.Success)
                {
                    return cache.Result;
                }
            }
            catch { }
            return string.Empty;
        }

        public void Set<T>(string key, T obj, TimeSpan? timeout = null, bool isSliding = false) where T : class, new()
        {
            try
            {
                ApplicationContext.Current.ApplicationCache.RuntimeCache.InsertCacheItem(key, () => obj, timeout, isSliding);
            }
            catch { }
        }

        public void Set(string key, string text, TimeSpan? timeout = null, bool isSliding = false)
        {
            try
            {
                ApplicationContext.Current.ApplicationCache.RuntimeCache.InsertCacheItem(key, () => text, timeout, isSliding);
            }
            catch { }
        }

        public T GetResultsOrSetCache<T>(string key, Func<T> retrieveResultsMethod) where T : class, new()
        {
            var result = this.Get<T>(key);

            if (result == null)
            {
                result = retrieveResultsMethod();
                this.Set<T>(key, result, this.CacheTimeout);
            }

            return result;
        }
    }
}
