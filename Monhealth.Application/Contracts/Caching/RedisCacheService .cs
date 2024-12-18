using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;

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
        return string.IsNullOrEmpty(data) ? default : JsonSerializer.Deserialize<T>(data);
    }

    public async Task SetAsync(string key, string value, TimeSpan slidingExpiration, TimeSpan absoluteExpiration)
    {
        var options = new DistributedCacheEntryOptions
        {
            SlidingExpiration = slidingExpiration,
            AbsoluteExpirationRelativeToNow = absoluteExpiration
        };

        await _cache.SetStringAsync(key, value, options);
    }

    public async Task RemoveAsync(string key)
    {
        await _cache.RemoveAsync(key);
    }
}

}