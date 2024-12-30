using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealDTO
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public string MealType { get; set; } = string.Empty;
        public ICollection<MealFoodsDTO> Items { get; set; }
    }
    public class MealFoodsDTO
    {
        public Guid FoodId { get; set; }
        public int Quantity { get; set; }
        [JsonPropertyName("size")]
        public string PortionSize { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; } = string.Empty;

    }
}