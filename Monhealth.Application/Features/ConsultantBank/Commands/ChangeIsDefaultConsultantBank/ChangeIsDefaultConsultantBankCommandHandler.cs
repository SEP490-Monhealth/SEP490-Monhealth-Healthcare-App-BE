using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.ConsultantBank.Commands.ChangeIsDefaultConsultantBank
{
    public class ChangeIsDefaultConsultantBankCommandHandler(IConsultantBankRepository consultantBankRepository) : IRequestHandler<ChangeIsDefaultConsultantBankCommand, bool>
    {
        public async Task<bool> Handle(ChangeIsDefaultConsultantBankCommand request, CancellationToken cancellationToken)
        {
            var consultantBank = await consultantBankRepository.GetByIdAsync(request.ConsultantBankId);
            if (consultantBank == null)
            {
                return false;
            }
            consultantBank.IsDefault = !consultantBank.IsDefault;
            consultantBankRepository.Update(consultantBank);
            await consultantBankRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
