using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetAllDailyMeal
{
    public class GetDailyMealQueryHandler : IRequestHandler<GetDailyMealQuery, List<DailyMealDTO>>
    {
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IPortionRepository _portionRepository;

        public GetDailyMealQueryHandler(
            IDailyMealRepository dailyMealRepository,
            IMealRepository mealRepository,
            IPortionRepository portionRepository)
        {
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
            _portionRepository = portionRepository;
        }

        public async Task<List<DailyMealDTO>> Handle(GetDailyMealQuery request, CancellationToken cancellationToken)
        {
            var dailyMeals = await _dailyMealRepository.GetAllDailyMeals();
            var allMeals = await _mealRepository.GetAllMeals(); // Lấy tất cả Meals từ MealRepository

            var mealTypeOrder = new List<string> { "Breakfast", "Lunch", "Dinner", "Snack" };
            var result = new List<DailyMealDTO>();

            foreach (var dailyMeal in dailyMeals)
            {
                // Lọc danh sách Meal từ danh sách toàn bộ Meals bằng DailyMeal.Meals
                var meals = new List<MealForDailyMeal>();

                foreach (var meal in allMeals.Where(m => dailyMeal.Meals.Select(dm => dm.MealId).Contains(m.MealId)))
                {

                    float totalCalories = 0;
                    float totalProtein = 0;
                    float totalCarbs = 0;
                    float totalFat = 0;

                    // Sắp xếp danh sách meals theo thứ tự MealType

                    foreach (var mealFood in meal.MealFoods)
                    {
                        if (mealFood.Food?.Nutrition == null || mealFood.PortionId == Guid.Empty)
                            continue;
                        if (mealFood.Status == true)
                        {
                            var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                            if (portion == null)
                                continue;

                            var portionWeight = portion.PortionWeight;

                            // Tính toán giá trị dinh dưỡng
                            totalCalories += (mealFood.Food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                            totalProtein += (mealFood.Food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                            totalCarbs += (mealFood.Food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                            totalFat += (mealFood.Food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);

                        }
                        // Lấy Portion từ repository
                    }

                    meals.Add(new MealForDailyMeal
                    {
                        mealId = meal.MealId,
                        MealType = meal.MealType,
                        Calories = totalCalories,
                        Protein = totalProtein,
                        Carbs = totalCarbs,
                        Fat = totalFat
                    });
                }
                var sortedMeals = meals
               .OrderBy(m => mealTypeOrder.IndexOf(m.MealType))
               .ToList();

                // Tạo đối tượng DailyMealDTO
                var dailyMealDTO = new DailyMealDTO
                {
                    DailyMealId = dailyMeal.DailyMealId,
                    UserId = dailyMeal.UserId,
                    Nutrition = new NutritionOfDailyMeal
                    {
                        TotalCalories = dailyMeal.TotalCalories,
                        TotalProteins = dailyMeal.TotalProteins,
                        TotalCarbs = dailyMeal.TotalCarbs,
                        TotalFats = dailyMeal.TotalFats,
                        TotalFibers = dailyMeal.TotalFibers,
                        TotalSugars = dailyMeal.TotalSugars
                    },
                    Items = sortedMeals,
                    CreatedAt = dailyMeal.CreatedAt,
                    UpdatedAt = dailyMeal.UpdatedAt
                };

                result.Add(dailyMealDTO);
            }

            return result;
        }
    }
}
