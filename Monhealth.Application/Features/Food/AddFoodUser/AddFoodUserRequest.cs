using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Food.AddFoodUser
{
    public class AddFoodUserRequest : IRequest<bool>
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public string FoodType { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public PortionDTO1 Portion { get; set; }
        public NutritionDTO1 Nutrition { get; set; }
    }
    public class PortionDTO1
    {
        public string PortionSize { get; set; } = string.Empty;
        public float PortionWeight { get; set; }
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
    }
}