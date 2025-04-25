using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Microsoft.Extensions.Logging;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertiseByConsultantId
{
    public class UpdateExpertiseByConsultantIdCommandHandler : IRequestHandler<UpdateExpertiseByConsultantIdCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly ICertificateRepository _certificateRepository;
        private readonly ILogger<UpdateExpertiseByConsultantIdCommandHandler> _logger;

        public UpdateExpertiseByConsultantIdCommandHandler(
            IConsultantRepository consultantRepository,
            IExpertiseRepository expertiseRepository,
            ICertificateRepository certificateRepository,
            ILogger<UpdateExpertiseByConsultantIdCommandHandler> logger)
        {
            _consultantRepository = consultantRepository;
            _expertiseRepository = expertiseRepository;
            _certificateRepository = certificateRepository;
            _logger = logger;
        }

        public async Task<bool> Handle(UpdateExpertiseByConsultantIdCommand request, CancellationToken cancellationToken)
        {
            // Lấy consultant theo Id
            var consultant = await _consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
                throw new BadRequestException("Không tìm thấy Consultant bằng Id");

            // Lấy expertise theo tên
            var expertise = await _expertiseRepository.GetExpertiseByNameAsync(request.UpdateDto.Expertise);
            if (expertise == null)
                throw new BadRequestException("Tên chuyên môn không đúng");

            var certificates = await _certificateRepository.GetCertificateByConsultant(consultant.ConsultantId);            
            if (certificates == null || certificates.Count == 0)
            {
                _logger.LogWarning("Không tìm thấy certificate cho consultant với Id {ConsultantId}", consultant.ConsultantId);
            }

            var targetCertificate =  certificates.FirstOrDefault();

            if (targetCertificate != null)
            {
                targetCertificate.ExpertiseId = expertise.ExpertiseId;
                targetCertificate.CertificateName = request.UpdateDto.CertificateName;
                targetCertificate.IssueDate = request.UpdateDto.IssueDate;
                targetCertificate.ExpiryDate = request.UpdateDto.ExpiryDate;
                targetCertificate.ImageUrls = request.UpdateDto.ImageUrls;
                targetCertificate.IssuedBy = request.UpdateDto.IssuedBy;
                targetCertificate.UpdatedAt = DateTime.UtcNow;
                targetCertificate.CertificateNumber = request.UpdateDto.CertificateNumber;
                targetCertificate.IsVerified = false;
                _certificateRepository.Update(targetCertificate);
            }
            else
            {
                // Ghi log cảnh báo để kiểm tra trường hợp không tìm thấy certificate
                _logger.LogWarning("Không tìm thấy certificate với số certificate '{CertificateNumber}' cho consultant có Id {ConsultantId}",
                    request.UpdateDto.CertificateNumber, consultant.ConsultantId);
            }

            consultant.ExpertiseId = expertise.ExpertiseId;
            consultant.VerificationStatus = Domain.Enum.VerificationStatus.Pending;
            _consultantRepository.Update(consultant);
            expertise.ExpertiseName = request.UpdateDto.Expertise;

            await _consultantRepository.SaveChangeAsync();
            return true;
        }
    }
}
