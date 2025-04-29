using MediatR;

namespace Monhealth.Application.Features.Report.ReportWeightAndHeightByUserId
{
    public class ReportWeightAndHeightByUserIdQuery : IRequest<List<ReportWeightAndHeightByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}
