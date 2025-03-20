using System.Text.Json.Serialization;
using Monhealth.Core.Enum;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Category.Queries.GetAllCategories
{
    public class CategoryDTO : TimeEntity
    {
        public Guid CategoryId { get; set; }
        [JsonPropertyName("type")]
        public CategoryType CategoryType { get; set; }
        [JsonPropertyName("name")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string CategoryDescription { get; set; } = string.Empty;
        [JsonPropertyName("imageUrl")]
        public string Image { get; set; } = string.Empty;
    }
}