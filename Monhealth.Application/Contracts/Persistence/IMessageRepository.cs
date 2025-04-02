using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMessageRepository : IGenericRepository<Message, Guid>
    {
        Task<List<Message>> GetAllMessageAsync();
        Task<List<Message>> GetMessageByChatId(Guid chatId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);

    }
}
