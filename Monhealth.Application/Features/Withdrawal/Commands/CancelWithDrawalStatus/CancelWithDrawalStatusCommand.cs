using MediatR;

namespace Monhealth.Application
{
    public class CancelWithdrawalStatusCommand : IRequest<Unit>
    {
        public Guid WithdrawalRequestId { get; set; }
        public CancelWithdrawalStatusCommand(Guid id)
        {
            WithdrawalRequestId = id;
        }


    }
}