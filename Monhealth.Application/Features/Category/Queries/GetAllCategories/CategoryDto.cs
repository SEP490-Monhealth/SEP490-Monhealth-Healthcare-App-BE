using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Category.Queries.GetAllCategories
{
    public class CategoryDto : BaseEntity
    {
        public Guid CategoryId { get; set; }
        [JsonPropertyName("name")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string CategoryDescription { get; set; } = string.Empty;
        [JsonPropertyName("image")]
        public string CategoryImage { get; set; } = string.Empty;
    }
}