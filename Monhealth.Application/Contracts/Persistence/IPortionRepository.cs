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
        Task<List<Portion>> GetAllPortionAsync(string? sort, string? order);
        Task AddPortionAsync(FoodPortion foodPortion);
        Task<int> SaveChangesAsync();
        Task<Portion> GetPortionAsync(string measurementUnit, string portionSize, float portionWeight);
    }
}
