using MediatR;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertiseByConsultantId
{
    public class UpdateExpertiseByConsultantIdQueries : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
        public UpdateExpertiseByConsultantIdDto UpdateDto { get; set; }

        public UpdateExpertiseByConsultantIdQueries(Guid consultantId, UpdateExpertiseByConsultantIdDto updateDto)
        {
            ConsultantId = consultantId;
            UpdateDto = updateDto;
        }
    }
}
