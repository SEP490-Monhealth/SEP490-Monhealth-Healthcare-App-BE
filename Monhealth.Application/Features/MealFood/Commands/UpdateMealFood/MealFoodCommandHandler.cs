using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.MealFood.Commands.UpdateMealFood
{
    public class MealFoodCommandHandler : IRequestHandler<MealFoodCommand, bool>
    {
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IDailyMealRepository _dailyMealRepository;


        public MealFoodCommandHandler(IMealFoodRepository mealFoodRepository,
        IMealRepository mealRepository,
        IDailyMealRepository dailyMealRepository)
        {
            _mealFoodRepository = mealFoodRepository;
            _mealRepository = mealRepository;
            _dailyMealRepository = dailyMealRepository;
        }

        public async Task<bool> Handle(MealFoodCommand request, CancellationToken cancellationToken)
        {
            // 1. Lấy MealFood
            var mealFood = await _mealFoodRepository.GetByIdAsync(request.MealFoodId);
            if (mealFood == null) throw new Exception("MealFood không tồn tại.");

            // 2. Lấy Meal liên quan
            var meal = await _mealRepository.GetByIdAsync(mealFood.MealId);
            if (meal == null) throw new Exception("Meal không tồn tại.");

            // 3. Lấy DailyMeal liên quan
            var dailyMeal = meal.DailyMealId.HasValue
                ? await _dailyMealRepository.GetByIdAsync(meal.DailyMealId.Value)
                : null;

            if (request.Quantity == 0)
            {
                // 4. Xóa MealFood
                _mealFoodRepository.Remove(mealFood);
                await _mealFoodRepository.SaveChangeAsync();

                // 5. Kiểm tra nếu Meal không còn MealFood nào
                var remainingMealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);
                if (!remainingMealFoods.Any())
                {
                    _mealRepository.Remove(meal);
                    await _mealRepository.SaveChangeAsync();

                    // 6. Kiểm tra nếu DailyMeal không còn Meal nào
                    if (dailyMeal != null)
                    {
                        var remainingMeals = await _mealRepository.GetMealsByDailyMealId(dailyMeal.DailyMealId);
                        if (!remainingMeals.Any())
                        {
                            _dailyMealRepository.Remove(dailyMeal);
                            await _dailyMealRepository.SaveChangeAsync();
                        }
                    }
                }
            }
            else
            {
                // 7. Cập nhật Quantity của MealFood
                mealFood.Quantity = request.Quantity;
                mealFood.UpdatedAt = DateTime.Now;
                _mealFoodRepository.Update(mealFood);
                await _mealFoodRepository.SaveChangeAsync();

                // 8. Tính toán lại giá trị dinh dưỡng của DailyMeal
                if (dailyMeal != null)
                {
                    // Reset giá trị của DailyMeal
                    dailyMeal.TotalCalories = 0;
                    dailyMeal.TotalProteins = 0;
                    dailyMeal.TotalCarbs = 0;
                    dailyMeal.TotalFats = 0;
                    dailyMeal.TotalFibers = 0;
                    dailyMeal.TotalSugars = 0;

                    // Lấy toàn bộ Meal liên quan đến DailyMeal
                    var meals = await _mealRepository.GetMealsByDailyMealId(dailyMeal.DailyMealId);
                    foreach (var relatedMeal in meals)
                    {
                        var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(relatedMeal.MealId);

                        foreach (var foodItem in mealFoods)
                        {
                            var food = foodItem.Food;
                            if (food == null || food.Nutrition == null) continue;

                            var portionWeight = food.FoodPortions.FirstOrDefault()?.Portion?.PortionWeight ?? 1;

                            dailyMeal.TotalCalories += (food.Nutrition.Calories / 100) * (foodItem.Quantity * portionWeight);
                            dailyMeal.TotalProteins += (food.Nutrition.Protein / 100) * (foodItem.Quantity * portionWeight);
                            dailyMeal.TotalCarbs += (food.Nutrition.Carbs / 100) * (foodItem.Quantity * portionWeight);
                            dailyMeal.TotalFats += (food.Nutrition.Fat / 100) * (foodItem.Quantity * portionWeight);
                            dailyMeal.TotalFibers += (food.Nutrition.Fiber / 100) * (foodItem.Quantity * portionWeight);
                            dailyMeal.TotalSugars += (food.Nutrition.Sugar / 100) * (foodItem.Quantity * portionWeight);
                        }
                    }

                    // Cập nhật DailyMeal
                    dailyMeal.UpdatedAt = DateTime.Now;
                    _dailyMealRepository.Update(dailyMeal);
                    await _dailyMealRepository.SaveChangeAsync();
                }
            }

            return true;
        }


    }
}