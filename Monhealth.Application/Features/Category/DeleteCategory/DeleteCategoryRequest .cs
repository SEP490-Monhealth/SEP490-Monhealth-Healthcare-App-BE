using MediatR;

namespace Monhealth.Application.Features.Category.DeleteCategory
{
    public class DeleteCategoryRequest : IRequest<bool>
    {
        public Guid CategoryId { get; set; }
        public DeleteCategoryRequest(Guid categoryId)
        {
            CategoryId = categoryId;
        }


    }
}