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
            CreateMap<AppUser, UserDto>().ReverseMap();
            CreateMap<AppUser, UserDetailDto>().ReverseMap();
        }
    }
}
