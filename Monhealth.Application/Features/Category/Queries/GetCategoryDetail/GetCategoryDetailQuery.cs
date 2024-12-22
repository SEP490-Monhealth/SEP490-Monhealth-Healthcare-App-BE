using MediatR;

namespace Monhealth.Application.Features.Category.Queries.GetCategoryDetail
{
    public class GetCategoryDetailQuery : IRequest<CategoryDetailDto>
    {
        public Guid CategoryId { get; set; }
    }
}