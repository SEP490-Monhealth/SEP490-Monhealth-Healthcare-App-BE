using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealByCreateAt
{
    public class GetDailyMealByCreateAtHandler : IRequestHandler<GetDailyMealByCreateAtQuery, DailyMealByCreateAtDTO>
    {
        private readonly IDailyMealRepository _dailyMealRepository;

        public GetDailyMealByCreateAtHandler(IDailyMealRepository dailyMealRepository)
        {
            _dailyMealRepository = dailyMealRepository;
        }

        public async Task<DailyMealByCreateAtDTO> Handle(GetDailyMealByCreateAtQuery request, CancellationToken cancellationToken)
        {
            var query = await _dailyMealRepository.GetDailyMealByCreateAt(request.CreateAt);
            if (query == null) throw new Exception("Không tìm thấy ngày tạo.");
            var nutrition = new NutritionOfDailyMeal1
            {
                TotalCalories = query.TotalCalories,
                TotalCarbs = query.TotalCarbs,
                TotalFats = query.TotalFats,
                TotalFibers = query.TotalFibers,
                TotalProteins = query.TotalProteins,
                TotalSugars = query.TotalSugars
            };
            var meals = query.Meals.Select(m => new MealForDailyMeal1
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
            });
            // Tạo đối tượng DailyMealDTO và gán Nutrition và Meals
            var dailyMeal = new DailyMealByCreateAtDTO
            {
                DailyMealId = query.DailyMealId,
                UserId = query.UserId,
                Nutrition = nutrition,
                Meals = meals
            };
            return dailyMeal;
        }
    }
}