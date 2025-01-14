using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId
{
    public class FoodsByUserIdDTO : BaseEntity
    {
        public Guid FoodId { get; set; }
        public string FoodType { get; set; } = string.Empty;
        public string Category { get; set; }
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;

        public GetPortionForGetFoodByUserDTO Portion { get; set; }
        public GetNutritionForGetFoodByUserDTO Nutrition { get; set; }
        public bool Status { get; set; }
    }
    public class GetPortionForGetFoodByUserDTO
    {
        [JsonPropertyName("size")]
        public string PortionSize { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; } = string.Empty;
    }
    public class GetNutritionForGetFoodByUserDTO
    {
        public float Calories { get; set; }
    }
}