using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificates;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class CertificateProfile : Profile
    {
        public CertificateProfile()
        {
            CreateMap<GetAllCertificatesDTO, Certificate>().ReverseMap();
        }
    }
}
