using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using System.Text.Json;

namespace Monhealth.Application.Features.Certificate.Commands.CreateCertificate
{
    public class CertificateCommandHandler(IMapper mapper, ICertificateRepository certificateRepository) : IRequestHandler<CertificateCommand, Unit>
    {
        public async Task<Unit> Handle(CertificateCommand request, CancellationToken cancellationToken)
        {
            var isNameExist = await certificateRepository.AnyAsync(c => c.CertificateName == request.CertificateName);
            if (isNameExist) throw new BadRequestException("Tên chứng chỉ đã tồn tại");
            string imageUrls = JsonSerializer.Serialize(request.Images);
            var certificate = mapper.Map<Domain.Certificate>(request);
            if (imageUrls != null)
            {
                certificate.Images = imageUrls;
            }
            certificate.Status = false;
            certificateRepository.Add(certificate);
            await certificateRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
