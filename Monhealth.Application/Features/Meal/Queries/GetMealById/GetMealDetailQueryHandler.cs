using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Meal.Queries.GetMealById
{
    public class GetMealDetailQueryHandler : IRequestHandler<GetMealDetailQuery, MealDetailDTo>
    {
        private readonly IMealRepository _mealRepository;

        public GetMealDetailQueryHandler(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }

        public async Task<MealDetailDTo> Handle(GetMealDetailQuery request, CancellationToken cancellationToken)
        {
            var query = await _mealRepository.GetMealByMealId(request.MealId);
            if (query == null) throw new Exception("Bữa ăn không tồn tại. ");
            var mealDetailDTO = new MealDetailDTo
            {
                UserId = query.UserId,
                MealType = query.MealType,

                Nutrition = new MealFoodNutritionDTO1
                {

                    Calories = query.MealFoods?.Sum(mf =>
                ((mf.Food?.Nutrition?.Calories ?? 0) / 100) *
                (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Protein = query.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Protein ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Carbs = query.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Carbs ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Fat = query.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Fat ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Fiber = query.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Fiber ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0,
                    Sugar = query.MealFoods?.Sum(mf =>
                        ((mf.Food?.Nutrition?.Sugar ?? 0) / 100) *
                        (mf.Quantity * (mf.Food?.FoodPortions?.FirstOrDefault()?.Portion?.PortionWeight ?? 1))) ?? 0
                },
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt
            };
            return mealDetailDTO;
        }
    }
}