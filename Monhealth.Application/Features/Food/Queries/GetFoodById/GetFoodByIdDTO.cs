using System.Text.Json.Serialization;
using Monhealth.Core.Enum;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetFoodById
{
    public class GetFoodByIdDTO : BaseEntity
    {
        public Guid FoodId { get; set; }
        public Guid UserId { get; set; }
        public string Category { get; set; } = string.Empty;
        public List<MealType> MealType { get; set; }
        public List<DishTypeEnum> DishType { get; set; }
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public string? ReferenceUrl { get; set; }
        public List<string> Allergies { get; set; }
        public bool IsPublic { get; set; }
        public bool Status { get; set; }
    }
}