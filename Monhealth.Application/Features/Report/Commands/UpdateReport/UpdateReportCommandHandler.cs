using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Report.Commands.UpdateReport
{
    public class UpdateReportCommandHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<UpdateReportCommand, bool>
    {
        public async Task<bool> Handle(UpdateReportCommand request, CancellationToken cancellationToken)
        {
            var report = await reportRepository.GetByIdAsync(request.ReportId);
            if (report == null)
            {
                return false;
            }
            var reportToUpdate = mapper.Map(request.UpdateReportDTO, report);
            report.UpdatedAt = GetCurrentVietnamTime();
            reportRepository.Update(reportToUpdate);
            await reportRepository.SaveChangeAsync();
            return true;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
