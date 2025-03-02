using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.DeleteConsultant
{
    public class DeleteConsultantCommand : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
    }
}
