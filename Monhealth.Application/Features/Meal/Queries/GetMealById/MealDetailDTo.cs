using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Meal.Queries.GetMealById
{
    public class MealDetailDTo : TimeEntity
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public MealType MealType { get; set; }
        public DateTime MealDate { get; set; } 
        public MealFoodNutritionDTO1 Nutrition { get; set; }
    }

    public class MealFoodNutritionDTO1
    {
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
}