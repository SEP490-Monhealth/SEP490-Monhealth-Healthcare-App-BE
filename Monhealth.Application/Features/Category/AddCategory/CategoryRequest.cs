using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Category.AddCategory
{
    public class CategoryRequest
    {
        public CategoryType CategoryType { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
    }
}