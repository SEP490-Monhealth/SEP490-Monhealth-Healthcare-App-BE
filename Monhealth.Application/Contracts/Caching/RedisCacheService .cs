using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Monhealth.Application.Contracts.Caching
{
    public class RedisCacheService : ICacheService
    {
        private readonly IDistributedCache _cache;

        public RedisCacheService(IDistributedCache cache)
        {
            _cache = cache;
        }

        public async Task<T> GetAsync<T>(string key)
        {
            var data = await _cache.GetStringAsync(key);
            return string.IsNullOrEmpty(data) ? default : JsonConvert.DeserializeObject<T>(data);
        }

        public async Task SetAsync(string key, string value, TimeSpan slidingExpiration)
        {
            string cacheValue = JsonConvert.SerializeObject(value);
            await _cache.SetStringAsync(key, cacheValue, new 
             (){AbsoluteExpirationRelativeToNow = slidingExpiration} , default);
            
        }

        public async Task RemoveAsync(string key)
        {
            await _cache.RemoveAsync(key);
        }
    }

}