// Bring in the necessary namespaces for the classes and interfaces used in this code

using System.Runtime.Caching;

namespace MCP.Data.Helpers
{
    public static class Caching
    {
        private static readonly MemoryCache cache = MemoryCache.Default;

        /// <summary>
        ///     A method for getting objects from the memory cache
        /// </summary>
        /// <typeparam name="T">
        ///     The type of the object to be returned from cache<</typeparam>
        /// <param name="cacheKey">The cache-key-name to be retreived</param>
        /// <returns>An object of the type you asked for</returns>
        public static T Get<T>(CachingEnum cacheKey) where T : class
        {
            return cache.Get(cacheKey.ToString()) as T;
        }

        /// <summary>
        ///     A method for setting objects to the memory cache.
        /// </summary>
        /// <typeparam name="T">The type of the object to be stored in cache</typeparam>
        /// <param name="cacheItemName">The name to be used when storing this object in the cache.</param>
        /// <param name="cacheTimeInMinutes">How long to cache this object for.</param>
        /// <param name="obj">the object to be stored in cache</param>
        public static void Set<T>(CachingEnum cacheItem, T obj) where T : class
        {
            var policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(cacheItem.GetCacheExpiringTime());
            cache.Set(cacheItem.ToString(), obj, policy);
        }


        /// <summary>
        ///     A generic method for getting and setting objects to the memory cache.
        /// </summary>
        /// <typeparam name="T">The type of the object to be returned.</typeparam>
        /// <param name="cacheItemName">The name to be used when storing this object in the cache.</param>
        /// <param name="cacheTimeInMinutes">How long to cache this object for.</param>
        /// <param name="objectSettingFunction">
        ///     A parameterized function to call if the object isn't in the cache and you need to
        ///     set it.
        /// </param>
        /// <returns>An object of the type you asked for</returns>
        public static T GetOrSet<T>(CachingEnum cacheItem, Func<dynamic, T> objectSettingFunction, dynamic param)
        {
            T cachedObject;
            var cachekey = cacheItem.ToString();
            if (!cache.Contains(cachekey))
            {
                var policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(cacheItem.GetCacheExpiringTime());
                cachedObject = objectSettingFunction(param);
                cache.Set(cachekey, cachedObject, policy);
            }
            else
            {
                cachedObject = (T)cache[cachekey];
            }

            return cachedObject;
        }

        public static T GetOrSet<T>(CachingEnum cacheItem, Func<dynamic, dynamic, T> objectSettingFunction,
            dynamic param1, dynamic param2)
        {
            T cachedObject;
            var cachekey = cacheItem.ToString();
            if (!cache.Contains(cachekey))
            {
                var policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(cacheItem.GetCacheExpiringTime());
                cachedObject = objectSettingFunction(param1, param2);
                cache.Set(cachekey, cachedObject, policy);
            }
            else
            {
                cachedObject = (T)cache[cachekey];
            }

            return cachedObject;
        }


        /// <summary>
        ///     A generic method for getting and setting objects to the memory cache.
        /// </summary>
        /// <typeparam name="T">The type of the object to be returned.</typeparam>
        /// <param name="cacheItemName">The name to be used when storing this object in the cache.</param>
        /// <param name="cacheTimeInMinutes">How long to cache this object for.</param>
        /// <param name="objectSettingFunction">
        ///     A parameterless function to call if the object isn't in the cache and you need to
        ///     set it.
        /// </param>
        /// <returns>An object of the type you asked for</returns>
        public static T GetOrSet<T>(CachingEnum cacheItem, Func<dynamic> objectSettingFunction)
        {
            T cachedObject;
            var cachekey = cacheItem.ToString();
            if (!cache.Contains(cachekey))
            {
                var policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(cacheItem.GetCacheExpiringTime());
                cachedObject = objectSettingFunction();
                if (cachedObject != null)
                {
                    cache.Set(cachekey, cachedObject, policy);
                }
            }
            else
            {
                cachedObject = (T)cache[cachekey];
            }

            return cachedObject;
        }

        /// <summary>
        ///     Remove a cache entry
        /// </summary>
        /// <param name="cacheItem">The name to be used when storing this object in the cache.</param>
        /// <returns>Boolean : true if removed / false if not found</returns>
        public static bool RemoveFromCache(string cacheItem)
        {
            return cache.Remove(cacheItem) == null ? false : true;
        }

        public static void ClearAll()
        {
            cache.Trim(100);
        }
    }
}