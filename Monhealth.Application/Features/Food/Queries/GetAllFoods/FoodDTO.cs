using System.Text.Json.Serialization;
using Monhealth.Core.Enum;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class FoodDTO : BaseEntity
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
        public GetPortionForGetAllFoodDTO Portion { get; set; }
        public GetNutritionForGetAllFoodDTO Nutrition { get; set; }
        public List<string> Allergies { get; set; }
        public bool IsPublic { get; set; }
        public bool Status { get; set; }
    }

    public class GetPortionForGetAllFoodDTO
    {
        [JsonPropertyName("size")]
        public string PortionSize { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; } = string.Empty;
    }

    public class GetNutritionForGetAllFoodDTO
    {
        public float Calories { get; set; }
    }
}
