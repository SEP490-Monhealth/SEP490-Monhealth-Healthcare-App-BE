using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Meal.Commands.DeleteMeal
{
    public class DeleteCommandHandler : IRequestHandler<DeleteMealCommand, bool>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;

        public DeleteCommandHandler(
                   IMealRepository mealRepository,
                   IMealFoodRepository mealFoodRepository,
                   IDailyMealRepository dailyMealRepository)
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _dailyMealRepository = dailyMealRepository;
        }

        public async Task<bool> Handle(DeleteMealCommand request, CancellationToken cancellationToken)
        {
            // Lấy Meal cần xóa
            var meal = await _mealRepository.GetByIdAsync(request.MealId);
            if (meal == null)
            {
                throw new KeyNotFoundException("Meal không tồn tại.");
            }

            // Lấy DailyMeal liên quan
            var dailyMeal = await _dailyMealRepository.GetByIdAsync(meal.DailyMealId.Value);
            if (dailyMeal == null)
            {
                throw new Exception("DailyMeal không tồn tại.");
            }

            // Lấy tất cả MealFood liên quan đến Meal
            var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);

            foreach (var mealFood in mealFoods)
            {
                var food = mealFood.Food;
                var portionWeight = food.FoodPortions.FirstOrDefault()?.Portion.PortionWeight ?? 1;

                // Cập nhật các trường trong DailyMeal
                dailyMeal.TotalCalories -= (food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                dailyMeal.TotalProteins -= (food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                dailyMeal.TotalCarbs -= (food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                dailyMeal.TotalFats -= (food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
                dailyMeal.TotalFibers -= (food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                dailyMeal.TotalSugars -= (food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);
            }

            // Xóa Meal
            _mealRepository.Remove(meal);
            await _mealRepository.SaveChangeAsync();

            // Kiểm tra nếu không còn Meal nào trong DailyMeal
            var remainingMeals = await _mealRepository.GetMealsByDailyMealId(dailyMeal.DailyMealId);
            if (remainingMeals == null || !remainingMeals.Any())
            {
                _dailyMealRepository.Remove(dailyMeal);
            }
            else
            {
                // Cập nhật DailyMeal
                dailyMeal.UpdatedAt = DateTime.Now;
                _dailyMealRepository.Update(dailyMeal);
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            await _dailyMealRepository.SaveChangeAsync();

            return true;
        }
    }

}
