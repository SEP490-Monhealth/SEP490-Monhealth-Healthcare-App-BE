using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Message.Queries.GetAllMessages
{
    public class GetAllMessageQueriesHandler(IMessageRepository messageRepository) : IRequestHandler<GetAllMessageQueries, List<MessageDto>>
    {
        public async Task<List<MessageDto>> Handle(GetAllMessageQueries request, CancellationToken cancellationToken)
        {
            var messages = await messageRepository.GetAllMessageAsync();
            var messageDtos = messages.Select(m => new MessageDto
            {
                MessageId = m.MessageId,
                ChatId = m.ChatId,
                SenderId = m.SenderId,
                Content = m.Content,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt,
            }).ToList();
            return messageDtos;
        }
    }
}
