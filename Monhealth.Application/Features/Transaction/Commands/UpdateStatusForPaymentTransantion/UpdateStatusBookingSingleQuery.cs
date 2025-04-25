using MediatR;
using Net.payOS.Types;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateStatusForBookingSingle
{
    public class UpdateStatusBookingSingleQuery : IRequest<bool>
    {
        public WebhookType WebhookType { get; set; }
    }
}
