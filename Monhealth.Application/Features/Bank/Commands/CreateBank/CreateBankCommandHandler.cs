using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Bank.Commands.CreateBank
{
    public class CreateBankCommandHandler(IBankRepository bankRepository, IMapper mapper) : IRequestHandler<CreateBankCommand, Unit>
    {
        public async Task<Unit> Handle(CreateBankCommand request, CancellationToken cancellationToken)
        {
            var checkBankName = await bankRepository.CheckBankNameExisted(request.CreateBankDTO.BankName);
            if (checkBankName != null)
            {
                throw new Exception("Tên ngân hàng đã tồn tại");
            }
            var newBank = mapper.Map<Domain.Bank>(request.CreateBankDTO);
            newBank.BankId = Guid.NewGuid();
            newBank.Status = false;
            newBank.CreatedAt = DateTime.Now;
            newBank.UpdatedAt = DateTime.Now;
            bankRepository.Add(newBank);
            await bankRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
