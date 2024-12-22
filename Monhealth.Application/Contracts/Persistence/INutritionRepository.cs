using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface INutritionRepository : IGenericRepository<Nutrition, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<List<Nutrition>> GetAllNutritionAsync();
        Task<List<Nutrition>> GetAllNutritionByFoodIdAsync(Guid foodId);
        Task<List<Nutrition>>GetByFoodIdAsync(Guid foodId);
        Task<Nutrition>GetNutritionByFoodIdAsync(Guid foodId);
    }
}