using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForUser
{
    public class UpdateFoodRequestUser
    {
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
    }
}