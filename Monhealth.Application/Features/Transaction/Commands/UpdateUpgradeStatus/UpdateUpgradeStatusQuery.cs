using MediatR;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateUpgradeStatus
{
    public class UpdateUpgradeStatusQuery : IRequest<bool>
    {
        public long OrderCode { get; set; }
    }
}
