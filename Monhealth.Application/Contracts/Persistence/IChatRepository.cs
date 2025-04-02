using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IChatRepository : IGenericRepository<Chat, Guid>
    {
        Task<Chat> GetChatByIdAsync(Guid chatId);
        Task<List<Chat>> GetUserChatAsync(Guid userId);
        Task<Chat> GetChatByParticipantAsync(Guid userId, Guid consultantId);
        Task<Chat> GetChatBySenderIdAndReceiverId(Guid senderId, Guid receiverId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
