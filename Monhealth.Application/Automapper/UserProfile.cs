using AutoMapper;
using Monhealth.Application.Features.User.Queries.GetAllUser;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Automapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserDto>().ReverseMap();
        }
    }
}
