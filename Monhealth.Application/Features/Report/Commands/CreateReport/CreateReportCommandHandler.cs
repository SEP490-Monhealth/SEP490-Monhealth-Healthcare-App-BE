using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Report.Commands.CreateReport
{
    public class CreateReportCommandHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<CreateReportCommand, Unit>
    {
        public async Task<Unit> Handle(CreateReportCommand request, CancellationToken cancellationToken)
        {
            var newReport = mapper.Map<Domain.Report>(request.CreateReportDTO);
            newReport.ReportId = Guid.NewGuid();
            newReport.Status = Domain.Enum.StatusReport.Pending;
            newReport.CreatedAt = DateTime.Now;
            newReport.UpdatedAt = DateTime.Now;
            reportRepository.Add(newReport);
            await reportRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
