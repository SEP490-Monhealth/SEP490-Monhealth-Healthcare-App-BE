using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Features.Message.Queries.GetMessageByChatId
{
    public class GetMessageByChatIdQueryHandler(IMessageRepository messageRepository) : IRequestHandler<GetMessageByChatIdQuery, List<MessageDto>>
    {
        public async Task<List<MessageDto>> Handle(GetMessageByChatIdQuery request, CancellationToken cancellationToken)
        {
            var messages = await messageRepository.GetMessageByChatId(request.ChatId);

            var messageDtos = messages.Select(m => new MessageDto
            {
                MessageId = m.MessageId,
                ChatId = m.ChatId,
                SenderId = m.SenderId,
                Content = m.Content,
                IsRead = m.IsRead,
            }).ToList();
            return messageDtos;
        }
    }
}
