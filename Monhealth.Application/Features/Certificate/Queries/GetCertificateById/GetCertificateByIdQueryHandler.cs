using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificate;

namespace Monhealth.Application.Features.Certificate.Queries.GetCertificateById
{
    public class GetCertificateByIdQueryHandler(IMapper mapper, ICertificateRepository certificateRepository) : IRequestHandler<GetCertificateByIdQuery, GetCertificateByIdDTO>
    {
        public async Task<GetCertificateByIdDTO> Handle(GetCertificateByIdQuery request, CancellationToken cancellationToken)
        {
            var certificate = await certificateRepository.GetByIdAsync(request.CertificateId);
            if (certificate == null) throw new NotFoundException("Không tìm thấy chứng chỉ");
            return mapper.Map<GetCertificateByIdDTO>(certificate);
        }
    }
}
