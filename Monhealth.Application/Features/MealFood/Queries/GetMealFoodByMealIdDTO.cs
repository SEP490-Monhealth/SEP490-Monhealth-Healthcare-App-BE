using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.MealFood.Queries
{
    public class GetMealFoodByMealIdDTO : TimeEntity
    {
        public Guid MealFoodId { get; set; }
        public Guid FoodId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        [JsonPropertyName("portion")]
        public MealFoodPortionDTO1 Portions { get; set; }
        public NutritionDTO1 Nutrition { get; set; }
        public bool isRecommended { get; set; }
        public bool Status { get; set; }
    }

    public class NutritionDTO1
    {
        public float Calories { get; set; }
    }

    public class MealFoodPortionDTO1
    {
        public string Size { get; set; } = string.Empty;
        public float? Weight { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}