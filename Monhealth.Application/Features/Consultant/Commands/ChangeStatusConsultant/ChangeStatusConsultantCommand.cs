using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.ChangeStatusConsultant
{
    public class ChangeStatusConsultantCommand : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
    }
}
