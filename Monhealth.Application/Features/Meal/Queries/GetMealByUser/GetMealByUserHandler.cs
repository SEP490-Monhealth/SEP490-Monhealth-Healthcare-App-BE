using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Meal.Queries.GetMealByUser
{
    public class GetMealByUserHandler : IRequestHandler<GetMealByUserQuery, List<GetMealByUserDTO>>
    {

        private readonly IMealRepository _mealRepository;

        public GetMealByUserHandler(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }

        public async Task<List<GetMealByUserDTO>> Handle(GetMealByUserQuery request, CancellationToken cancellationToken)
        {
            var query = await _mealRepository.GetMealByUser(request.UserId);
            if(query == null) throw new Exception("Người dùng không tồn tại.");
            var result = new List<GetMealByUserDTO>();

            foreach (var meal in query)
            {
                var mealDTO = new GetMealByUserDTO
                {
                    MealId = meal.MealId,
                    UserId = meal.UserId,
                    MealType = meal.MealType,


                    Nutrition = new MealFoodNutritionDTO2
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

                    CreatedAt = meal.CreatedAt,
                    UpdatedAt = meal.UpdatedAt
                };

                result.Add(mealDTO);
            }

            return result;
        }
    }
}