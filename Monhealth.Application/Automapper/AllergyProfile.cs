using AutoMapper;
using Monhealth.Application.Features.Allergy.Queries.GetAll;
using Monhealth.Core;

namespace Monhealth.Application.Automapper
{
    public class AllergyProfile : Profile
    {
        public AllergyProfile()
        {
                CreateMap<AllergyDTO , Allergy>().ReverseMap();
        }
    }
}