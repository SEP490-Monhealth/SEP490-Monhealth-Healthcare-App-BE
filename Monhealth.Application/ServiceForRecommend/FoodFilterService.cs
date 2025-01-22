using AutoMapper;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Food.Queries.GetAllFoods;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;


namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodFilterService
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IUserAllergyRepository _userAllergyRepository;
        private readonly IFoodAllergyRepository _foodAllergyRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<FoodFilterService> _logger;

        public FoodFilterService(IFoodRepository foodRepository,
        IFoodAllergyRepository foodAllergyRepository,
        IUserAllergyRepository userAllergyRepository,
        ILogger<FoodFilterService> logger,
        IMapper mapper)
        {
            _foodRepository = foodRepository;
            _userAllergyRepository = userAllergyRepository;
            _foodAllergyRepository = foodAllergyRepository;
            _logger = logger;
        }
        public async Task<PageResult<FoodFilterDTO>> GetFilterFoodAsync(Guid userId, int pageNumber, int pageSize)
        {
            // Kiểm tra và xử lý giá trị đầu vào
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0) pageSize = 10;

            // Lấy danh sách dị ứng của người dùng
            var userAllergyIds = await _userAllergyRepository.GetUserAllergiesByUserIdAsync(userId);

            // Nếu người dùng không có dị ứng
            if (userAllergyIds == null || !userAllergyIds.Any())
            {
                _logger.LogInformation($"Người dùng {userId} không có dị ứng nào. Trả về tất cả danh sách thức ăn.");

                // Lấy danh sách thức ăn không lọc
                var allFoods = await _foodRepository.GetFoodsAsync((pageNumber - 1) * pageSize, pageSize);
                var totalItems = await _foodRepository.GetTotalFoodCountAsync();

                return BuildPageResult(allFoods, totalItems, pageNumber, pageSize);
            }

            // Lấy danh sách món ăn cần loại trừ dựa trên dị ứng
            var excludedFoodIds = await _foodAllergyRepository.GetFoodIdsByAllergyIdsAsync(userAllergyIds);

            // Lấy danh sách món ăn sau khi loại trừ
            var filteredFoods = await _foodRepository.GetFoodsExcludingIdsAsync(excludedFoodIds, (pageNumber - 1) * pageSize, pageSize); // Đảm bảo có thứ tự
            var totalFilteredItems = await _foodRepository.GetTotalFoodCountExcludingIdsAsync(excludedFoodIds);

            _logger.LogInformation($"Người dùng {userId} có {filteredFoods.Count()} thức ăn sau khi đã lọc.");

            return BuildPageResult(filteredFoods, totalFilteredItems, pageNumber, pageSize);
        }

        // Phương thức tiện ích để xây dựng PageResult
        private PageResult<FoodFilterDTO> BuildPageResult(IEnumerable<Food> foods, int totalItems, int pageNumber, int pageSize)
        {
            if (foods == null || !foods.Any())
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

            // Ánh xạ từ Food sang FoodFilterDTO
            var foodDTOs = foods.Select(food => new FoodFilterDTO
            {
                FoodId = food.FoodId,
                FoodName = food.FoodName ?? string.Empty,
                Category = food.Category?.CategoryName ?? string.Empty,
                MealType = food.MealType ?? new List<string>(),
                DishType = food.DishType ?? new List<string>(),
              
            }).ToList();

            return new PageResult<FoodFilterDTO>
            {
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling((double)totalItems / pageSize),
                TotalItems = totalItems,
                Items = foodDTOs
            };
        }



    }
}