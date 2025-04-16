using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Meal.Queries.GetMealByUser
{
    public class GetMealByUserDTO : TimeEntity
    {
        public Guid MealId { get; set; }

        [JsonPropertyName("type")]
        public MealType MealType { get; set; }
        public DateTime MealDate { get; set; } 
        public MealFoodNutritionDTO2 Nutrition { get; set; }
    }

    public class MealFoodNutritionDTO2
    {
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
}