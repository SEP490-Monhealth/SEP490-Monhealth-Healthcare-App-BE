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

        public Task<int> SaveChangeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
