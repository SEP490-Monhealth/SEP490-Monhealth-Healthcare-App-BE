using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser
{
    public class GetDailyMealByUserHandler : IRequestHandler<GetDailyMealByUserQuery, GetDailyMealByUserDTO>
    {
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IPortionRepository _portionRepository;

        public GetDailyMealByUserHandler(
            IDailyMealRepository dailyMealRepository,
            IMealRepository mealRepository,
            IPortionRepository portionRepository)
        {
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
            _portionRepository = portionRepository;
        }

        public async Task<GetDailyMealByUserDTO> Handle(GetDailyMealByUserQuery request, CancellationToken cancellationToken)
        {
            var query = await _dailyMealRepository.GetDailyMealsByUser(request.UseId, request.date);

            if (query == null)
            {
                return new GetDailyMealByUserDTO
                {
                    DailyMealId = Guid.Empty,
                    Nutrition = null,
                    Items = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };
            }

            // Lấy danh sách toàn bộ Meals từ MealRepository
            var mealQuery = await _mealRepository.GetAllMeals();
            var mealTypeOrder = new List<string> { "Breakfast", "Lunch", "Dinner", "Snack" };

            // Lọc danh sách Meal từ danh sách toàn bộ Meals bằng DailyMeal.Meals
            var meals = new List<MealForDailyMeal2>();

            foreach (var meal in mealQuery.Where(m => query.Meals.Select(dm => dm.MealId).Contains(m.MealId)))
            {
                float totalCalories = 0;
                float totalProtein = 0;
                float totalCarbs = 0;
                float totalFat = 0;
                float totalFiber = 0;
                float totalSugar = 0;

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
                        totalFiber += (mealFood.Food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                        totalSugar += (mealFood.Food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);

                    }
                    // Lấy Portion từ repository
                }
                int totalFoods = meal.MealFoods.Count(mealFood => mealFood.Food?.Nutrition != null && mealFood.PortionId != Guid.Empty);

                meals.Add(new MealForDailyMeal2
                {
                    mealId = meal.MealId,
                    MealType = meal.MealType,
                    Foods = totalFoods,
                    Calories = totalCalories,
                    Protein = totalProtein,
                    Carbs = totalCarbs,
                    Fat = totalFat,
                    Fiber = totalFiber,
                    Sugar = totalSugar
                });
            }

            // Tạo đối tượng Nutrition
            var nutrition = new NutritionOfDailyMeal2
            {
                TotalCalories = query.TotalCalories,
                TotalProteins = query.TotalProteins,
                TotalCarbs = query.TotalCarbs,
                TotalFats = query.TotalFats,
                TotalFibers = query.TotalFibers,
                TotalSugars = query.TotalSugars
            };
            // var goal = new GoalDailyMealDTO2
            // {
            //     CaloriesGoal = query.Goal?.CaloriesGoal ?? 0, // Gán giá trị 0 nếu Goal hoặc CaloriesGoal là null
            //     CarbsGoal = query.Goal?.CarbsGoal ?? 0,
            //     FatGoal = query.Goal?.FatGoal ?? 0,
            //     FiberGoal = query.Goal?.FiberGoal ?? 0,
            //     GoalType = query.Goal?.GoalType.ToString() ?? string.Empty, // Gán chuỗi rỗng nếu GoalType null
            //     ProteinGoal = query.Goal?.ProteinGoal ?? 0,
            //     SugarGoal = query.Goal?.SugarGoal ?? 0,
            // };

            var sortedMeals = meals
            .OrderBy(m => mealTypeOrder.IndexOf(m.MealType.ToString()))
            .ToList();

            // Tạo đối tượng DailyMealDTO
            var dailyMealDTO = new GetDailyMealByUserDTO
            {
                DailyMealId = query.DailyMealId,
                Nutrition = nutrition,
                // Goal = goal,
                Items = sortedMeals,
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt
            };

            return dailyMealDTO;
        }
    }
}
