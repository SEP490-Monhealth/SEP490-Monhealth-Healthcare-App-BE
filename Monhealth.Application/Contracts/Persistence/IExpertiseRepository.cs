using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Core;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IExpertiseRepository : IGenericRepository<Expertise, Guid>
    {
        Task<Expertise> GetExpertiseByNameAsync(string expertiseName);
        Task<int> SaveChangeAsync();
    }
}
