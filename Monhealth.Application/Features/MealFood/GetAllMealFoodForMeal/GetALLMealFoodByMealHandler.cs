using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Nutrition.Queries.GetNutritionDetail;

namespace Monhealth.Application.Features.MealFood.GetAllMealFoodForMeal
{
    public class GetALLMealFoodByMealHandler : IRequestHandler<GetALLMealFoodByMealQuery, List<GetALLMealFoodByMealDTO>>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IPortionRepository _portionRepository;

        public GetALLMealFoodByMealHandler(IMealRepository mealRepository,
        IMealFoodRepository mealFoodRepository,
        IPortionRepository portionRepository)
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
        }

        public async Task<List<GetALLMealFoodByMealDTO>> Handle(GetALLMealFoodByMealQuery request, CancellationToken cancellationToken)
        {
            var query = await _mealRepository.GetAllMealFoodForMeal(request.MealId);
            var result = new List<GetALLMealFoodByMealDTO>();

            if (query == null)
                throw new Exception("Bữa ăn không tồn tại");

            foreach (var meal in query)
            {
                float totalCalories = 0;
                float totalProtein = 0;
                float totalCarbs = 0;
                float totalFat = 0;
                float totalFiber = 0;
                float totalSugar = 0;

                var items = new List<MealFoodDTO5>();

                foreach (var mealFood in meal.MealFoods)
                {
                    var portion = mealFood.PortionId != Guid.Empty
                        ? await _portionRepository.GetByIdAsync(mealFood.PortionId)
                        : null;

                    float calories = 0, protein = 0, carbs = 0, fat = 0, fiber = 0, sugar = 0;

                    if (mealFood.Food?.Nutrition != null && portion != null)
                    {
                        var portionWeight = portion.PortionWeight;

                        // Tính toán giá trị dinh dưỡng
                        calories = (mealFood.Food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                        protein = (mealFood.Food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                        carbs = (mealFood.Food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                        fat = (mealFood.Food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
                        fiber = (mealFood.Food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                        sugar = (mealFood.Food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);

                        // Cộng dồn vào giá trị dinh dưỡng tổng cộng nếu Status == true
                        if (mealFood.IsCompleted == true)
                        {
                            totalCalories += calories;
                            totalProtein += protein;
                            totalCarbs += carbs;
                            totalFat += fat;
                            totalFiber += fiber;
                            totalSugar += sugar;
                        }
                    }

                    // Tạo đối tượng MealFoodDTO5 (luôn gán giá trị bất kể Status)
                    var mealFoodDTO = new MealFoodDTO5
                    {
                        MealFoodId = mealFood.MealFoodId,
                        FoodId = mealFood.FoodId,
                        FoodName = mealFood.Food?.FoodName ?? string.Empty,
                        IsCompleted = mealFood.IsCompleted,
                        Quantity = mealFood.Quantity,
                        Calories = calories, // Giá trị luôn được tính toán
                        Portion = new MealFoodPortion5
                        {
                            MeasurementUnit = portion?.MeasurementUnit ?? string.Empty,
                            PortionSize = portion?.PortionSize ?? string.Empty,
                            PortionWeight = portion?.PortionWeight ?? 0
                        }
                    };

                    // Thêm vào danh sách Items
                    items.Add(mealFoodDTO);
                }

                // Tạo đối tượng Meal DTO
                var mealDTO = new GetALLMealFoodByMealDTO
                {
                    UserId = meal.UserId,
                    MealId = meal.MealId,
                    MealType = meal.MealType,
                    CreatedAt = meal.CreatedAt,
                    UpdatedAt = meal.UpdatedAt,
                    Nutrition = new MealFoodNutritionDTO5
                    {
                        Calories = totalCalories,
                        Protein = totalProtein,
                        Carbs = totalCarbs,
                        Fat = totalFat,
                        Fiber = totalFiber,
                        Sugar = totalSugar
                    },
                    Items = items // Gán danh sách Items vào DTO
                };

                // Thêm Meal DTO vào kết quả
                result.Add(mealDTO);
            }

            return result;
        }

    }
}
