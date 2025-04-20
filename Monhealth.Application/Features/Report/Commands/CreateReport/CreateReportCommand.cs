using MediatR;

namespace Monhealth.Application.Features.Report.Commands.CreateReport
{
    public class CreateReportCommand : IRequest<Unit>
    {
        public CreateReportDTO CreateReportDTO { get; set; }
        public CreateReportCommand(CreateReportDTO createReportDTO)
        {
            CreateReportDTO = createReportDTO;
        }
    }
}
