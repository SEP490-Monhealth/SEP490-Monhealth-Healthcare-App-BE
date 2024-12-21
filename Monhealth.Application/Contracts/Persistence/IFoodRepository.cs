using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IFoodRepository : IGenericRepository<Food, Guid>
    {
        Task<List<Food>> GetByIdsAsync(IEnumerable<Guid> foodIds);
        Task<List<Food>> GetAllFoodAsync();
        Task<int> SaveChangesAsync();
        Task<List<Food>> GetFoodListByFoodType(string foodType);
    }
}
