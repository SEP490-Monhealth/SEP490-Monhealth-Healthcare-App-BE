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
            // Sử dụng TransactionScope để đảm bảo atomic cho mọi thay đổi
            using var tx = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

            // 1. Lấy MealFood
            var mealFood = await _mealFoodRepository.GetByIdAsync(request.MealFoodId);
            if (mealFood == null)
                throw new ArgumentException("MealFood không tồn tại.");

            // 2. Lấy Meal liên quan
            var meal = await _mealRepository.GetByIdAsync(mealFood.MealId);
            if (meal == null)
                throw new ArgumentException("Meal không tồn tại.");

            // 3. Lấy DailyMeal nếu có
            Domain.DailyMeal dailyMeal = null;
            if (meal.DailyMealId.HasValue)
            {
                dailyMeal = await _dailyMealRepository.GetByIdAsync(meal.DailyMealId.Value);
            }

            // Xử lý xoá hoặc cập nhật
            if (request.Quantity == 0)
            {
                // 4. Xóa MealFood
                _mealFoodRepository.Remove(mealFood);
                await _mealFoodRepository.SaveChangeAsync();

                // 5. Xử lý Meal nếu không còn food nào
                var remainingMealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);
                if (!remainingMealFoods.Any())
                {
                    _mealRepository.Remove(meal);
                    await _mealRepository.SaveChangeAsync();
                }

                // 6. Tính lại DailyMeal hoặc xóa nếu không còn meal nào
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
                // 7. Cập nhật Quantity của MealFood
                mealFood.Quantity = request.Quantity;
                mealFood.UpdatedAt = DateTime.Now;
                _mealFoodRepository.Update(mealFood);
                await _mealFoodRepository.SaveChangeAsync();

                // 8. Tính lại DailyMeal nếu có
                if (dailyMeal != null)
                {
                    await RecalculateDailyMealNutrition(dailyMeal);
                }
            }

            tx.Complete();
            return true;
        }

        /// <summary>
        /// Tính toán lại tổng dinh dưỡng cho DailyMeal và lưu
        /// </summary>
        private async Task RecalculateDailyMealNutrition(Domain.DailyMeal dailyMeal)
        {
            if (dailyMeal == null) return;

            // Reset các giá trị
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
