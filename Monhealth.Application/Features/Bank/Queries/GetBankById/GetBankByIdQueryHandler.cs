using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Bank.Queries.GetBankById
{
    public class GetBankByIdQueryHandler(IBankRepository bankRepository, IMapper mapper) : IRequestHandler<GetBankByIdQuery, GetBankByIdDTO>
    {
        public async Task<GetBankByIdDTO> Handle(GetBankByIdQuery request, CancellationToken cancellationToken)
        {
            var bank = await bankRepository.GetByIdAsync(request.BankId);
            if (bank == null)
            {
                throw new Exception("Ngân hàng không tồn tại");
            }
            return mapper.Map<GetBankByIdDTO>(bank);
        }
    }
}
