using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.ScanImageByAi.DTO
{
    public class ScanImageResponseDTO
    {
        [JsonPropertyName("Food")]
        public ScanImageDTO ScanImage { get; set; } = new ScanImageDTO();

        [JsonPropertyName("isFoodImage")]
        public bool IsImage { get; set; }

        [JsonPropertyName("summaryDescription")]
        public string SummaryDescription { get; set; } = string.Empty;
    }

    public class ScanImageDTO
    {
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;

        [JsonPropertyName("Nutrition")]
        public ScanNutritionDTO Nutrition { get; set; } = new ScanNutritionDTO();
    }

    public class ScanNutritionDTO
    {
        [JsonPropertyName("calories")]
        public float Calories { get; set; }

        [JsonPropertyName("protein")]
        public float Protein { get; set; }

        [JsonPropertyName("carbs")]
        public float Carbs { get; set; }

        [JsonPropertyName("fat")]
        public float Fat { get; set; }

        [JsonPropertyName("fiber")]
        public float Fiber { get; set; }

        [JsonPropertyName("sugar")]
        public float Sugar { get; set; }
    }
}
