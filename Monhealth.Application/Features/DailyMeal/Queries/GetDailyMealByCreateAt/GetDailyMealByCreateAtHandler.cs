using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealByCreateAt
{
    public class GetDailyMealByCreateAtHandler : IRequestHandler<GetDailyMealByCreateAtQuery, DailyMealByCreateAtDTO>
    {
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;

        public GetDailyMealByCreateAtHandler(IDailyMealRepository dailyMealRepository,
        IMealRepository mealRepository)
        {
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
        }

        public async Task<DailyMealByCreateAtDTO> Handle(GetDailyMealByCreateAtQuery request, CancellationToken cancellationToken)
        {
            // Lấy DailyMeal theo ngày tạo
            var query = await _dailyMealRepository.GetDailyMealByCreateAt(request.CreateAt);
            if (query == null) throw new Exception("Không tìm thấy ngày tạo.");

            // Lấy danh sách toàn bộ Meals từ MealRepository
            var mealQuery = await _mealRepository.GetAllMeals();

            // Lọc danh sách Meal từ danh sách toàn bộ Meals bằng DailyMeal.Meals
            var meals = mealQuery
                .Where(m => query.Meals.Select(dm => dm.MealId).Contains(m.MealId))
                .Select(m => new MealForDailyMeal1
                {
                    mealId = m.MealId,
                    MealType = m.MealType,
                    Calories = m.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Calories ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Protein = m.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Protein ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Carbs = m.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Carbs ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Fat = m.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Fat ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Fiber = m.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Fiber ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Sugar = m.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Sugar ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0
                }).ToList();

            // Tạo đối tượng Nutrition
            var nutrition = new NutritionOfDailyMeal1
            {
                TotalCalories = query.TotalCalories, // Tổng từ DB
                TotalProteins = query.TotalProteins,
                TotalCarbs = query.TotalCarbs,
                TotalFats = query.TotalFats,
                TotalFibers = query.TotalFibers,
                TotalSugars = query.TotalSugars
            };

            // Tạo đối tượng DailyMealDTO
            var dailyMealDTO = new DailyMealByCreateAtDTO
            {
                DailyMealId = query.DailyMealId,
                UserId = query.UserId,
                Nutrition = nutrition, // Gán nutrition
                Meals = meals, // Gán danh sách Meals
               
            };

            return dailyMealDTO;
        }

    }
}