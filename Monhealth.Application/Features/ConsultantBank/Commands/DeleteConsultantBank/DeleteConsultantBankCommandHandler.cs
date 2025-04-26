using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.ConsultantBank.Commands.DeleteConsultantBank
{
    public class DeleteConsultantBankCommandHandler(IConsultantBankRepository consultantBankRepository) : IRequestHandler<DeleteConsultantBankCommand, bool>
    {
        public async Task<bool> Handle(DeleteConsultantBankCommand request, CancellationToken cancellationToken)
        {
            var consultantBank = await consultantBankRepository.GetByIdAsync(request.ConsultantBankId);
            if (consultantBank == null)
            {
                return false;
            }
            var consultantBanks = await consultantBankRepository.GetConsultantBankByConsultantIdAsync(consultantBank.ConsultantId);

            if (consultantBanks.Count() <= 1)
            {
                return false;   
            }
            consultantBankRepository.Remove(consultantBank);
            await consultantBankRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
