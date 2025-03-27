using MediatR;

namespace Monhealth.Application.Features.ConsultantBank.Commands.UpdateConsultantBank
{
    public class UpdateConsultantBankCommand : IRequest<bool>
    {
        public Guid ConsultantBankId { get; set; }
        public UpdateConsultantBankDTO UpdateConsultantBankDTO { get; set; }
        public UpdateConsultantBankCommand(Guid consultantBankId, UpdateConsultantBankDTO updateConsultantBankDTO)
        {
            ConsultantBankId = consultantBankId;
            UpdateConsultantBankDTO = updateConsultantBankDTO;
        }
    }
}
