using AutoMapper;
using Monhealth.Application.Features.Certificate.Commands.CreateCertificate;
using Monhealth.Application.Features.Certificate.Commands.UpdateCertificate;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificate;
using Monhealth.Application.Features.Certificate.Queries.GetCertificateById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class CertificateProfile : Profile
    {
        public CertificateProfile()
        {
            CreateMap<CertificateCommand, Certificate>();
            CreateMap<Certificate, UpdateCertificateDTO>().ReverseMap();
            CreateMap<Certificate, CertificateDto>().ReverseMap();
            CreateMap<Certificate, GetCertificateByIdDTO>().ReverseMap();
        }
    }
}
