using MediatR;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Food.AddFoodUser
{
    public class AddFoodUserRequest : IRequest<bool>
    {
        public Guid UserId { get; set; }

        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public string? ReferenceUrl { get; set; }
        public PortionDTO1 Portion { get; set; }
        public NutritionDTO1 Nutrition { get; set; }
        public bool IsPublic { get; set; }

    }
    public class PortionDTO1
    {
        [JsonPropertyName("size")]
        public string PortionSize { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; } = string.Empty;
    }
    public class NutritionDTO1
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