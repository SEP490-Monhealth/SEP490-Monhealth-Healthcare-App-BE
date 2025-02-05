using MediatR;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Category.Queries.GetAllCategoriesByType
{
    public class GetCategoriesByTypeQuery : IRequest<List<CategoryByTypeDTO>>
    {
        public CategoryType CategoryType { get; set; }
    }
}
