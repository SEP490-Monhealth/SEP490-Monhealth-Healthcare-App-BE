using MediatR;
using Monhealth.Application.Features.Category.Queries.GetAllCategories;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetCategoryListQuery : IRequest<List<CategoryDTO>>
    {
        public string? CategoryType { get; set; }
        public GetCategoryListQuery(string? categoryType)
        {
            CategoryType = categoryType;
        }
    }
}
