using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IPortionRepository : IGenericRepository<Portion, Guid>
    {
        Task<List<Portion>> GetAllPortionAsync(string? sort, string? order);
        Task<List<Portion>> GetPortionsByFoodIdAsync(Guid foodId);
        Task AddPortionAsync(FoodPortion foodPortion);
        Task<int> SaveChangesAsync();
        Task<Portion> GetPortionAsync(string measurementUnit, string portionSize, float portionWeight);
    }
}
