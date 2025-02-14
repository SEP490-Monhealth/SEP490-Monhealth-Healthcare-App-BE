using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.MealFood.GetAllMealFoodForMeal
{
    public class GetALLMealFoodByMealDTO : BaseEntity
    {
        public Guid MealId { get; set; }
        public Guid UserId { get; set; }
        public MealType MealType { get; set; }
        public MealFoodNutritionDTO5 Nutrition { get; set; }
        public List<MealFoodDTO5> Items { get; set; }
    }
    public class MealFoodNutritionDTO5
    {
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
    public class MealFoodDTO5
    {
        public Guid MealFoodId { get; set; }
        public Guid FoodId { get; set; }
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        public bool Status { get; set; }
        public int Quantity { get; set; }
        public float Calories { get; set; }
        public MealFoodPortion5 Portion { get; set; }
    }
    public class MealFoodPortion5
    {
        [JsonPropertyName("size")]
        public string PortionSize { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; } = string.Empty;

    }
}