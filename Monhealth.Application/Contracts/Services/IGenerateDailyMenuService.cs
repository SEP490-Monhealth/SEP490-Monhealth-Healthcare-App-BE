using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Services
{
    public interface IGenerateDailyMenuService
    {
        public Task<DailyMeal> GenerateDailyMealAsync(Guid userId, double tdee, string goal);
    }
}
