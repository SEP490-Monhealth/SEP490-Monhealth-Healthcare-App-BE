using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Features.Message.Queries.GetMessageByConsultantId
{
    public class GetMessageByConsultantIdQueryHandler(IMessageRepository messageRepository) : IRequestHandler<GetMessageByConsultantIdQuery, List<MessageDto>>
    {
        public async Task<List<MessageDto>> Handle(GetMessageByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var messages = await messageRepository.GetMessageByConsultantId(request.ConsultantId);
            var messagesDto = messages.Select(m =>
            {
                return new MessageDto
                {
                    MessageId = m.MessageId,
                    ChatId = m.ChatId,
                    SenderId = m.SenderId,
                    Content = m.Content,
                    IsRead = m.IsRead,
                    CreatedAt = m.CreatedAt,
                    UpdatedAt = m.UpdatedAt,
                };
            }).ToList();

            return messagesDto;
        }
    }
}
