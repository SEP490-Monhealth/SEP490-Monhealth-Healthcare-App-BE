using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Food.AddFoodUser
{
    public class AddFoodUserHandler : IRequestHandler<AddFoodUserRequest, bool>
    {

        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly INutritionRepository _nutritionRepository;
        public AddFoodUserHandler(IFoodRepository foodRepository,
        ICategoryRepository categoryRepository,
        IPortionRepository portionRepository,
        INutritionRepository nutritionRepository)
        {
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
            _portionRepository = portionRepository;
            _nutritionRepository = nutritionRepository;
        }

        public async Task<bool> Handle(AddFoodUserRequest request, CancellationToken cancellationToken)
        {

            var existingFood = await _foodRepository.GetFoodByNameAsync(request.FoodName);
            if (existingFood != null) throw new Exception("món ăn đã tồn tại");
            if (request.FoodType != "Public" && request.FoodType != "User")
            {
                throw new Exception("FoodType chỉ được nhập Public hoặc User.");
            }

            var food = new Monhealth.Domain.Food
            {
                UserId = request.UserId,
                FoodName = request.FoodName,
                FoodType = request.FoodType,
                FoodDescription = request.FoodDescription,
                FoodPortions = new List<FoodPortion>(),
                Status = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

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
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
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