using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Chat.Queries.GetInfoChatById
{
    public class GetInfoChatByIdQueryHandler(IChatRepository chatRepository, IMapper mapper) : IRequestHandler<GetInfoChatByIdQuery, GetInfoChatByIdDTO>
    {
        public async Task<GetInfoChatByIdDTO> Handle(GetInfoChatByIdQuery request, CancellationToken cancellationToken)
        {
            var chat = await chatRepository.GetChatInfoUserAndConsultantByChatId(request.ChatId);
            if(chat == null)
            {
                throw new Exception("Cuộc trò chuyện không tồn tại.");
            }
            return mapper.Map<GetInfoChatByIdDTO>(chat);
            //return new GetInfoChatByIdDTO
            //{
            //    ChatId = chat.ChatId,
            //    UserId = chat.UserId,
            //    ConsultantId = chat.ConsultantId,
            //    Member = new Member
            //    {
            //        Email = chat.AppUser.Email,
            //        FullName = chat.AppUser.FullName,
            //        PhoneNumber = chat.AppUser.PhoneNumber,
            //    },
            //    Consultant = new Consultant
            //    {
            //        Email = chat.Consultant.AppUser.Email,
            //        FullName = chat.Consultant.AppUser.FullName,
            //        PhoneNumber = chat.Consultant.AppUser.PhoneNumber,
            //    },
            //    CreatedAt = chat.CreatedAt,
            //    UpdatedAt = chat.UpdatedAt,
            //    CreatedBy = chat.CreatedBy,
            //    UpdatedBy = chat.UpdatedBy,
            //};
        }
    }
}
