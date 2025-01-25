using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IPortionRepository : IGenericRepository<Portion, Guid>
    {
        Task<List<Portion>> GetAllPortionAsync(string? sort, string? order);
        Task<List<Portion>> GetPortionsByFoodIdAsync(Guid foodId);
        Task AddPortionAsync(FoodPortion foodPortion);
        Task<Portion> CheckPortion(string portionSize, float portionWeight, string measurementUnit);
        Task<int> SaveChangesAsync();
        Task<Portion> GetPortionAsync(string measurementUnit, string portionSize, float portionWeight);

        //FoodRandom
         Task<List<Portion>> GetPortionsByFoodIdsAsync(List<Guid> foodIds);
         Task<List<FoodPortion>>GetFoodPortionsByFoodIdsAsync(List<Guid>foodPortions);
    }
}
