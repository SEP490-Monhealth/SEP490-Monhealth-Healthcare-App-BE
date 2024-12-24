using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Category.Queries.GetCategoryDetail
{
    public class CategoryDetailDto
    {
        [JsonPropertyName("name")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string CategoryDescription { get; set; } = string.Empty;
        [JsonPropertyName("image")]
        public string CategoryImage { get; set; } = string.Empty;
    }
}