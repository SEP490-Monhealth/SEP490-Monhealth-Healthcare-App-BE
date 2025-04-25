using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Certificate.Commands.UpdateCertificate
{
    public class UpdateCertificateCommandHandler : IRequestHandler<UpdateCertificateCommand, bool>
    {
        private readonly ICertificateRepository _certificateRepository;
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly IMapper _mapper;
        public UpdateCertificateCommandHandler(ICertificateRepository certificateRepository, IExpertiseRepository expertiseRepository, IMapper mapper)
        {
            _certificateRepository = certificateRepository;
            _expertiseRepository = expertiseRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(UpdateCertificateCommand request, CancellationToken cancellationToken)
        {
            var checkExpertiseExisted = await _expertiseRepository.GetExpertiseByNameAsync(request.UpdateCertificateDTO.ExpertiseName);

            var certificate = await _certificateRepository.GetByIdAsync(request.CertificateId);
            if (certificate == null)
            {
                return false;
            }
            var updateCertificate = _mapper.Map(request.UpdateCertificateDTO, certificate);
            updateCertificate.ExpertiseId = checkExpertiseExisted.ExpertiseId;
            updateCertificate.IsVerified = false;
            updateCertificate.UpdatedAt = DateTime.UtcNow;
            _certificateRepository.Update(updateCertificate);

            await _certificateRepository.SaveChangeAsync();
            return true;
        }
    }
}
