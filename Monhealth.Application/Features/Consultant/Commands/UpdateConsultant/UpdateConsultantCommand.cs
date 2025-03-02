using MediatR;

namespace Monhealth.Application.Features.Consultant.Commands.UpdateConsultant
{
    public class UpdateConsultantCommand : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
        public UpdateConsultantDTO UpdateConsultantDTO { get; set; }
        public UpdateConsultantCommand(Guid consultantId, UpdateConsultantDTO updateConsultantDTO)
        {
            ConsultantId = consultantId;
            UpdateConsultantDTO = updateConsultantDTO;
        }
    }
}
