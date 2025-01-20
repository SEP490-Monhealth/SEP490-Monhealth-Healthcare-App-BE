using MediatR;

namespace Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater
{
    public class GetDailyWaterByUserQuery : IRequest<DailyWaterDTO>
    {
        public Guid userId { get; set; }
        public DateTime date { get; set; }
        public GetDailyWaterByUserQuery(Guid UserId, DateTime dateTime)
        {
            userId = UserId;
            date = dateTime;
        }
    }
}
