using System;

namespace HFEA.Connector.Global
{
    public interface IContentCacheService
    {
        T Get<T>(string key) where T : class, new();
        void Set<T>(string key, T obj, TimeSpan? timeout = null, bool isSliding = false) where T : class, new();
        T GetResultsOrSetCache<T>(string key, Func<T> retrieveResultsMethod) where T : class, new();
    }
}