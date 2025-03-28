using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IPortionRepository : IGenericRepository<Portion, Guid>
    {
        Task<PaginatedResult<Portion>> GetAllPortionAsync(int page, int limit, string? sort, string? order);
        Task<PaginatedResult<Portion>> GetPortionsByFoodIdAsync(Guid foodId, int page, int limit, string? search, string? sort, string? order);
        Task AddPortionAsync(FoodPortion foodPortion);
        Task<Portion> CheckPortion(string portionSize, float portionWeight, string measurementUnit);
        Task<int> SaveChangesAsync();
        Task<Portion> GetPortionAsync(string measurementUnit, string portionSize, float portionWeight);

        //FoodRandom
        Task<List<Portion>> GetPortionsByFoodIdsAsync(List<Guid> foodIds);
        Task<List<FoodPortion>> GetFoodPortionsByFoodIdsAsync(List<Guid> foodPortions);
        Task<Portion> GetOrCreatePortionAsync(string measurementUnit, string portionSize, float portionWeight);

    }
}
