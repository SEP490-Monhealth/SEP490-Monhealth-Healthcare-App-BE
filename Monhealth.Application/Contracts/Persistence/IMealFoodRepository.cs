using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMealFoodRepository : IGenericRepository<MealFood, Guid>
    {
        Task<MealFood> GetByMealIdAndFoodId(Guid mealId, Guid FoodId);
        Task<int> SaveChangeAsync();
        Task<List<MealFood>> GetMealFoodByMealId(Guid mealId);
        Task<List<MealFood>> GetMealFoodByFoodId(Guid foodId);
        Task<MealFood> GetByMealFoodIdAsync(Guid id);
        Task<int>SaveChangeASyncs();
    }
}