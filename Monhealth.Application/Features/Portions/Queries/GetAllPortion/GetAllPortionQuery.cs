using MediatR;

namespace Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion
{
    public class GetAllPortionQuery : IRequest<List<PortionDto>>
    {
        public string sort { get; set; }
        public string order { get; set; }
        public GetAllPortionQuery(string sortBy, string orderBy)
        {
            sort = sortBy;
            order = orderBy;
        }
    }
}
