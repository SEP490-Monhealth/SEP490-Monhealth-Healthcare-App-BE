using MediatR;

namespace Monhealth.Application
{
    public class UpdateStatusWithdrawalCommand : IRequest<Unit>
    {
        public Guid WithdrawalRequestId { get; set; }
        public UpdateStatusWithdrawalCommand(Guid id)
        {
            WithdrawalRequestId = id;
        }

    }
}