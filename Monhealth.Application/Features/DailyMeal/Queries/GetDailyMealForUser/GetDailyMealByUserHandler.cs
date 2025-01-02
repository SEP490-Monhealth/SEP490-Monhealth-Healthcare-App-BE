using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser
{
    public class GetDailyMealByUserHandler : IRequestHandler<GetDailyMealByUserQuery, List<GetDailyMealByUserDTO>>
    {
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;
        public GetDailyMealByUserHandler(IDailyMealRepository dailyMealRepository,
        IMealRepository mealRepository)
        {
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
        }

        public async Task<List<GetDailyMealByUserDTO>> Handle(GetDailyMealByUserQuery request, CancellationToken cancellationToken)
        {
            var query = await _dailyMealRepository.GetDailyMealsByUser(request.UseId);
            var mealQuery = await _mealRepository.GetAllMeals(); // Lấy tất cả Meals từ MealRepository

            var result = new List<GetDailyMealByUserDTO>();

            foreach (var dailyMeal in query)
            {
            
                var meals = mealQuery
                    .Where(m => dailyMeal.Meals.Select(dm => dm.MealId).Contains(m.MealId))
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
                            (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0
                    }).ToList();

                // Tạo đối tượng DailyMealDTO
                var dailyMealDTO = new GetDailyMealByUserDTO
                {
                    DailyMealId = dailyMeal.DailyMealId,
                    
                    Nutrition = new NutritionOfDailyMeal2
                    {
                        TotalCalories = dailyMeal.TotalCalories, // Tính tổng từ danh sách Meals
                        TotalProteins = dailyMeal.TotalProteins,
                        TotalCarbs = dailyMeal.TotalCarbs,
                        TotalFats = dailyMeal.TotalFats,
                        TotalFibers = dailyMeal.TotalFibers, // Giữ nguyên nếu không cần tính lại
                        TotalSugars = dailyMeal.TotalSugars// Giữ nguyên nếu không cần tính lại
                    },
                    Items = meals,
                    CreatedAt = dailyMeal.CreatedAt,
                    UpdatedAt = dailyMeal.UpdatedAt
                };

                result.Add(dailyMealDTO);
            }

            return result;
        }
    }
}
