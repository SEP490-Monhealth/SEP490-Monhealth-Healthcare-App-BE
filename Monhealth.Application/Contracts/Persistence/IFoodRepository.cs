using Monhealth.Domain;
namespace Monhealth.Application.Contracts.Persistence
{
    public interface IFoodRepository : IGenericRepository<Food, Guid>
    {
        Task<List<Food>> GetByIdsAsync(IEnumerable<Guid> foodIds);
        Task<List<Food>> GetAllFoodAsync();
        Task<int> SaveChangesAsync();
        Task<List<Food>> GetFoodListByFoodType(string foodType);
    }
}
