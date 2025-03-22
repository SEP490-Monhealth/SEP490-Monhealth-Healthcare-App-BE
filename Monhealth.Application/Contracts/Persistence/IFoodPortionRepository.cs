using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IFoodPortionRepository : IGenericRepository<FoodPortion, Guid>
    {
          public Task<FoodPortion>GetByFoodIdAsync(Guid foodId);
    }
}
