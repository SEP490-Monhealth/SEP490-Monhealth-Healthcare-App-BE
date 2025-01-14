using AutoMapper;
using Monhealth.Application.Features.Allergy.Queries.GetAll;
using Monhealth.Application.Features.Allergy.Queries.GetByUser;
using Monhealth.Application.Features.Allergy.Queries.GetDetail;
using Monhealth.Core;

namespace Monhealth.Application.Automapper
{
    public class AllergyProfile : Profile
    {
        public AllergyProfile()
        {
            CreateMap<AllergyDTO, Allergy>().ReverseMap();
            CreateMap<AllergyDetailDTO, Allergy>().ReverseMap();
            CreateMap<AllergyByUserDTO, Allergy>().ReverseMap();
        }
    }
}