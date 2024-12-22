using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Food.AddFood
{
    public class AddFoodHandle : IRequestHandler<AddFoodRequest, bool>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly INutritionRepository _nutritionRepository;
        public AddFoodHandle(IFoodRepository foodRepository,
        ICategoryRepository categoryRepository,
        IPortionRepository portionRepository,
        INutritionRepository nutritionRepository)
        {
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
            _portionRepository = portionRepository;
            _nutritionRepository = nutritionRepository;
        }

        public async Task<bool> Handle(AddFoodRequest request, CancellationToken cancellationToken)
        {
           
            var existingFood = await _foodRepository.GetFoodByNameAsync(request.FoodName);
            if (existingFood != null) throw new Exception("Món ăn đã tồn tại");

            var food = new Monhealth.Domain.Food
            {
                UserId = request.UserId,
                FoodName = request.FoodName,
                FoodType = "Public",
                FoodDescription = request.FoodDescription,
                FoodCategories = new List<FoodCategory>(),
                FoodPortions = new List<FoodPortion>(),
                Status = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                
            };

            // Xử lý danh mục (CategoryName)
            foreach (var categoryName in request.Category)
            {
                var category = await _categoryRepository.GetCategoryByCategoryName(categoryName);
                if (category == null)
                    throw new Exception("Danh mục không tồn tại.");

                food.FoodCategories.Add(new FoodCategory
                {
                    FoodId = food.FoodId,
                    CategoryId = category.CategoryId
                });
            }
            _foodRepository.Add(food);
            await _foodRepository.SaveChangesAsync();
            var nutrition = new Monhealth.Domain.Nutrition
            {
                FoodId = food.FoodId,
                Calories = request.Nutrition.Calories,
                Carbs = request.Nutrition.Carbs,
                Fat = request.Nutrition.Fat,
                Fiber = request.Nutrition.Fiber,
                Protein = request.Nutrition.Protein,
                Sugar = request.Nutrition.Sugar,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _nutritionRepository.Add(nutrition);
            // Kiểm tra xem Portion đã tồn tại chưa
            var existingPortion = await _portionRepository.GetPortionAsync(
                request.Portion.MeasurementUnit,
                request.Portion.PortionSize,
                request.Portion.PortionWeight
            );

            Portion portion;
            if (existingPortion != null)
            {
                // Nếu Portion đã tồn tại, sử dụng lại
                portion = existingPortion;
            }
            else
            {
                // Nếu Portion chưa tồn tại, tạo mới
                portion = new Portion
                {
                    PortionId = Guid.NewGuid(),
                    MeasurementUnit = request.Portion.MeasurementUnit,
                    PortionSize = request.Portion.PortionSize,
                    PortionWeight = request.Portion.PortionWeight,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                _portionRepository.Add(portion);
            }

            // Liên kết Portion với Food qua FoodPortion
            food.FoodPortions.Add(new FoodPortion
            {
                FoodId = food.FoodId,
                PortionId = portion.PortionId
            });

            await _foodRepository.SaveChangesAsync();
            return true;
        }


    }


}
