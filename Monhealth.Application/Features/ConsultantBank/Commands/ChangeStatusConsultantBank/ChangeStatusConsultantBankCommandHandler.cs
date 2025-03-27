using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.ConsultantBank.Commands.ChangeStatusConsultantBank
{
    public class ChangeStatusConsultantBankCommandHandler(IConsultantBankRepository consultantBankRepository) : IRequestHandler<ChangeStatusConsultantBankCommand, bool>
    {
        public async Task<bool> Handle(ChangeStatusConsultantBankCommand request, CancellationToken cancellationToken)
        {
            var consultantBank = await consultantBankRepository.GetByIdAsync(request.ConsultantBankId);
            if (consultantBank == null)
            {
                return false;
            }
            consultantBank.Status = !consultantBank.Status;
            consultantBankRepository.Update(consultantBank);
            await consultantBankRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
