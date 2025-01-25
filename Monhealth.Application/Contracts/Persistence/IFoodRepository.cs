using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
namespace Monhealth.Application.Contracts.Persistence
{
    public interface IFoodRepository : IGenericRepository<Food, Guid>
    {
        Task<List<Food>> GetByIdsAsync(IEnumerable<Guid> foodIds);
        Task<PaginatedResult<Food>> GetAllFoodAsync(int page, int limit, string? search, bool? status, string categoryName, bool? popular, bool? isPublic);
        Task<int> SaveChangesAsync();
        Task<Food> GetFoodByIdAsync(Guid foodId);
        Task<List<Food>> GetFoodByCategoryName(string categoryName);
        Task<Food> GetFoodByNameAsync(string foodName);
        Task<Food> GetByIdWithCategoriesAsync(Guid foodId);
        // void RemoveFoodCategories(Guid foodId);
        void RemoveFoodPortions(Guid foodId);
        Task<PaginatedResult<Food>> GetFoodByUserId(int page, int limit, Guid userId);
        Task<List<Food>> GetFoodsByCategoryNameAsync(string[] categoryNames);
        //dung cho FoodFilter
        Task<List<Food>> GetFoodsAsync(int Skip, int take);
        Task<List<Food>> GetFoodsExcludingIdsAsync(List<Guid> excludedFoodIds, int skip, int take);
        Task<int> GetTotalFoodCountAsync();
        Task<int> GetTotalFoodCountExcludingIdsAsync(List<Guid> excludedFoodIds);
        //FilterFood
        Task<IEnumerable<Food>> GetFoodsFilteredByAllergiesAsync(IEnumerable<string> allergies, int skip, int take);
        Task<int> GetTotalFoodCountFilteredByAllergiesAsync(IEnumerable<string> allergies);
        //phan trang cho FilerFood
        Task<PaginatedResult<Food>> GetPaginatedFoodsAsync(int skip, int take);
        Task<PaginatedResult<Food>> GetPaginatedFoodsExcludingIdsAsync(IEnumerable<Guid> excludedFoodIds, int skip, int take);
        Task<PaginatedResult<Food>> GetPaginatedFoodsByCategoryIdsAsync(IEnumerable<Guid> categoryIds, int skip, int take);

        Task<PaginatedResult<Food>> GetPaginatedFoodsByFiltersAsync(
            List<Guid> categoryIds,
            List<Guid> excludedFoodIds,
            List<string>? mealTypeFilter,
            List<string>? dishTypeFilter,

            int skip,
            int take);
        //dung cho randomFood
        Task<Nutrition?> GetNutritionByFoodIdAsync(Guid foodId);
        Task<List<Nutrition>> GetNutritionByFoodIdsAsync(List<Guid> foodIds);

    }
}
