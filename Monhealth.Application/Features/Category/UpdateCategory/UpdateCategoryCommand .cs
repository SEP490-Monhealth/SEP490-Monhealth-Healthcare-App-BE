using MediatR;

namespace Monhealth.Application.Features.Category.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<bool>
    {
        public Guid CategoryId { get; set; } 
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public UpdateCategoryCommand(Guid categoryId, UpdateCategoryRequest request)
        {
            CategoryId = categoryId;
            CategoryName = request.CategoryName;
            CategoryDescription = request.CategoryDescription;
        }
    }
}