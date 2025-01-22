using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetFoodById
{
    public class GetFoodByIdDTO : BaseEntity
    {
        public string Category { get; set; }
        public List<string> MealType { get; set; }
        public List<string> DishType { get; set; }
        [JsonPropertyName("name")]
        public string FoodName { get; set; }
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public bool Status { get; set; }
    }
}