using AutoMapper;
using Monhealth.Application.Features.Certificate.Commands.CreateCertificate;
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
            CreateMap<Certificate, CertificateDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Consultant.AppUser.FullName));
            CreateMap<Certificate, GetCertificateByIdDTO>().ReverseMap();
        }
    }
}
