using System.Text.Json.Serialization;

namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodFilterDTO
    {
        public Guid FoodId { get; set; }
        public string Category { get; set; } = string.Empty;
        public List<string> MealType { get; set; }
        public List<string> DishType { get; set; }
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
    }
}