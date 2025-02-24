using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificate;

namespace Monhealth.Application.Features.Certificate.Queries.GetCertificateById
{
    public class GetCertificateByIdQueryHandler(IMapper mapper, ICertificateRepository certificateRepository) : IRequestHandler<GetCertificateByIdQuery, CertificateDto>
    {
        public async Task<CertificateDto> Handle(GetCertificateByIdQuery request, CancellationToken cancellationToken)
        {
            var certificate = await certificateRepository.GetByIdAsync(request.CertificateId);
            if (certificate == null) throw new NotFoundException("Không tìm thấy chứng chỉ");
            return mapper.Map<CertificateDto>(certificate);
        }
    }
}
