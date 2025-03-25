using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.VeryfiedConsultant
{
    public class VeryfiedConsultantCommand : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }

    }
}
