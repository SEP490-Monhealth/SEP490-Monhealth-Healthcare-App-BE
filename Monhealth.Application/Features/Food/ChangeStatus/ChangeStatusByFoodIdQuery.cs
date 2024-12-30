using MediatR;

namespace Monhealth.Application.Features.Food.ChangeStatus
{
    public class ChangeStatusByFoodIdQuery : IRequest<bool>
    {
        public Guid FoodId { get; set; }
    }
}