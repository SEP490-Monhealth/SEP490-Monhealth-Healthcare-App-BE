using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
namespace Monhealth.Application.Contracts.Persistence
{
    public interface IFoodRepository : IGenericRepository<Food, Guid>
    {
        Task<List<Food>> GetByIdsAsync(IEnumerable<Guid> foodIds);
        Task<PaginatedResult<Food>> GetAllFoodAsync(int page, int limit, string? search, bool? status, string categoryName, bool? popular, bool? isPublic);
        Task<PaginatedResult<Food>> GetFoodByUserId(int page, int limit, Guid userId);
        Task<int> SaveChangesAsync();
        Task<Food> GetFoodByIdAsync(Guid foodId);
        Task<List<Food>> GetFoodByCategoryName(string categoryName);
        Task<Food> GetFoodByNameAsync(string foodName);
        Task<Food> GetByIdWithCategoriesAsync(Guid foodId);
        Task<List<Food>> GetFoodsByCategoryNameAsync(string[] categoryNames);
        Task<(Food?, Food?, Food?, Food?)> GetRandomProteinAndCarbFood(
            List<Guid> allergiesIds
        );
        Task<List<Food>> GetFoodByUserHasNoAllergiesAsync(Guid userId);
        Task<PaginatedResult<Food>> GetRelatedFoodBasedOnType(Guid foodId, string? search, bool? status, int? page, int? limit);
        Task<PaginatedResult<Food>> GetAllFoodsAndFilterByFoodNameAsync(
            int page,
            int limit,
            string search,
            bool? status,
            bool? isPublic);

    }
}
