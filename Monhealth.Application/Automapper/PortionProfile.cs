using AutoMapper;
using Monhealth.Application.Features.Portions.Commands.CreateFoodPortion;
using Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion;
using Monhealth.Application.Features.Portions.Queries.GetPortionById;
using Monhealth.Application.Features.Portions.Queries.GetPortionsByFoodId;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Automapper
{
    public class PortionProfile : Profile
    {
        public PortionProfile()
        {
            CreateMap<Portion, PortionDto>().ReverseMap();
            CreateMap<Portion, CreatePortionCommand>().ReverseMap();

            CreateMap<Portion, GetPortionByIdDto>().ReverseMap();
            CreateMap<Portion, GetPortionsByFoodIdDto>().ReverseMap();
        }
    }
}
