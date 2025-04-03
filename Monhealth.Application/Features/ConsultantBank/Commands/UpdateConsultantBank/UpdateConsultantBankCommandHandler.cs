using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.ConsultantBank.Commands.UpdateConsultantBank
{
    public class UpdateConsultantBankCommandHandler(IConsultantBankRepository consultantBankRepository,
        IBankRepository bankRepository,
        IMapper mapper) : IRequestHandler<UpdateConsultantBankCommand, bool>
    {
        public async Task<bool> Handle(UpdateConsultantBankCommand request, CancellationToken cancellationToken)
        {
            if (await consultantBankRepository.CheckAccountNumber(request.UpdateConsultantBankDTO.AccountNumber))
            {
                throw new Exception("Số tài khoản đã tồn tại");
            }
            var consultantBank = await consultantBankRepository.GetByIdAsync(request.ConsultantBankId);
            if (consultantBank == null)
            {
                return false;
            }
            var consultantBankToUpdate = mapper.Map(request.UpdateConsultantBankDTO, consultantBank);
            consultantBankToUpdate.UpdatedAt = DateTime.Now;
            consultantBankRepository.Update(consultantBankToUpdate);
            await consultantBankRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
