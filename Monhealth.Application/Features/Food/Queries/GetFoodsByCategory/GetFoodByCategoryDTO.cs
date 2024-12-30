using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetFoodsByCategory
{
    public class GetFoodByCategoryDTO : BaseEntity
    {
        public Guid FoodId { get; set; }
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public string FoodType { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}