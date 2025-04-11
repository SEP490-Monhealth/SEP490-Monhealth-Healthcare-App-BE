using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class MessageRepository : GenericRepository<Message, Guid>, IMessageRepository
    {
        public MessageRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<List<Message>> GetAllMessageAsync()
        {
            return await _context.Messages.AsNoTracking().AsSingleQuery().ToListAsync();
        }

        public async Task<List<Message>> GetMessageByChatId(Guid chatId)
        {
            return await _context.Messages.AsNoTracking()
                .AsSingleQuery()
                .Where(m => m.ChatId == chatId)
                .OrderByDescending(m => m.CreatedAt)
                .ToListAsync();
        }

        public async Task<List<Message>> GetMessageByConsultantId(Guid consultantId)
        {
            return await _context.Messages.AsNoTracking()
                .AsSingleQuery()
                .Where(m => m.SenderId == consultantId)
                .ToListAsync();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
