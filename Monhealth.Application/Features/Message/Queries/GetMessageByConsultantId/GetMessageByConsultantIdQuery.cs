using MediatR;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Features.Message.Queries.GetMessageByConsultantId
{
    public class GetMessageByConsultantIdQuery : IRequest<List<MessageDto>>
    {
        public Guid ConsultantId { get; set; }

    }
}
