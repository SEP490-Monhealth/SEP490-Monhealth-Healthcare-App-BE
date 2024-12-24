using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Category.AddCategory
{
    public class AddCategoryRequest : IRequest<CategoryRequest>
    {
        [JsonPropertyName("name")]
        public string CategoryName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string CategoryDescription { get; set; } = string.Empty;
        [JsonPropertyName("image")]
        public string CategoryImage { get; set; } = string.Empty;
    }
}