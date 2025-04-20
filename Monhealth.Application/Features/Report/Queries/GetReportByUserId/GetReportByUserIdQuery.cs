using MediatR;

namespace Monhealth.Application.Features.Report.Queries.GetReportByUserId
{
    public class GetReportByUserIdQuery : IRequest<List<GetReportByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}
