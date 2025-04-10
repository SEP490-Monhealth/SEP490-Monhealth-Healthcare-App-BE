using MediatR;

namespace Monhealth.Application
{
    public class GetDailyMealReportByUserQuery : IRequest<List<GetDailyMealDataDTO>>
    {
        public Guid UserId { get; set; }
        public DateTime date { get; set; }
    }
}