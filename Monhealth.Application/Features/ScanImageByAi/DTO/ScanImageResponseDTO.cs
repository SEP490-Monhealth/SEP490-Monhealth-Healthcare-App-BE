using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.ScanImageByAi.DTO
{
    public class ScanImageResponseDTO
    {
        [JsonPropertyName("ScanImage")]
        public ScanImageDTO ScanImage { get; set; } = new ScanImageDTO();

        [JsonPropertyName("is_image")]
        public bool IsImage { get; set; }

        [JsonPropertyName("SummaryDescription")]
        public string SummaryDescription { get; set; } = string.Empty;
    }

    public class ScanImageDTO
    {
        [JsonPropertyName("FoodName")]
        public string FoodName { get; set; } = string.Empty;

        [JsonPropertyName("Nutrition")]
        public ScanNutritionDTO Nutrition { get; set; } = new ScanNutritionDTO();
    }

    public class ScanNutritionDTO
    {
        [JsonPropertyName("Calories")]
        public float Calories { get; set; }

        [JsonPropertyName("Protein")]
        public float Protein { get; set; }

        [JsonPropertyName("Carbs")]
        public float Carbs { get; set; }

        [JsonPropertyName("Fat")]
        public float Fat { get; set; }

        [JsonPropertyName("Fiber")]
        public float Fiber { get; set; }

        [JsonPropertyName("Sugar")]
        public float Sugar { get; set; }
    }
}
