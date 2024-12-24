using MediatR;

namespace Monhealth.Application.Features.Category.UpdateCategory
{
    public class UpdateCategoryRequest : IRequest<bool>
    {

        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public string CategoryImage { get; set; } = string.Empty;
    }
}