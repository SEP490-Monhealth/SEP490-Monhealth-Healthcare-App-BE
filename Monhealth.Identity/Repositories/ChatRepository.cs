using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ChatRepository : GenericRepository<Chat, Guid>, IChatRepository
    {
        public ChatRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<PaginatedResult<Chat>> GetChatByConsultantIdAsync(int page, int limit, Guid consultantId, string? search)
        {
            var query = _context.Chats
                .Include(c => c.AppUser)
                .Include(c => c.Consultant).ThenInclude(c => c.AppUser)
                .Where(c => c.ConsultantId == consultantId)
                .OrderByDescending(c => c.UpdatedAt)
                .AsQueryable();
            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => s.AppUser.PhoneNumber.ToLower().Contains(search.ToLower()) ||
                                         s.AppUser.Email.ToLower().Contains(search.ToLower()) ||
                                         EF.Functions.Collate(s.Consultant.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()));
            }
            var totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Chat>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
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

        public async Task<Chat> GetChatInfoUserAndConsultantByChatId(Guid chatId)
        {
            var infoChat = await _context.Chats
                .Include(c => c.Consultant).ThenInclude(u => u.AppUser)
                .Include(u => u.AppUser)
                .FirstOrDefaultAsync(c => c.ChatId == chatId);
            return infoChat;
        }

        public async Task<PaginatedResult<Chat>> GetUserChatAsync(int page, int limit, Guid userId, string? search)
        {
            IQueryable<Chat> query = _context.Chats
                .Include(c => c.AppUser)
                .Include(c => c.Consultant).ThenInclude(c => c.AppUser)
                .Where(c => c.UserId == userId)
                .OrderByDescending(c => c.UpdatedAt)
                .AsQueryable();
            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => s.Consultant.AppUser.PhoneNumber.ToLower().Contains(search.ToLower()) ||
                                         s.Consultant.AppUser.Email.ToLower().Contains(search.ToLower()) ||
                                         EF.Functions.Collate(s.Consultant.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()));
            }
            var totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Chat>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
