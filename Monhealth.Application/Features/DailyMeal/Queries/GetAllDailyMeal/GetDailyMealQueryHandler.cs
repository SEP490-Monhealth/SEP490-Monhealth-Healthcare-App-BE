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
        public GetDailyMealQueryHandler(IDailyMealRepository dailyMealRepository)
        {
            _dailyMealRepository = dailyMealRepository;
        }

        public async Task<List<DailyMealDTO>> Handle(GetDailyMealQuery request, CancellationToken cancellationToken)
        {
            var query = await _dailyMealRepository.GetAllDailyMeals();
            var result = new List<DailyMealDTO>();

            foreach (var meal in query)
            {
                // Tính toán NutritionOfDailyMeal
                var nutrition = new NutritionOfDailyMeal
                {
                    TotalCalories = meal.TotalCalories,
                    TotalCarbs = meal.TotalCarbs,
                    TotalFats = meal.TotalFats,
                    TotalFibers = meal.TotalFibers,
                    TotalProteins = meal.TotalProteins,
                    TotalSugars = meal.TotalSugars
                };

                // Tính toán danh sách meals
                var meals = meal.Meals?.Select(m => new MealForDailyMeal
                {
                    mealId = m.MealId,
                    MealType = m.MealType,
                    Calories = m.MealFoods?.Sum(mf =>
                        (mf.Food?.Nutrition?.Calories / 100 ?? 0) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion.PortionWeight ?? 1))) ?? 0,
                    Protein = m.MealFoods?.Sum(mf =>
                        (mf.Food?.Nutrition?.Protein / 100 ?? 0) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion.PortionWeight ?? 1))) ?? 0,
                    Carbs = m.MealFoods?.Sum(mf =>
                        (mf.Food?.Nutrition?.Carbs / 100 ?? 0) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion.PortionWeight ?? 1))) ?? 0,
                    Fat = m.MealFoods?.Sum(mf =>
                        (mf.Food?.Nutrition?.Fat / 100 ?? 0) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion.PortionWeight ?? 1))) ?? 0
                }).ToList();


                // Tạo đối tượng DailyMealDTO và gán Nutrition và Meals
                var dailyMeal = new DailyMealDTO
                {
                    DailyMealId = meal.DailyMealId,
                    UserId = meal.UserId,
                    Nutrition = nutrition,
                    Meals = meals,
                    CreatedAt = meal.CreatedAt,
                    UpdatedAt = meal.UpdatedAt
                };

                result.Add(dailyMeal);
            }
            return result;

        }

    }
}