using System.Text.Json.Serialization;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForUser
{
    public class UpdateFoodRequestUser
    {
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        public List<MealType> MealType { get; set; }
        public List<DishType> DishType { get; set; }
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
    }
}