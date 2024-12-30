using MediatR;

namespace Monhealth.Application.Features.Food.Queries.GetFoodById
{
    public class GetFoodByIdQuery : IRequest<GetFoodByIdDTO>
    {
        public Guid FoodId { get; set; }

    }
}