using System.Text.Json.Serialization;
using MediatR;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Category.AddCategory
{
    public class AddCategoryRequest : IRequest<CategoryRequest>
    {
        [JsonPropertyName("type")]
        public CategoryType CategoryType { get; set; }
        [JsonPropertyName("name")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string CategoryDescription { get; set; } = string.Empty;
        [JsonPropertyName("image")]
        public string CategoryImage { get; set; } = string.Empty;
    }
}