using MediatR;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class GenerateWithdrawalQRCode : IRequest<Response>
    {
        public Guid WithdrawalRequestId { get; init; }
        public GenerateWithdrawalQRCode(Guid id)
        {
            WithdrawalRequestId = id;
        }
    }

}