using AutoMapper;
using Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper.CustomMapper.CustomFoodMapper.CustomResolver
{
    public class GetAllFoodByUserIdCaloriesValueResolver : IValueResolver<Food, FoodsByUserIdDTO, GetNutritionForGetFoodByUserDTO>
    {
        public GetNutritionForGetFoodByUserDTO Resolve(Food source, FoodsByUserIdDTO destination, GetNutritionForGetFoodByUserDTO destMember, ResolutionContext context)
        {
            var portion = source.FoodPortions.FirstOrDefault()?.Portion;
            var portionWeight = portion?.PortionWeight ?? 100; // Default weight
            var originalCalories = source.Nutrition.Calories;

            // Tính calories mới dựa trên PortionWeight
            var calculatedCalories = originalCalories / 100 * portionWeight;
            return new GetNutritionForGetFoodByUserDTO
            {
                Calories = (int)calculatedCalories
            };
        }
    }
}
