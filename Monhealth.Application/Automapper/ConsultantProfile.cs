using AutoMapper;
using Monhealth.Application.Features.Consultant.Commands.CreateConsultant;
using Monhealth.Application.Features.Consultant.Commands.UpdateConsultant;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;
using Monhealth.Application.Features.Consultant.Queries.GetConsultantById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ConsultantProfile : Profile
    {
        public ConsultantProfile()
        {
            CreateMap<Consultant, GetAllConsultantsDTO>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.AppUser.FullName))
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.AppUser.Avatar))
                .ForMember(dest => dest.ExpertiseName, opt => opt.MapFrom(src => src.Expertise.ExpertiseName));

            CreateMap<Consultant, GetConsultantByIdDTO>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.AppUser.FullName))
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.AppUser.Avatar))
                .ForMember(dest => dest.ExpertiseName, opt => opt.MapFrom(src => src.Expertise.ExpertiseName));

            CreateMap<CreateConsultantDTO, Consultant>().ReverseMap();
            CreateMap<CreateConsultantDTO, Expertise>().ReverseMap();
            CreateMap<CreateConsultantDTO, Certificate>().ReverseMap();

            CreateMap<UpdateConsultantDTO, Consultant>().ReverseMap();
        }
    }
}
