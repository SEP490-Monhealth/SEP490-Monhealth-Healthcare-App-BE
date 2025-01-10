using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Food.AddFood
{
    public class AddFoodRequest : IRequest<bool>
    {
        public Guid UserId { get; set; }
        public string Category { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public PortionDTO Portion { get; set; }
        public NutritionDTO Nutrition { get; set; }
    }
    public class PortionDTO
    {
        [JsonPropertyName("size")]
        public string PortionSize { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; } = string.Empty;
    }
    public class NutritionDTO
    {
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
        public float? SaturatedFat { get; set; }
        public float? UnsaturatedFat { get; set; }
        public float? Cholesterol { get; set; }
        public float? Sodium { get; set; }
        public float? Potassium { get; set; }
        public float? Calcium { get; set; }
        public float? Iron { get; set; }
        public float? VitaminA { get; set; }
        public float? VitaminB1 { get; set; }
        public float? VitaminB2 { get; set; }
        public float? VitaminC { get; set; }
        public float? VitaminD { get; set; }
        public float? VitaminE { get; set; }


    }
}