using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetAllDailyMeal
{
    public class GetDailyMealQueryHandler : IRequestHandler<GetDailyMealQuery, List<DailyMealDTO>>
    {
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;
        public GetDailyMealQueryHandler(IDailyMealRepository dailyMealRepository,
        IMealRepository mealRepository)
        {
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
        }

        public async Task<List<DailyMealDTO>> Handle(GetDailyMealQuery request, CancellationToken cancellationToken)
        {
            var query = await _dailyMealRepository.GetAllDailyMeals();
            var mealQuery = await _mealRepository.GetAllMeals(); // Lấy tất cả Meals từ MealRepository

            var result = new List<DailyMealDTO>();

            foreach (var dailyMeal in query)
            {
                // Lọc danh sách Meal từ danh sách toàn bộ Meals bằng DailyMeal.Meals
                var meals = mealQuery
                    .Where(m => dailyMeal.Meals.Select(dm => dm.MealId).Contains(m.MealId))
                    .Select(m => new MealForDailyMeal
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
                            (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0
                    }).ToList();

                // Tạo đối tượng DailyMealDTO
                var dailyMealDTO = new DailyMealDTO
                {
                    DailyMealId = dailyMeal.DailyMealId,
                    UserId = dailyMeal.UserId,
                    Nutrition = new NutritionOfDailyMeal
                    {
                        TotalCalories = dailyMeal.TotalCalories , // Tính tổng từ danh sách Meals
                        TotalProteins = dailyMeal.TotalProteins,
                        TotalCarbs = dailyMeal.TotalCarbs,
                        TotalFats = dailyMeal.TotalFats,
                        TotalFibers = dailyMeal.TotalFibers, // Giữ nguyên nếu không cần tính lại
                        TotalSugars =  dailyMeal.TotalSugars// Giữ nguyên nếu không cần tính lại
                    },
                    Meals = meals,
                    CreatedAt = dailyMeal.CreatedAt,
                    UpdatedAt = dailyMeal.UpdatedAt
                };

                result.Add(dailyMealDTO);
            }

            return result;
        }


    }
}