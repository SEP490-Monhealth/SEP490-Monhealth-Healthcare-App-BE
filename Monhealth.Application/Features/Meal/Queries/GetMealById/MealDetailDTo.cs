using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Meal.Queries.GetMealById
{
    public class MealDetailDTo : BaseEntity
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public string MealType { get; set; } = string.Empty;
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