using System;
using System.Linq;
using System.Transactions;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

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

            // Lấy Meal
            var meal = await _mealRepository.GetByIdAsync(mealFood.MealId)
                ?? throw new ArgumentException("Meal không tồn tại.");

            // Lấy DailyMeal nếu có
            Domain.DailyMeal dailyMeal = null;
            if (meal.DailyMealId.HasValue)
                dailyMeal = await _dailyMealRepository.GetByIdAsync(meal.DailyMealId.Value);

            // Xử lý xoá
            if (request.Quantity == 0)
            {
                _mealFoodRepository.Remove(mealFood);
                await _mealFoodRepository.SaveChangeAsync();

                var remFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);
                if (!remFoods.Any())
                {
                    _mealRepository.Remove(meal);
                    await _mealRepository.SaveChangeAsync();
                }

                if (dailyMeal != null)
                {
                    var remMeals = await _mealRepository.GetMealsByDailyMealId(dailyMeal.DailyMealId);
                    if (!remMeals.Any())
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
                // Tính delta Calories
                var oldQuantity = mealFood.Quantity;
                var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId)
                              ?? throw new ArgumentException($"Portion {mealFood.PortionId} không tồn tại.");
                var nut = mealFood.Food?.Nutrition
                          ?? throw new ArgumentException($"Nutrition cho FoodId {mealFood.FoodId} không đầy đủ.");

                var oldCalories = oldQuantity * portion.PortionWeight * nut.Calories / 100f;
                var newCalories = request.Quantity * portion.PortionWeight * nut.Calories / 100f;
                var deltaCalories = newCalories - oldCalories;

                // Cập nhật MealFood
                mealFood.Quantity = request.Quantity;
                mealFood.UpdatedAt = DateTime.Now;
                _mealFoodRepository.Update(mealFood);
                await _mealFoodRepository.SaveChangeAsync();

                // Cập nhật TotalCalories
                if (dailyMeal != null)
                {
                    dailyMeal.TotalCalories += deltaCalories;
                    dailyMeal.UpdatedAt = DateTime.Now;
                    _dailyMealRepository.Update(dailyMeal);
                    await _dailyMealRepository.SaveChangeAsync();
                }
            }

            tx.Complete();
            return true;
        }

        private async Task RecalculateDailyMealNutrition(Domain.DailyMeal dailyMeal)
        {
            if (dailyMeal == null) return;

            dailyMeal.TotalCalories = 0;
            dailyMeal.TotalProteins = 0;
            dailyMeal.TotalCarbs = 0;
            dailyMeal.TotalFats = 0;
            dailyMeal.TotalFibers = 0;
            dailyMeal.TotalSugars = 0;

            var meals = await _mealRepository.GetMealsByDailyMealId(dailyMeal.DailyMealId);
            foreach (var meal in meals)
            {
                var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);
                foreach (var foodItem in mealFoods)
                {
                    try
                    {
                        if (foodItem.Quantity <= 0) continue;

                        var portion = await _portionRepository.GetByIdAsync(foodItem.PortionId);
                        if (portion == null)
                        {
                            _logger.LogWarning("Portion {PortionId} không tìm thấy.", foodItem.PortionId);
                            continue;
                        }
                        var nutrition = foodItem.Food?.Nutrition;
                        if (nutrition == null)
                        {
                            _logger.LogWarning("Nutrition cho FoodId {FoodId} không đầy đủ.", foodItem.FoodId);
                            continue;
                        }

                        var weightFactor = foodItem.Quantity * portion.PortionWeight / 100f;
                        dailyMeal.TotalCalories += nutrition.Calories * weightFactor;
                        dailyMeal.TotalProteins += nutrition.Protein * weightFactor;
                        dailyMeal.TotalCarbs += nutrition.Carbs * weightFactor;
                        dailyMeal.TotalFats += nutrition.Fat * weightFactor;
                        dailyMeal.TotalFibers += nutrition.Fiber * weightFactor;
                        dailyMeal.TotalSugars += nutrition.Sugar * weightFactor;
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Lỗi khi tính nutrition cho MealFoodId {MealFoodId}.", foodItem.MealFoodId);
                    }
                }
            }

            dailyMeal.UpdatedAt = DateTime.Now;
            _dailyMealRepository.Update(dailyMeal);
            await _dailyMealRepository.SaveChangeAsync();
        }
    }
}
