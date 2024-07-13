using System;
using System.Runtime.Caching;

namespace MinistryOfJusticeRealEstateAgentRegistration.Caching
{
    public static class CacheManager
    {
        private static readonly ObjectCache Cache = MemoryCache.Default;

        public static object Get(string key)
        {
            return Cache[key];
        }

        public static void Add(string key, object value, DateTimeOffset absoluteExpiration)
        {
            Cache.Add(key, value, absoluteExpiration);
        }

        public static void Remove(string key)
        {
            Cache.Remove(key);
        }
    }
}
