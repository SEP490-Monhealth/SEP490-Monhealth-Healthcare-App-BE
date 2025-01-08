using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMealRepository : IGenericRepository<Meal, Guid>
    {
        Task<List<Meal>> GetAllMeals();
        Task<Meal> GetByUserIdAndMealType(Guid userId, string mealType, DateTime date);
        Task<int> SaveChangeAsync();
        Task<List<Meal>> GetMealByUserAndDate(DateTime createAt, Guid userId);
        Task<Meal> GetMealByMealId(Guid mealId);
        Task<List<Meal>> GetMealByUser(Guid userId);
        Task<IEnumerable<Meal>> GetMealsByDailyMealId(Guid dailyMealId);
        Task<List<string>> GetAllMealTypesAsync();
        Task<List<Meal>>GetAllMealFoodForMeal(Guid MealId);
    }
}