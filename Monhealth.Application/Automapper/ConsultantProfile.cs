using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.Consultant.Commands.CreateConsultant;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ConsultantProfile : Profile
    {
        public ConsultantProfile()
        {
            CreateMap<Consultant, CreateConsultantDTO>().ReverseMap();
        }
    }
}
