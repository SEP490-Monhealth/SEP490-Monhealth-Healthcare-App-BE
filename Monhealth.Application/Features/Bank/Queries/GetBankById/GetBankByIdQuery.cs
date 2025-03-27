using MediatR;

namespace Monhealth.Application.Features.Bank.Queries.GetBankById
{
    public class GetBankByIdQuery : IRequest<GetBankByIdDTO>
    {
        public Guid BankId { get; set; }
    }
}
