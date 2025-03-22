using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion
{
    public class GetAllPortionQuery : IRequest<PageResult<PortionDto>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string sort { get; set; }
        public string order { get; set; }

        public GetAllPortionQuery(int page, int limit, string sort, string order)
        {
            Page = page;
            Limit = limit;
            this.sort = sort;
            this.order = order;
        }
    }
}
