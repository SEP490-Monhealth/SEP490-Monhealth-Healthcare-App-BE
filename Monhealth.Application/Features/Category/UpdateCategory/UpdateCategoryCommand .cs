using MediatR;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Category.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<bool>
    {
        public Guid CategoryId { get; set; }
        public CategoryType CategoryType { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }

        public UpdateCategoryCommand(Guid categoryId, UpdateCategoryRequest request)
        {
            CategoryId = categoryId;
            CategoryType = request.CategoryType;
            CategoryName = request.CategoryName;
            CategoryDescription = request.CategoryDescription;
            CategoryImage = request.CategoryImage;
        }
    }
}