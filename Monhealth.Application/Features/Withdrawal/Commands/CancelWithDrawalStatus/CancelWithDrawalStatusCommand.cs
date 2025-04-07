using MediatR;
using Monhealth.Application.Features.Withdrawal.Commands.CancelWithDrawalStatus;

namespace Monhealth.Application
{
    public class CancelWithdrawalStatusCommand : IRequest<Unit>
    {
        public Guid WithdrawalRequestId { get; set; }
        public CancelWithdrawalStatusDTO CancelWithdrawalStatusDTO { get; set; }
        public CancelWithdrawalStatusCommand(Guid id, CancelWithdrawalStatusDTO cancelWithdrawalStatusDTO)
        {
            WithdrawalRequestId = id;
            CancelWithdrawalStatusDTO = cancelWithdrawalStatusDTO;
        }
    }
}