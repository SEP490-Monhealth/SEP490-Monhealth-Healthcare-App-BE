using MediatR;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class GenerateWithdrawalQRCode : IRequest<Response>
    {
        public Guid WithDrawalRequestId { get; init; }
        public GenerateWithdrawalQRCode(Guid id)
        {
            WithDrawalRequestId = id;
        }
    }

}