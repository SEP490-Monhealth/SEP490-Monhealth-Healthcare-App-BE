using Monhealth.Core.Enum;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealDTO
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public MealType MealType { get; set; } = default!;
        [JsonPropertyName("date")]
        public DateTime MealDate { get; set; } = DateTime.Now;
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