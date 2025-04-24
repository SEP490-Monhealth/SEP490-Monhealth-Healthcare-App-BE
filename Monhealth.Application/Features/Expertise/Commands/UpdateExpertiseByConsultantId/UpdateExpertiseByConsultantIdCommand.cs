using MediatR;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertiseByConsultantId
{
    public class UpdateExpertiseByConsultantIdCommand : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
        public UpdateExpertiseByConsultantIdDto UpdateDto { get; set; }

        public UpdateExpertiseByConsultantIdCommand(Guid consultantId, UpdateExpertiseByConsultantIdDto updateDto)
        {
            ConsultantId = consultantId;
            UpdateDto = updateDto;
        }
    }
}
