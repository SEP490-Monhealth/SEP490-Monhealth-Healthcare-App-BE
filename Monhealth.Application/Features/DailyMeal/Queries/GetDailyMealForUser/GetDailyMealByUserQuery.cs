using MediatR;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser
{
    public class GetDailyMealByUserQuery : IRequest<GetDailyMealByUserDTO>
    {
        public Guid UseId { get; set; }
        public DateTime date { get; set; }
        public GetDailyMealByUserQuery(Guid userId, DateTime dateTime)
        {
            UseId = userId;
            date = dateTime;
        }
    }
}