using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Meal.Queries.GetAllMeals
{
    public class GetMealListQueryHandler : IRequestHandler<GetMealListQuery, List<MealDTO>>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IPortionRepository _portionRepository;

        public GetMealListQueryHandler(IMealRepository mealRepository, IPortionRepository portionRepository)
        {
            _mealRepository = mealRepository;
            _portionRepository = portionRepository;
        }

        public async Task<List<MealDTO>> Handle(GetMealListQuery request, CancellationToken cancellationToken)
        {
            var meals = await _mealRepository.GetAllMeals();
            // if (meals == null || !meals.Any())
            //     throw new Exception("Không có bữa ăn nào");

            var result = new List<MealDTO>();

            foreach (var meal in meals)
            {
                // Khởi tạo giá trị dinh dưỡng
                float totalCalories = 0;
                float totalProtein = 0;
                float totalCarbs = 0;
                float totalFat = 0;
                float totalFiber = 0;
                float totalSugar = 0;

                foreach (var mealFood in meal.MealFoods)
                {
                    if (mealFood.Status == true)
                    {
                        if (mealFood.Food?.Nutrition == null || mealFood.PortionId == Guid.Empty)
                            continue;

                        // Lấy portion từ repository
                        var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                        if (portion == null)
                            continue;

                        var portionWeight = portion.PortionWeight;

                        // Tính toán giá trị dinh dưỡng
                        totalCalories += (mealFood.Food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                        totalProtein += (mealFood.Food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                        totalCarbs += (mealFood.Food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                        totalFat += (mealFood.Food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
                        totalFiber += (mealFood.Food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                        totalSugar += (mealFood.Food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);

                    }
                }

                // Tạo DTO cho meal
                var mealDTO = new MealDTO
                {
                    MealId = meal.MealId,
                    UserId = meal.UserId,
                    MealType = meal.MealType,
                    Nutrition = new MealFoodNutritionDTO
                    {
                        Calories = totalCalories,
                        Protein = totalProtein,
                        Carbs = totalCarbs,
                        Fat = totalFat,
                        Fiber = totalFiber,
                        Sugar = totalSugar
                    },
                    CreatedAt = meal.CreatedAt,
                    UpdatedAt = meal.UpdatedAt
                };

                result.Add(mealDTO);
            }

            return result;
        }
    }
}
