using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.MealFood.Commands.UpdateMealFood
{
    public class MealFoodCommandHandler : IRequestHandler<MealFoodCommand, bool>
    {
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IPortionRepository _portionRepository;


        public MealFoodCommandHandler(IMealFoodRepository mealFoodRepository,
        IMealRepository mealRepository,
        IDailyMealRepository dailyMealRepository,
        IPortionRepository portionRepository)
        {
            _mealFoodRepository = mealFoodRepository;
            _mealRepository = mealRepository;
            _dailyMealRepository = dailyMealRepository;
            _portionRepository = portionRepository;
        }

        public async Task<bool> Handle(MealFoodCommand request, CancellationToken cancellationToken)
        {
            // 1. Lấy MealFood
            var mealFood = await _mealFoodRepository.GetByIdAsync(request.MealFoodId);
            if (mealFood == null) throw new Exception("MealFood không tồn tại");

            // 2. Lấy Meal liên quan
            var meal = await _mealRepository.GetByIdAsync(mealFood.MealId);
            if (meal == null) throw new Exception("Meal không tồn tại");

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
                        else
                        {
                            await RecalculateDailyMealNutrition(dailyMeal);
                        }
                    }
                }
                else
                {
                    await RecalculateDailyMealNutrition(dailyMeal);
                }
            }
            else
            {
                // 7. Cập nhật Quantity của MealFood
                mealFood.Quantity = request.Quantity;
                mealFood.UpdatedAt = DateTime.Now;
                _mealFoodRepository.Update(mealFood);
                await _mealFoodRepository.SaveChangeAsync();

                // 8. Tính toán lại toàn bộ giá trị dinh dưỡng của DailyMeal
                if (dailyMeal != null)
                {
                    await RecalculateDailyMealNutrition(dailyMeal);
                }
            }

            return true;
        }

        private async Task RecalculateDailyMealNutrition(Monhealth.Domain.DailyMeal dailyMeal)
        {
            if (dailyMeal == null) return;

            // Reset giá trị dinh dưỡng
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
                foreach (var foodItem in mealFoods)
                {
                    if (foodItem.Quantity <= 0) continue;

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

            dailyMeal.UpdatedAt = DateTime.Now;
            _dailyMealRepository.Update(dailyMeal);
            await _dailyMealRepository.SaveChangeAsync();
        }




    }
}