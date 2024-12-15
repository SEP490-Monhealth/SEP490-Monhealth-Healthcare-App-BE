using MediatR;
using Monhealth.Application.Features.Category.Queries.GetAllCategories;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetCategoryListQuery : IRequest<List<CategoryDto>>
    {

    }
}
