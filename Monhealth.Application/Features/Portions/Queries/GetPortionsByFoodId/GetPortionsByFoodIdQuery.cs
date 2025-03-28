using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionsByFoodId
{
    public class GetPortionsByFoodIdQuery : IRequest<PageResult<GetPortionsByFoodIdDto>>
    {
        public Guid FoodId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public string? Sort { get; set; }
        public string? Order { get; set; }
        public GetPortionsByFoodIdQuery(Guid foodId, int page, int limit, string? search, string? sort, string? order)
        {
            FoodId = foodId;
            Page = page;
            Limit = limit;
            Search = search;
            Sort = sort;
            Order = order;
        }
    }
}
