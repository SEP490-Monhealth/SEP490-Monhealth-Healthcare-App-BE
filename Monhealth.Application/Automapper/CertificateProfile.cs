using AutoMapper;
using Monhealth.Application.Features.Certificate.Commands.CreateCertificate;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificate;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class CertificateProfile : Profile
    {
        public CertificateProfile()
        {
            CreateMap<CertificateCommand, Certificate>();
            CreateMap<Certificate, CertificateDto>();
        }
    }
}
