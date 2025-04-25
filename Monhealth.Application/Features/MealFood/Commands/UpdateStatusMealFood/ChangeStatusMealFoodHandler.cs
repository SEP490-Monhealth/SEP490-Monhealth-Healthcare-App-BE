
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.MealFood.Commands.UpdateStatusMealFood
{
    public class ChangeStatusMealFoodHandler : IRequestHandler<ChangeStatusMealFoodQuery, bool>
    {
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IMealRepository _mealRepository;

        public ChangeStatusMealFoodHandler(IMealFoodRepository mealFoodRepository,
            IDailyMealRepository dailyMealRepository,
            IPortionRepository portionRepository,
            IMealRepository mealRepository)
        {
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
        }

        public async Task<bool> Handle(ChangeStatusMealFoodQuery request, CancellationToken cancellationToken)
        {
            var mealFood = await _mealFoodRepository.GetByIdAsync(request.MealFoodId);
            if (mealFood == null) throw new Exception("MealFood không tồn tại");

            // Đổi trạng thái của MealFood
            mealFood.IsCompleted = !mealFood.IsCompleted;
            _mealFoodRepository.Update(mealFood);
            await _mealFoodRepository.SaveChangeAsync();

            var meal = await _mealRepository.GetByIdAsync(mealFood.MealId);
            if (meal == null) throw new Exception("Meal không tồn tại");

            // Lấy DailyMeal liên quan
            var dailyMeal = meal.DailyMealId.HasValue
                ? await _dailyMealRepository.GetByIdAsync(meal.DailyMealId.Value)
                : null;

            if (dailyMeal != null)
            {
                // Tính lại giá trị dinh dưỡng của DailyMeal
                await RecalculateDailyMealNutrition(dailyMeal);
            }

            return true;
        }

        private async Task RecalculateDailyMealNutrition(Monhealth.Domain.DailyMeal dailyMeal)
        {
            if (dailyMeal == null) return;

            // Reset các giá trị dinh dưỡng
            dailyMeal.TotalCalories = 0;
            dailyMeal.TotalProteins = 0;
            dailyMeal.TotalCarbs = 0;
            dailyMeal.TotalFats = 0;
            dailyMeal.TotalFibers = 0;
            dailyMeal.TotalSugars = 0;

            // Lấy tất cả các Meal liên quan đến DailyMeal
            var meals = await _mealRepository.GetMealsByDailyMealId(dailyMeal.DailyMealId);
            foreach (var relatedMeal in meals)
            {
                var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(relatedMeal.MealId);

                // Chỉ tính giá trị dinh dưỡng của MealFood có status = true
                foreach (var foodItem in mealFoods.Where(f => (bool)f.IsCompleted))
                {
                    var relatedPortion = await _portionRepository.GetByIdAsync(foodItem.PortionId);
                    if (relatedPortion == null) continue;

                    var relatedFood = foodItem.Food;
                    if (relatedFood == null || relatedFood.Nutrition == null) continue;

                    var relatedPortionWeight = relatedPortion.PortionWeight;

                    dailyMeal.TotalCalories += (relatedFood.Nutrition.Calories / 100) * (foodItem.Quantity * relatedPortionWeight);
                    dailyMeal.TotalProteins += (relatedFood.Nutrition.Protein / 100) * (foodItem.Quantity * relatedPortionWeight);
                    dailyMeal.TotalCarbs += (relatedFood.Nutrition.Carbs / 100) * (foodItem.Quantity * relatedPortionWeight);
                    dailyMeal.TotalFats += (relatedFood.Nutrition.Fat / 100) * (foodItem.Quantity * relatedPortionWeight);
                    dailyMeal.TotalFibers += (relatedFood.Nutrition.Fiber / 100) * (foodItem.Quantity * relatedPortionWeight);
                    dailyMeal.TotalSugars += (relatedFood.Nutrition.Sugar / 100) * (foodItem.Quantity * relatedPortionWeight);
                }
            }

            // Cập nhật lại thời gian và lưu thay đổi
            dailyMeal.UpdatedAt = DateTime.UtcNow;
            _dailyMealRepository.Update(dailyMeal);
            await _dailyMealRepository.SaveChangeAsync();
        }
    }
}
