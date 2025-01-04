using MediatR;

namespace Monhealth.Application.Features.Meal.Queries.GetMealByUser
{
    public class GetMealByUserQuery : IRequest<List<GetMealByUserDTO>>
    {
        public Guid UserId { get; set; }
    }
}