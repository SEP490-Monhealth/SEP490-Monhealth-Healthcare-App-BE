using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Report.Commands.CreateReport
{
    public class CreateReportCommandHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<CreateReportCommand, Unit>
    {
        public async Task<Unit> Handle(CreateReportCommand request, CancellationToken cancellationToken)
        {
            var newReport = mapper.Map<Domain.Report>(request.CreateReportDTO);
            newReport.ReportId = Guid.NewGuid();
            newReport.Status = Domain.Enum.StatusReport.Pending;
            newReport.CreatedAt = GetCurrentVietnamTime();
            newReport.UpdatedAt = GetCurrentVietnamTime();
            reportRepository.Add(newReport);
            await reportRepository.SaveChangeAsync();
            return Unit.Value;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
