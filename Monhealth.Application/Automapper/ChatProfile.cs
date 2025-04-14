using AutoMapper;
using Monhealth.Application.Features.Chat.Queries.GetInfoChatById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ChatProfile : Profile
    {
        public ChatProfile()
        {
            CreateMap<Chat, GetInfoChatByIdDTO>()
                .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(src => src.AppUser.FullName))
                .ForPath(dest => dest.Member.Avatar, opt => opt.MapFrom(src => src.AppUser.Avatar))
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Avatar, opt => opt.MapFrom(src => src.Consultant.AppUser.Avatar));
        }
    }
}
