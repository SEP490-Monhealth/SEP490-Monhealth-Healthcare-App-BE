using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ChatRepository : GenericRepository<Chat, Guid>, IChatRepository
    {
        public ChatRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<Chat> GetChatByIdAsync(Guid chatId)
        {
            return await _context.Chats
                .Include(c => c.Messages)
                .FirstOrDefaultAsync(c => c.ChatId == chatId);
        }

        public async Task<Chat> GetChatByParticipantAsync(Guid userId, Guid consultantId)
        {
            return await _context.Chats
                .FirstOrDefaultAsync(c => c.UserId == userId && c.ConsultantId == consultantId ||
                                    (c.UserId == consultantId && c.ConsultantId == userId));


        }

        public async Task<Chat> GetChatBySenderIdAndReceiverId(Guid senderId, Guid receiverId)
        {
            return await _context.Chats
                .FirstOrDefaultAsync(c => c.UserId == senderId && c.ConsultantId == receiverId);
        }

        public async Task<List<Chat>> GetUserChatAsync(Guid userId)
        {
            return await _context.Chats
                           .Where(c => c.UserId == userId || c.ConsultantId == userId)
                           .OrderByDescending(c => c.LastMessage)
                           .ToListAsync();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
