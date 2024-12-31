using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Meal.Queries.GetAllMeals
{
    public class GetMealListQueryHandler : IRequestHandler<GetMealListQuery, List<MealDTO>>
    {
        private readonly IMealRepository _mealRepository;

        public GetMealListQueryHandler(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }

        public async Task<List<MealDTO>> Handle(GetMealListQuery request, CancellationToken cancellationToken)
        {
            var query = await _mealRepository.GetAllMeals();
            var result = new List<MealDTO>();

            foreach (var meal in query)
            {
                var mealDTO = new MealDTO
                {
                    MealId = meal.MealId,
                    UserId = meal.UserId,
                    MealType = meal.MealType,


                    Nutrition = new MealFoodNutritionDTO
                    {

                        Calories = meal.MealFoods?.Sum(mf =>
                    ((mf.Food?.Nutrition?.Calories ?? 0) / 100) *
                    (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                        Protein = meal.MealFoods?.Sum(mf =>
                            ((mf.Food?.Nutrition?.Protein ?? 0) / 100) *
                            (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                        Carbs = meal.MealFoods?.Sum(mf =>
                            ((mf.Food?.Nutrition?.Carbs ?? 0) / 100) *
                            (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                        Fat = meal.MealFoods?.Sum(mf =>
                            ((mf.Food?.Nutrition?.Fat ?? 0) / 100) *
                            (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                        Fiber = meal.MealFoods?.Sum(mf =>
                            ((mf.Food?.Nutrition?.Fiber ?? 0) / 100) *
                            (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                        Sugar = meal.MealFoods?.Sum(mf =>
                            ((mf.Food?.Nutrition?.Sugar ?? 0) / 100) *
                            (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0
                    },
                    // Items = meal.MealFoods.Select(mf => new MealFoodDTO
                    // {
                    //     MealFoodId = mf.MealFoodId,
                    //     FoodId = mf.FoodId,
                    //     Quantity = mf.Quantity,
                    //     Name = mf.Food.FoodName,

                    //     Calories = (mf.Food.Nutrition.Calories / 100) * (mf.Quantity * 100),


                    //     Portions = new MealFoodPortionDTO
                    //     {
                    //         Size = mf.Food.FoodPortions.FirstOrDefault()?.Portion.PortionSize ?? string.Empty,
                    //         Weight = mf.Food.FoodPortions.FirstOrDefault()?.Portion.PortionWeight,
                    //         Unit = mf.Food.FoodPortions.FirstOrDefault()?.Portion.MeasurementUnit ?? string.Empty,
                    //     }
                    // }).ToList()
                    CreatedAt = meal.CreatedAt,
                    UpdatedAt = meal.UpdatedAt
                };

                result.Add(mealDTO);
            }

            return result;

        }
    }
}