using AutoMapper;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByFoodType;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Automapper.CustomFoodMapper.CustomResolver
{
    public class GetFoodByFoodTypeValueResolver : IValueResolver<Food, FoodDetailByFoodTypeDTO, GetNutritionForGetTypeFoodDTO>
    {
        public GetNutritionForGetTypeFoodDTO Resolve(Food source, FoodDetailByFoodTypeDTO destination, GetNutritionForGetTypeFoodDTO destMember, ResolutionContext context)
        {
            var portion = source.FoodPortions.FirstOrDefault()?.Portion;
            var portionWeight = portion?.PortionWeight ?? 100; // Default weight
            var originalCalories = source.Nutrition.Calories;

            // Tính calories mới dựa trên PortionWeight
            var calculatedCalories = originalCalories / 100 * portionWeight;
            return new GetNutritionForGetTypeFoodDTO
            {
                Calories = (int)calculatedCalories
            };
        }
    }
}
