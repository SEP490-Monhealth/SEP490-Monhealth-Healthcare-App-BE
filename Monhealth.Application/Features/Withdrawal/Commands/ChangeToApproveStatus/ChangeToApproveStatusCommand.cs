using MediatR;

namespace Monhealth.Application.Features.Withdrawal.Commands.ChangeToApproveStatus
{
    public class ChangeToApproveStatusCommand : IRequest<bool>
    {
        public Guid WithdrawalRequestId { get; set; }
    }
}
