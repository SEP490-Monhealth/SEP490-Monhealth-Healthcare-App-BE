using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Category.Queries.GetAllCategories
{
    public class CategoryDTO : TimeEntity
    {
        public Guid CategoryId { get; set; }
        [JsonPropertyName("type")]
        public string CategoryType { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string CategoryDescription { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}