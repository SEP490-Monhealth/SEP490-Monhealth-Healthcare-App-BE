using MediatR;
namespace Monhealth.Application.Features.Category.Queries.GetAllCategoriesByType
{
    public class GetCategoriesByTypeQuery : IRequest<List<CategoryByTypeDTO>>
    {

    }
}