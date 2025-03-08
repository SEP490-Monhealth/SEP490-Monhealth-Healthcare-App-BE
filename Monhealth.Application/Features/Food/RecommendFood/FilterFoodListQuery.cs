using MediatR;

namespace Monhealth.Application
{
    public class FilterFoodListQuery : IRequest<int>
    {
            public Guid UserId { get; set; }
    }
}