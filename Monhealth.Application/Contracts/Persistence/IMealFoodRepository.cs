using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMealFoodRepository : IGenericRepository<MealFood, Guid>
    {
        Task<MealFood> GetByMealIdAndFoodId(Guid mealId, Guid FoodId);
        Task<int> SaveChangeAsync();
    }
}