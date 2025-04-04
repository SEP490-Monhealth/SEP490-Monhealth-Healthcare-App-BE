using System.Text.Json.Serialization;
using Monhealth.Core.Enum;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Category.Queries.GetCategoryDetail
{
    public class CategoryDetailDTO : BaseEntity
    {
        public Guid CategoryId { get; set; }
        [JsonPropertyName("type")]
        public CategoryType CategoryType { get; set; }
        [JsonPropertyName("name")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string CategoryDescription { get; set; } = string.Empty;
        public string CategoryImage { get; set; } = string.Empty;
    }
}