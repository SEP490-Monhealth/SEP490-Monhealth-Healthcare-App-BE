using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Meal.Queries.GetMealByUser
{
    public class GetMealByUserDTO : TimeEntity
    {
        public Guid MealId { get; set; }

        [JsonPropertyName("type")]
        public string MealType { get; set; } = string.Empty;
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