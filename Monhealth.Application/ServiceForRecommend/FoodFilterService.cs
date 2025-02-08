using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodFilterService
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IUserFoodRepository _userFoodRepository;
        private readonly IAllergyRepository _allergyRepository;
        private readonly IFoodAllergyRepository _foodAllergyRepository;
        private readonly ILogger<FoodFilterService> _logger;
        private readonly ICategoryRepository _categoryRepository;

        public FoodFilterService(
            IFoodRepository foodRepository,
            IFoodAllergyRepository foodAllergyRepository,
            IUserFoodRepository userFoodRepository,
            IAllergyRepository allergyRepository,
            ILogger<FoodFilterService> logger,
            ICategoryRepository categoryRepository)
        {
            _foodRepository = foodRepository;
            _userFoodRepository = userFoodRepository;
            _allergyRepository = allergyRepository;
            _foodAllergyRepository = foodAllergyRepository;
            _logger = logger;
            _categoryRepository = categoryRepository;
        }

        public async Task<PageResult<FoodFilterDTO>> GetFilterFoodAsync(
        Guid userId,
        int pageNumber,
        int pageSize,
        List<string>? mealTypeFilter = null,
        List<string>? dishTypeFilter = null)
        {
            // Kiểm tra và xử lý giá trị đầu vào
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0) pageSize = 10;

            // Lấy thông tin UserFood
            var userFood = await _userFoodRepository.GetUserFoodByUserIdAsync(userId);

            // Kiểm tra danh sách dị ứng hoặc danh mục
            if (userFood == null ||
                (userFood.Allergies == null || !userFood.Allergies.Any()) &&
                (userFood.Categories == null || !userFood.Categories.Any()))
            {
                _logger.LogInformation($"Người dùng {userId} không có dị ứng hoặc danh mục nào. Trả về tất cả danh sách thức ăn.");

                var allFoodsPaginated = await _foodRepository.GetPaginatedFoodsAsync((pageNumber - 1) * pageSize, pageSize);
                return BuildPageResult(allFoodsPaginated, pageNumber, pageSize);
            }

            // Chuẩn hóa danh sách dị ứng
            var allergyNames = userFood.Allergies?.Select(a => a.Trim().ToLower()).ToList() ?? new List<string>();

            // Chuẩn hóa danh sách danh mục
            var categoryNames = userFood.Categories?.Select(c => c.Trim().ToLower()).ToList() ?? new List<string>();

            // Lấy danh sách AllergyId từ AllergyNames
            var allergyIds = await _allergyRepository.GetAllergyIdsByNamesAsync(allergyNames);

            // Lấy danh sách CategoryId từ CategoryNames
            var categoryIds = await _categoryRepository.GetCategoryIdsByNamesAsync(categoryNames);

            // Nếu không có dị ứng và danh mục hợp lệ
            if (!allergyIds.Any() && !categoryIds.Any())
            {
                _logger.LogInformation($"Không tìm thấy dị ứng hoặc danh mục nào hợp lệ cho người dùng {userId}. Trả về tất cả thức ăn.");
                var allFoodsPaginated = await _foodRepository.GetPaginatedFoodsAsync((pageNumber - 1) * pageSize, pageSize);
                return BuildPageResult(allFoodsPaginated, pageNumber, pageSize);
            }

            // Lấy danh sách FoodId liên quan đến AllergyId
            var excludedFoodIds = allergyIds.Any()
                ? await _foodAllergyRepository.GetFoodIdsByAllergyIdsAsync(allergyIds)
                : new List<Guid>();

            // Lọc danh sách thức ăn theo danh mục hợp lệ và thêm bộ lọc MealType, DishType
            var filteredFoodsPaginated = await _foodRepository.GetPaginatedFoodsByFiltersAsync(
                categoryIds,
                excludedFoodIds,
                mealTypeFilter,
                dishTypeFilter,

                (pageNumber - 1) * pageSize,
                pageSize);

            _logger.LogInformation($"Người dùng {userId} có {filteredFoodsPaginated.TotalCount} thức ăn sau khi đã lọc.");
            return BuildPageResult(filteredFoodsPaginated, pageNumber, pageSize);
        }

        // Phương thức tiện ích để xây dựng PageResult từ PaginatedResult
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
                Category = food.Category?.CategoryName ?? string.Empty,
                MealType = food.MealType,
                DishType = food.DishType,
                FoodType = food.FoodType // 🛠 Đảm bảo ánh xạ từ Food -> FoodFilterDTO
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
