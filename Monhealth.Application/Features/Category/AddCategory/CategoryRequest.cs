namespace Monhealth.Application.Features.Category.AddCategory
{
    public class CategoryRequest
    {
        public string CategoryType { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
    }
}