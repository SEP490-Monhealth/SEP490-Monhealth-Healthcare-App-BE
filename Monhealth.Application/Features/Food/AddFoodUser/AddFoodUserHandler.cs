using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Food.AddFoodUser
{
    public class AddFoodUserHandler : IRequestHandler<AddFoodUserRequest, bool>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly INutritionRepository _nutritionRepository;
        public AddFoodUserHandler(IFoodRepository foodRepository,
        IPortionRepository portionRepository,
        INutritionRepository nutritionRepository)
        {
            _foodRepository = foodRepository;
            _portionRepository = portionRepository;
            _nutritionRepository = nutritionRepository;
        }

        public async Task<bool> Handle(AddFoodUserRequest request, CancellationToken cancellationToken)
        {

            var existingFood = await _foodRepository.GetFoodByNameAsync(request.FoodName);
            if (existingFood != null) throw new Exception("món ăn đã tồn tại");

            var food = new Monhealth.Domain.Food
            {
                UserId = request.UserId,
                FoodName = request.FoodName,
                FoodDescription = request.FoodDescription,
                ReferenceUrl = request.ReferenceUrl,
                FoodPortions = new List<FoodPortion>(),
                Status = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsPublic = request.IsPublic
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
                Calcium = request.Nutrition.Calcium,
                Cholesterol = request.Nutrition.Cholesterol,
                Iron = request.Nutrition.Iron,
                Potassium = request.Nutrition.Potassium,
                SaturatedFat = request.Nutrition.SaturatedFat,
                Sodium = request.Nutrition.Sodium,
                UnsaturatedFat = request.Nutrition.UnsaturatedFat,
                VitaminA = request.Nutrition.VitaminA,
                VitaminB1 = request.Nutrition.VitaminB1,
                VitaminB2 = request.Nutrition.VitaminB2,
                VitaminC = request.Nutrition.VitaminC,
                VitaminD = request.Nutrition.VitaminD,
                VitaminE = request.Nutrition.VitaminE,
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