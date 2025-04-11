using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Features.Message.Queries.GetMessageByChatId
{
    public class GetMessageByChatIdQueryHandler(IMessageRepository messageRepository,
            IUserRepository userRepository,
            IConsultantRepository consultantRepository
        ) : IRequestHandler<GetMessageByChatIdQuery, List<MessageDto>>
    {
        public async Task<List<MessageDto>> Handle(GetMessageByChatIdQuery request, CancellationToken cancellationToken)
        {
            var messages = await messageRepository.GetMessageByChatId(request.ChatId);
            //var userIds = await userRepository.GetAllUserIds();

            var senderIds = messages.Select(m => m.SenderId).Distinct().ToList();

            // Truy vấn avatar từ bảng Users và Consultants
            var userAvatars = await userRepository.GetAvatarsByUserIds(senderIds); // Dictionary<Guid, string>
            var consultantAvatars = await consultantRepository.GetAvatarsByConsultantIds(senderIds);

            var avatarLookup = userAvatars
                .Concat(consultantAvatars)
                  .ToDictionary(x => x.Key, x => x.Value);

            var messageDtos = messages.Select(m =>
            {
                avatarLookup.TryGetValue(m.SenderId, out var avatarUrl);
                return new MessageDto
                {
                    MessageId = m.MessageId,
                    ChatId = m.ChatId,
                    SenderId = m.SenderId,
                    AvatarUrl = avatarUrl,
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

