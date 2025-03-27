using MediatR;

namespace Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank
{
    public class CreateConsultantBankCommand : IRequest<Unit>
    {
        public CreateConsultantBankDTO CreateConsultantBankDTO { get; set; }
        public CreateConsultantBankCommand(CreateConsultantBankDTO createConsultantBankDTO)
        {
            CreateConsultantBankDTO = createConsultantBankDTO;
        }
    }
}
