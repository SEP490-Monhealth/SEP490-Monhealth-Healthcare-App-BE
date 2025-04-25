using System.Transactions;
using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.MealFood.Commands.UpdateMealFood
{
    public class MealFoodCommandHandler : IRequestHandler<MealFoodCommand, bool>
    {
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly ILogger<MealFoodCommandHandler> _logger;

        public MealFoodCommandHandler(
            IMealFoodRepository mealFoodRepository,
            IMealRepository mealRepository,
            IDailyMealRepository dailyMealRepository,
            IPortionRepository portionRepository,
            ILogger<MealFoodCommandHandler> logger)
        {
            _mealFoodRepository = mealFoodRepository;
            _mealRepository = mealRepository;
            _dailyMealRepository = dailyMealRepository;
            _portionRepository = portionRepository;
            _logger = logger;
        }

        public async Task<bool> Handle(MealFoodCommand request, CancellationToken cancellationToken)
        {
            using var tx = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

            // Lấy MealFood
            var mealFood = await _mealFoodRepository.GetByMealFoodIdAsync(request.MealFoodId)
                ?? throw new ArgumentException("MealFood không tồn tại.");

            // Kiểm tra nếu IsComplete không phải là true thì không cho phép thực hiện cập nhật các thông số dinh dưỡng
            var canUpdateNutrition = mealFood.IsCompleted;

            // Lấy Meal
            var meal = await _mealRepository.GetByIdAsync(mealFood.MealId)
                ?? throw new ArgumentException("Meal không tồn tại.");

            // Lấy DailyMeal nếu có
            Domain.DailyMeal dailyMeal = null;
            if (meal.DailyMealId.HasValue)
                dailyMeal = await _dailyMealRepository.GetByIdAsync(meal.DailyMealId.Value);

            // Xử lý cho Quantity = 0 (xoá món)
            if (request.Quantity == 0)
            {
                // 1. Tính calories bị xoá
                var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId)
                              ?? throw new ArgumentException($"Portion {mealFood.PortionId} không tồn tại.");
                var nut = mealFood.Food?.Nutrition
                          ?? throw new ArgumentException($"Nutrition cho FoodId {mealFood.FoodId} không đầy đủ.");
                var removedCalories = mealFood.Quantity * portion.PortionWeight * nut.Calories / 100f;
                var removedProteins = mealFood.Quantity * portion.PortionWeight * nut.Protein / 100f;
                var removedCarbs = mealFood.Quantity * portion.PortionWeight * nut.Carbs / 100f;
                var removedFats = mealFood.Quantity * portion.PortionWeight * nut.Fat / 100f;
                var removedFibers = mealFood.Quantity * portion.PortionWeight * nut.Fiber / 100f;
                var removedSugars = mealFood.Quantity * portion.PortionWeight * nut.Sugar / 100f;

                // 2. Xoá MealFood
                _mealFoodRepository.Remove(mealFood);
                await _mealFoodRepository.SaveChangeAsync();

                // 3. Nếu meal không còn food thì xoá luôn meal
                var remFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);
                if (!remFoods.Any())
                {
                    _mealRepository.Remove(meal);
                    await _mealRepository.SaveChangeAsync();
                }

                // 4. Cập nhật DailyMeal nếu có và IsComplete là true
                if (canUpdateNutrition && dailyMeal != null)
                {
                    var remMeals = await _mealRepository.GetMealsByDailyMealId(dailyMeal.DailyMealId);
                    if (!remMeals.Any())
                    {
                        // Nếu không còn bữa nào trong ngày, xoá DailyMeal
                        _dailyMealRepository.Remove(dailyMeal);
                        await _dailyMealRepository.SaveChangeAsync();
                    }
                    else
                    {
                        // Trừ đúng số calories đã xoá cho tất cả các chỉ số
                        dailyMeal.TotalCalories -= removedCalories;
                        dailyMeal.TotalProteins -= removedProteins;
                        dailyMeal.TotalCarbs -= removedCarbs;
                        dailyMeal.TotalFats -= removedFats;
                        dailyMeal.TotalFibers -= removedFibers;
                        dailyMeal.TotalSugars -= removedSugars;

                        dailyMeal.UpdatedAt = DateTime.UtcNow;
                        _dailyMealRepository.Update(dailyMeal);
                        await _dailyMealRepository.SaveChangeAsync();
                    }
                }
            }
            else
            {
                // Xử lý cập nhật Quantity > 0
                var oldQuantity = mealFood.Quantity;
                var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId)
                              ?? throw new ArgumentException($"Portion {mealFood.PortionId} không tồn tại.");
                var nut = mealFood.Food?.Nutrition
                          ?? throw new ArgumentException($"Nutrition cho FoodId {mealFood.FoodId} không đầy đủ.");

                // Tính delta calories và các chỉ số dinh dưỡng khác
                var oldCalories = oldQuantity * portion.PortionWeight * nut.Calories / 100f;
                var newCalories = request.Quantity * portion.PortionWeight * nut.Calories / 100f;
                var deltaCalories = newCalories - oldCalories;

                var oldProteins = oldQuantity * portion.PortionWeight * nut.Protein / 100f;
                var newProteins = request.Quantity * portion.PortionWeight * nut.Protein / 100f;
                var deltaProteins = newProteins - oldProteins;

                var oldCarbs = oldQuantity * portion.PortionWeight * nut.Carbs / 100f;
                var newCarbs = request.Quantity * portion.PortionWeight * nut.Carbs / 100f;
                var deltaCarbs = newCarbs - oldCarbs;

                var oldFats = oldQuantity * portion.PortionWeight * nut.Fat / 100f;
                var newFats = request.Quantity * portion.PortionWeight * nut.Fat / 100f;
                var deltaFats = newFats - oldFats;

                var oldFibers = oldQuantity * portion.PortionWeight * nut.Fiber / 100f;
                var newFibers = request.Quantity * portion.PortionWeight * nut.Fiber / 100f;
                var deltaFibers = newFibers - oldFibers;

                var oldSugars = oldQuantity * portion.PortionWeight * nut.Sugar / 100f;
                var newSugars = request.Quantity * portion.PortionWeight * nut.Sugar / 100f;
                var deltaSugars = newSugars - oldSugars;

                // Cập nhật MealFood
                mealFood.Quantity = request.Quantity;
                mealFood.UpdatedAt = DateTime.UtcNow;
                _mealFoodRepository.Update(mealFood);
                await _mealFoodRepository.SaveChangeAsync();

                // Cập nhật tất cả các chỉ số dinh dưỡng trong DailyMeal nếu IsComplete là true
                if (canUpdateNutrition && dailyMeal != null)
                {
                    dailyMeal.TotalCalories += deltaCalories;
                    dailyMeal.TotalProteins += deltaProteins;
                    dailyMeal.TotalCarbs += deltaCarbs;
                    dailyMeal.TotalFats += deltaFats;
                    dailyMeal.TotalFibers += deltaFibers;
                    dailyMeal.TotalSugars += deltaSugars;

                    dailyMeal.UpdatedAt = DateTime.UtcNow;
                    _dailyMealRepository.Update(dailyMeal);
                    await _dailyMealRepository.SaveChangeAsync();
                }
            }

            tx.Complete();
            return true;
        }
    }
}