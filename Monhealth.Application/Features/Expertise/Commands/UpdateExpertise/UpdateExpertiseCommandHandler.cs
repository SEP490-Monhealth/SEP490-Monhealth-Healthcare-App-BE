using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertise
{
    public class UpdateExpertiseCommandHandler : IRequestHandler<UpdateExpertiseCommand, bool>
    {
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly ICertificateRepository _certificateRepository;
        private readonly IMapper _mapper;
        public UpdateExpertiseCommandHandler(IExpertiseRepository expertiseRepository, ICertificateRepository certificateRepository, IMapper mapper)
        {
            _expertiseRepository = expertiseRepository;
            _certificateRepository = certificateRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(UpdateExpertiseCommand request, CancellationToken cancellationToken)
        {
            var checkExpertiseExisted = await _expertiseRepository.GetExpertiseByNameAsync(request.UpdateExpertiseDTO.ExpertiseName);
            if (checkExpertiseExisted != null)
            {
                throw new Exception("Chuyên môn đã tồn tại.");
            }
            var existingExpertise = await _expertiseRepository.GetByIdAsync(request.ExpertiseId);
            if (existingExpertise == null)
            {
                throw new Exception("Chuyên môn không tồn tại.");
            }
            // Update Expertise
            var updateExpertise = _mapper.Map(request.UpdateExpertiseDTO, existingExpertise);
            updateExpertise.UpdatedAt = DateTime.Now;
            _expertiseRepository.Update(updateExpertise);

            // Update Certificate
            // var certificates = await _certificateRepository.GetCertificateByExpertiseId(request.ExpertiseId);
            //foreach (var certificate in certificates)
            //{
            //    certificate.CertificateName = request.UpdateExpertiseDTO.CertificateName;
            //    certificate.IssueDate = request.UpdateExpertiseDTO.IssueDate;
            //    certificate.ExpiryDate = request.UpdateExpertiseDTO.ExpiryDate;
            //    certificate.Images = request.UpdateExpertiseDTO.Images;
            //    certificate.UpdatedAt = DateTime.Now;
            //    _certificateRepository.Update(certificate);
            //}

            await _expertiseRepository.SaveChangeAsync();
            await _certificateRepository.SaveChangeAsync();
            return true;
        }
    }
}
