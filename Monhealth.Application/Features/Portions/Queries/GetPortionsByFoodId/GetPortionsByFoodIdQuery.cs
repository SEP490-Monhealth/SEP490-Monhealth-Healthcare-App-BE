using MediatR;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionsByFoodId
{
    public class GetPortionsByFoodIdQuery : IRequest<List<GetPortionsByFoodIdDto>>
    {
        public Guid FoodId { get; set; }
    }
}
