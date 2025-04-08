using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.RejectConsultant
{
    public class RejectConsultantCommand : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
    }
}
