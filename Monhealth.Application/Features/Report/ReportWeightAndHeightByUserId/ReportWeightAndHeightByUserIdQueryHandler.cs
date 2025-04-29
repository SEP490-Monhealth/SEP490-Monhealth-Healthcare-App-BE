using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Report.ReportWeightAndHeightByUserId
{
    public class ReportWeightAndHeightByUserIdQueryHandler(IMetricRepository metricRepository) : IRequestHandler<ReportWeightAndHeightByUserIdQuery, List<ReportWeightAndHeightByUserIdDTO>>
    {
        public async Task<List<ReportWeightAndHeightByUserIdDTO>> Handle(ReportWeightAndHeightByUserIdQuery request, CancellationToken cancellationToken)
        {
            var metrics = await metricRepository.GetWeightsAndHeightsByUserIdAsync(request.UserId);

            var result = metrics
                .Select(m => new ReportWeightAndHeightByUserIdDTO
                {
                    Date = m.CreatedAt,
                    Weight = m.Weight,
                    Height = m.Height
                }).ToList();
            return result;
        }
    }
}
