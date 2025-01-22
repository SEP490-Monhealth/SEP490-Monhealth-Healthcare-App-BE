using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForAdmin
{
    public class UpdateFoodRequestAdmin : IRequest<bool>
    {
        public string Category { get; set; } = string.Empty;
        public List<string> MealType { get; set; }
        public List<string> DishType { get; set; }
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
    }
}