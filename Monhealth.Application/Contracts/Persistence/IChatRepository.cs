using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IChatRepository : IGenericRepository<Chat, Guid>
    {
        Task<Chat> GetChatByIdAsync(Guid chatId);
        Task<PaginatedResult<Chat>> GetUserChatAsync(int page, int limit, Guid userId);
        Task<PaginatedResult<Chat>> GetChatByConsultantIdAsync(int page, int limit, Guid consultantId);
        Task<Chat> GetChatByParticipantAsync(Guid userId, Guid consultantId);
        Task<Chat> GetChatBySenderIdAndReceiverId(Guid senderId, Guid receiverId);
        Task<Chat> GetChatInfoUserAndConsultantByChatId(Guid chatId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
