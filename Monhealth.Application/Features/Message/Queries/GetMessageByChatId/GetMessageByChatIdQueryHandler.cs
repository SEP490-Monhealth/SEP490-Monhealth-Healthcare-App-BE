using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Features.Message.Queries.GetMessageByChatId
{
    public class GetMessageByChatIdQueryHandler(IMessageRepository messageRepository,
            IUserRepository userRepository
        ) : IRequestHandler<GetMessageByChatIdQuery, List<MessageDto>>
    {
        public async Task<List<MessageDto>> Handle(GetMessageByChatIdQuery request, CancellationToken cancellationToken)
        {
            var messages = await messageRepository.GetMessageByChatId(request.ChatId);
            //var userIds = await userRepository.GetAllUserIds();

            var messageDtos = messages.Select(m =>
            {
                //bool IsUser = userIds.Contains(m.SenderId);
                return new MessageDto
                {
                    MessageId = m.MessageId,
                    ChatId = m.ChatId,
                    SenderId = m.SenderId,
                    //IsSender = IsUser,
                    Content = m.Content,
                    IsRead = m.IsRead,
                    CreatedAt = m.CreatedAt,
                    UpdatedAt = m.UpdatedAt
                };
            }).ToList();
            return messageDtos;
        }


    }
}

