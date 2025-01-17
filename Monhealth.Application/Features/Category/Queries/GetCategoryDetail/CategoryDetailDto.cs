using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Category.Queries.GetCategoryDetail
{
    public class CategoryDetailDto
    {
        [JsonPropertyName("type")]
        public string CategoryType { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string CategoryDescription { get; set; } = string.Empty;
        [JsonPropertyName("image")]
        public string CategoryImage { get; set; } = string.Empty;
    }
}