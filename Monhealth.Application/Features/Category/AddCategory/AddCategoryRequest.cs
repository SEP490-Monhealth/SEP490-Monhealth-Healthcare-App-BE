using MediatR;

namespace Monhealth.Application.Features.Category.AddCategory
{
    public class AddCategoryRequest : IRequest<CategoryRequest>
    {
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public string CategoryImage { get; set; } = string.Empty;
    }
}