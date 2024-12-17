using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface INutritionRepository : IGenericRepository<Nutrition, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<List<Nutrition>> GetAllNutritionAsync();
        Task<List<Nutrition>> GetAllNutritionByFoodIdAsync(Guid foodId);
    }
}