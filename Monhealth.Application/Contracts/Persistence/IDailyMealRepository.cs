using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IDailyMealRepository : IGenericRepository<DailyMeal, Guid>
    {
        Task<DailyMeal> GetDailyMealByUserAndDate(DateTime createAt, Guid userId);
        Task<int> SaveChangeAsync();
        Task<List<DailyMeal>> GetAllDailyMeals();
    }
}