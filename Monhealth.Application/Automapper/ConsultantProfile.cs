using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.Consultant.Commands.CreateConsultant;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ConsultantProfile : Profile
    {
        public ConsultantProfile()
        {
            CreateMap<GetAllConsultantsDTO, Consultant>().ReverseMap();

            CreateMap<CreateConsultantDTO, Consultant>().ReverseMap();
            CreateMap<CreateConsultantDTO, Expertise>().ReverseMap();
            CreateMap<CreateConsultantDTO, Certificate>().ReverseMap();
        }
    }
}
