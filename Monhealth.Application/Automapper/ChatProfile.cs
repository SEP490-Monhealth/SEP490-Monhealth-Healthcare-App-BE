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
                .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(src => src.AppUser.PhoneNumber))
                .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(src => src.AppUser.Email))
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Consultant.AppUser.Email));
        }
    }
}
