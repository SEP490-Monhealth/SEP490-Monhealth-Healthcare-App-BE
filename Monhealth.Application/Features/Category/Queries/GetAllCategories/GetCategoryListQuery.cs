using MediatR;
using Monhealth.Application.Features.Category.Queries.GetAllCategories;
using Monhealth.Application.Models.Paging;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetCategoryListQuery : IRequest<PageResult<CategoryDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string Search { get; set; } = string.Empty;
        public CategoryType? Type { get; set; }
        public GetCategoryListQuery(int page, int limit, string search, CategoryType? type)
        {
            Page = page;
            Limit = limit;
            Search = search;
            Type = type;
        }

    }
}
