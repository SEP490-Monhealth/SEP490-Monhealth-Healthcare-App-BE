using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IDailyMealRepository : IGenericRepository<DailyMeal, Guid>
    {
        Task<DailyMeal> GetDailyMealByUserAndDate(DateTime createAt, Guid userId);
        Task<int> SaveChangeAsync();
        Task<List<DailyMeal>> GetAllDailyMeals();
        Task<DailyMeal> GetDailyMealByCreateAt(DateTime createAt);
        Task<DailyMeal> GetDailyMealsByUser(Guid userId, DateTime createAt);
        Task<DailyMeal> GetDailyMealsByCreateAt(DateTime createAt);
        Task<DailyMeal> GetDailyMealByIdAsync(Guid dailyMealId, CancellationToken cancellationToken);
    }
}