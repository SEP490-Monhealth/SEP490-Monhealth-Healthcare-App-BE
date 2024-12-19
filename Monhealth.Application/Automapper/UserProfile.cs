using AutoMapper;
using Monhealth.Application.Features.User.Queries.GetAllUser;
using Monhealth.Application.Features.User.Queries.GetUserDetail;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Automapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.AvatarUrl, opt => opt.MapFrom(src => src.Avatar));

            CreateMap<AppUser, UserDetailDto>()
                 .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.AvatarUrl, opt => opt.MapFrom(src => src.Avatar));

        }
    }
}
