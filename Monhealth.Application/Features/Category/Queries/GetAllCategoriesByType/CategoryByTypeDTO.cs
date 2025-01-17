using System.Text.Json.Serialization;
namespace Monhealth.Application.Features.Category.Queries.GetAllCategoriesByType
{
    public class CategoryByTypeDTO
    {
        public Guid CategoryId { get; set; }
        [JsonPropertyName("name")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string CategoryDescription { get; set; } = string.Empty;
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
    }
}