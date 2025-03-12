using AutoMapper;
using Monhealth.Application.Features.Expertise.Commands.CreateExpertise;
using Monhealth.Application.Features.Expertise.Commands.UpdateExpertise;
using Monhealth.Application.Features.Expertise.Queries.GetAllExpertises;
using Monhealth.Application.Features.Expertise.Queries.GetExpertiseById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ExpertiseProfile : Profile
    {
        public ExpertiseProfile()
        {
            CreateMap<GetAllExpertisesDTO, Expertise>().ReverseMap();
            CreateMap<GetExpertiseByIdDTO, Expertise>().ReverseMap();
            CreateMap<CreateExpertiseDTO, Expertise>().ReverseMap();
            CreateMap<UpdateExpertiseDTO, Expertise>().ReverseMap();
        }
    }
}
