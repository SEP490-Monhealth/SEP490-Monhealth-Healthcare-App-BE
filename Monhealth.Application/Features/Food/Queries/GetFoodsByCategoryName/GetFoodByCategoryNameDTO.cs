using System.Text.Json.Serialization;


namespace Monhealth.Application.Features.Food.Queries.GetFoodsByCategoryName
{
    public class GetFoodByCategoryNameDTO
    {
        public Guid FoodId { get; set; }
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public string FoodType { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string FoodDescription { get; set; } = string.Empty;
        public GetPortionForGetAllFoodDTO1 Portion { get; set; }
        public GetNutritionForGetAllFoodDTO1 Nutrition { get; set; }
        public bool Status { get; set; }
    }
    public class GetPortionForGetAllFoodDTO1
    {
        [JsonPropertyName("size")]
        public string PortionSize { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public float PortionWeight { get; set; }
        [JsonPropertyName("unit")]
        public string MeasurementUnit { get; set; } = string.Empty;
    }
    public class GetNutritionForGetAllFoodDTO1
    {
        public float Calories { get; set; }
    }
}