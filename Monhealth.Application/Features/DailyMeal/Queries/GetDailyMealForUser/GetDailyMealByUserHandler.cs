using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser
{
    public class GetDailyMealByUserHandler : IRequestHandler<GetDailyMealByUserQuery, GetDailyMealByUserDTO>
    {
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;
        public GetDailyMealByUserHandler(IDailyMealRepository dailyMealRepository,
        IMealRepository mealRepository)
        {
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
        }

        public async Task<GetDailyMealByUserDTO> Handle(GetDailyMealByUserQuery request, CancellationToken cancellationToken)
        {
            var query = await _dailyMealRepository.GetDailyMealsByUser(request.UseId, request.date);

            if (query == null)
            {
                return new GetDailyMealByUserDTO
                {
                    DailyMealId = Guid.Empty,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Items = null,
                    Nutrition = null,

                };
            }


            // Lấy danh sách toàn bộ Meals từ MealRepository
            var mealQuery = await _mealRepository.GetAllMeals();

            // Lọc danh sách Meal từ danh sách toàn bộ Meals bằng DailyMeal.Meals
            var meals = mealQuery
                .Where(m => query.Meals.Select(dm => dm.MealId).Contains(m.MealId))
                .Select(m => new MealForDailyMeal2
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
            var nutrition = new NutritionOfDailyMeal2
            {
                TotalCalories = query.TotalCalories, // Tổng từ DB
                TotalProteins = query.TotalProteins,
                TotalCarbs = query.TotalCarbs,
                TotalFats = query.TotalFats,
                TotalFibers = query.TotalFibers,
                TotalSugars = query.TotalSugars
            };

            // Tạo đối tượng DailyMealDTO
            var dailyMealDTO = new GetDailyMealByUserDTO
            {
                DailyMealId = query.DailyMealId,
                Nutrition = nutrition, // Gán nutrition
                Items = meals, // Gán danh sách Meals
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt
            };

            return dailyMealDTO;
        }
    }
}
