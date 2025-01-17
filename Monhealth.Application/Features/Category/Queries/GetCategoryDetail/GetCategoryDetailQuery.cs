using MediatR;

namespace Monhealth.Application.Features.Category.Queries.GetCategoryDetail
{
    public class GetCategoryDetailQuery : IRequest<CategoryDetailDTO>
    {
        public Guid CategoryId { get; set; }
    }
}