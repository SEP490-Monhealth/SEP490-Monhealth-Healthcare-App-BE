using MediatR;
namespace Monhealth.Application.Features.Category.Queries.GetAllCategoriesByType
{
    public class GetCategoriesByTypeQuery : IRequest<List<CategoryByTypeDTO>>
    {
        public string Type { get; set; } = string.Empty;
    }
}