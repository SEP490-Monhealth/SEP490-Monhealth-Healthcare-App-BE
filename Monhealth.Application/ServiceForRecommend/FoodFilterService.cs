using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monteith.Application.Contracts.Persistence;

namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodFilterService
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IAllergyRepository _allergyRepository;
        private readonly IFoodAllergyRepository _foodAllergyRepository;
        private readonly ILogger<FoodFilterService> _logger;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserAllergyRepository _userAllergyRepository;
        private readonly IUserCategoryRepository _userCategoryRepository;

        public FoodFilterService(
            IFoodRepository foodRepository,
            IFoodAllergyRepository foodAllergyRepository,
            IAllergyRepository allergyRepository,
            ILogger<FoodFilterService> logger,
            ICategoryRepository categoryRepository,
            IUserAllergyRepository userAllergyRepository,
            IUserCategoryRepository userCategoryRepository)
        {
            _foodRepository = foodRepository;
            _allergyRepository = allergyRepository;
            _foodAllergyRepository = foodAllergyRepository;
            _logger = logger;
            _categoryRepository = categoryRepository;
            _userAllergyRepository = userAllergyRepository;
            _userCategoryRepository = userCategoryRepository;
        }

        public async Task<PageResult<FoodFilterDTO>> GetFilterFoodAsync(
            Guid userId,
            int pageNumber,
            int pageSize,
            List<string>? mealTypeFilter = null,
            List<string>? dishTypeFilter = null)
        {
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0) pageSize = 10;

            // Lấy danh sách dị ứng của người dùng
            var userAllergies = await _userAllergyRepository.GetUserAllergiesByUserId(userId);
            var allergyIds = userAllergies.Select(a => a.AllergyId).ToList();

            // Lấy danh mục mà người dùng đã chọn
            var userCategories = await _userCategoryRepository.GetUserCategoryByUserId(userId);
            var categoryIds = userCategories.Select(c => c.CategoryId).ToList();

            // Nếu không có danh mục nào được chọn, trả về rỗng
            if (!categoryIds.Any())
            {
                _logger.LogInformation($"Người dùng {userId} không chọn danh mục nào. Không trả về kết quả.");
                return new PageResult<FoodFilterDTO>
                {
                    CurrentPage = pageNumber,
                    TotalPages = 0,
                    TotalItems = 0,
                    Items = new List<FoodFilterDTO>()
                };
            }

            // Lấy danh sách FoodId bị loại trừ do dị ứng
            var excludedFoodIds = allergyIds.Any()
                ? await _foodAllergyRepository.GetFoodIdsByAllergyIdsAsync(allergyIds)
                : new List<Guid>();

            // Lọc danh sách thức ăn dựa trên danh mục và loại trừ các món có thành phần dị ứng
            var filteredFoodsPaginated = await _foodRepository.GetPaginatedFoodsByFiltersAsync(
                categoryIds, // Chỉ lấy món ăn thuộc danh mục này
                excludedFoodIds, // Loại bỏ món ăn có thành phần dị ứng
                mealTypeFilter,
                dishTypeFilter,
                (pageNumber - 1) * pageSize,
                pageSize);

            _logger.LogInformation($"Người dùng {userId} có {filteredFoodsPaginated.TotalCount} thức ăn sau khi đã lọc.");

            return BuildPageResult(filteredFoodsPaginated, pageNumber, pageSize);
        }

        private PageResult<FoodFilterDTO> BuildPageResult(PaginatedResult<Food> paginatedFoods, int pageNumber, int pageSize)
        {
            if (paginatedFoods == null || !paginatedFoods.Items.Any())
            {
                _logger.LogWarning("Danh sách thức ăn trống.");
                return new PageResult<FoodFilterDTO>
                {
                    CurrentPage = pageNumber,
                    TotalPages = 0,
                    TotalItems = 0,
                    Items = new List<FoodFilterDTO>()
                };
            }

            var foodDTOs = paginatedFoods.Items.Select(food => new FoodFilterDTO
            {
                FoodId = food.FoodId,
                FoodName = food.FoodName ?? string.Empty,
                Category = food.CategoryFoods.Select(fc => fc.Category.CategoryName).ToList(),
                MealType = food.MealType,
                DishType = food.DishType,
                FoodType = food.FoodType
            }).ToList();

            return new PageResult<FoodFilterDTO>
            {
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling((double)paginatedFoods.TotalCount / pageSize),
                TotalItems = paginatedFoods.TotalCount,
                Items = foodDTOs
            };
        }
    }
}
