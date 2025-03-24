using MediatR;
namespace Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId
{
    public class GetDailyActivityByUserIdQuery : IRequest<GetDailyActivityByUserIdDTO>
    {
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public GetDailyActivityByUserIdQuery(Guid userId, DateTime date)
        {
            UserId = userId;
            Date = date;
        }
    }
}
