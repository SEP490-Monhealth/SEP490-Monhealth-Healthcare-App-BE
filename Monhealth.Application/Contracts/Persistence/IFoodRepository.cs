using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
namespace Monhealth.Application.Contracts.Persistence
{
    public interface IFoodRepository : IGenericRepository<Food, Guid>
    {
        Task<List<Food>> GetByIdsAsync(IEnumerable<Guid> foodIds);
        Task<PaginatedResult<Food>> GetAllFoodAsync(int page, int limit, string? search, bool? status, string categoryName, bool? popular,bool? isPublic);
        Task<int> SaveChangesAsync();
        Task<Food> GetFoodByIdAsync(Guid foodId);
        Task<List<Food>> GetFoodByCategoryName(string categoryName);
        Task<Food> GetFoodByNameAsync(string foodName);
        Task<Food> GetByIdWithCategoriesAsync(Guid foodId);
        // void RemoveFoodCategories(Guid foodId);
        void RemoveFoodPortions(Guid foodId);
        Task<PaginatedResult<Food>> GetFoodByUserId(int page, int limit, Guid userId);
        Task<List<Food>> GetFoodsByCategoryNameAsync(string[] categoryNames);
    }
}
