using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByFoodType
{
    public class FoodDetailByFoodTypeDTO : BaseEntity
    {
        public Guid FoodId { get; set; }
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public string FoodType { get; set; } = string.Empty;
        public string Category { get; set; }
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public bool Status { get; set; }
        public GetPortionForGetTypeFoodDTO Portion { get; set; }
        public GetNutritionForGetTypeFoodDTO Nutrition { get; set; }
    }
    public class GetPortionForGetTypeFoodDTO
    {
        public string PortionSize { get; set; } = string.Empty;
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = string.Empty;
    }
    public class GetNutritionForGetTypeFoodDTO
    {
        public float Calories { get; set; }
    }
}