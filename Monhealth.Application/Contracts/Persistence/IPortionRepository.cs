using Monhealth.Application.Models;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IPortionRepository : IGenericRepository<Portion, Guid>
    {
        Task<PageResult<Portion>> GetAllPortionAsync(int page, int limit, string? sort, string? order);
        Task AddPortionAsync(FoodPortion foodPortion);
        Task<int> SaveChangesAsync();
    }
}
