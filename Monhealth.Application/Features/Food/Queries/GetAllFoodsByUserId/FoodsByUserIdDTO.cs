using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId
{
    public class FoodsByUserIdDTO : BaseEntity
    {
        public Guid FoodId { get; set; }
        [JsonPropertyName("type")]
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
        public string PortionSize { get; set; } = string.Empty;
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = string.Empty;
    }
    public class GetNutritionForGetFoodByUserDTO
    {
        public float Calories { get; set; }
    }
}