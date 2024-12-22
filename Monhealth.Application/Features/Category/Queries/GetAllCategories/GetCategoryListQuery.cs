using MediatR;
using Monhealth.Application.Features.Category.Queries.GetAllCategories;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetCategoryListQuery : IRequest<List<CategoryDto>>
    {

    }
}
