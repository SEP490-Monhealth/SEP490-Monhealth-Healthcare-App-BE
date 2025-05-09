using Monhealth.Core.Enum;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMealRepository : IGenericRepository<Meal, Guid>
    {
        Task<List<Meal>> GetAllMeals();
        Task<Meal> GetByUserIdAndMealType(Guid userId, MealType mealType, DateTime date);
        Task<int> SaveChangeAsync();
        Task<List<Meal>> GetMealByUserAndDate(DateTime createAt, Guid userId);
        Task<Meal> GetMealByMealId(Guid mealId);
        Task<List<Meal>> GetMealByUser(Guid userId);
        Task<IEnumerable<Meal>> GetMealsByDailyMealId(Guid dailyMealId);
        Task<List<MealType>> GetAllMealTypesAsync();
        Task<List<Meal>> GetAllMealFoodForMeal(Guid MealId);
        Task<List<Meal>> GetMealsByDailyMealIdAsync(Guid dailyMealId);
        Task<Meal> GetMealByUserAndDateAsync(Guid userId, MealType mealType, DateTime mealDate);
        Task<Meal>AddAsync();
    }
}