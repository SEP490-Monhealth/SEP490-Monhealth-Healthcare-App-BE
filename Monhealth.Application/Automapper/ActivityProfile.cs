using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.Activity.Commands.CreateActivity;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ActivityProfile : Profile
    {
        public ActivityProfile()
        {
            CreateMap<Activity, CreateActivityDTO>().ReverseMap();
        }
    }
}
