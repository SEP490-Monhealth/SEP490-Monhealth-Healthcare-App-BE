using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monhealth.Application.Contracts.Caching
{
    public interface ICacheService
    {

        Task<T> GetAsync<T>(string key);
        Task SetAsync(string key, string value, TimeSpan slidingExpiration);
        Task RemoveAsync(string key);
    }
}