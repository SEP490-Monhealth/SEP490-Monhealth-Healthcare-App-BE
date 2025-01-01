using AutoMapper;
using Monhealth.Application.Features.Food.Queries.GetAllFoods;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Automapper.CustomResolver
{
    public class CaloriesValueResolver : IValueResolver<Food, FoodDTO, GetNutritionForGetAllFoodDTO>
    {
        public GetNutritionForGetAllFoodDTO Resolve(Food source, FoodDTO destination, GetNutritionForGetAllFoodDTO destMember, ResolutionContext context)
        {
            var portion = source.FoodPortions.FirstOrDefault()?.Portion;
            var portionWeight = portion?.PortionWeight ?? 100; // Default weight
            var originalCalories = source.Nutrition.Calories;

            // Tính calories mới dựa trên PortionWeight
            var calculatedCalories = (originalCalories / 100) * portionWeight;
            return new GetNutritionForGetAllFoodDTO
            {
                Calories = (int)calculatedCalories
            };
        }
    }
}
