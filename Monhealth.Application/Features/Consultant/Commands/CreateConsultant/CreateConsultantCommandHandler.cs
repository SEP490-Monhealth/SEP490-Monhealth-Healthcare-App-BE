using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using System.Text.Json;

namespace Monhealth.Application.Features.Consultant.Commands.CreateConsultant
{
    public class CreateConsultantCommandHandler : IRequestHandler<CreateConsultantCommand, Unit>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly ICertificateRepository _certificateRepository;
        private readonly IMapper _mapper;
        public CreateConsultantCommandHandler(IConsultantRepository consultantRepository,
                                                IExpertiseRepository expertiseRepository,
                                                ICertificateRepository certificateRepository,
                                                IMapper mapper)
        {
            _consultantRepository = consultantRepository;
            _expertiseRepository = expertiseRepository;
            _certificateRepository = certificateRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateConsultantCommand request, CancellationToken cancellationToken)
        {
            // Create Expertise                
            var expertise = await _expertiseRepository.GetExpertiseByNameAsync(request.CreateConsultantDTO.ExpertiseName);
            if (expertise == null)
            {
                expertise = _mapper.Map<Domain.Expertise>(request.CreateConsultantDTO);
                expertise.ExpertiseId = Guid.NewGuid();
                expertise.CreatedAt = DateTime.Now;
                expertise.UpdatedAt = DateTime.Now;
                _expertiseRepository.Add(expertise);

            }
            // Create Consultant
            var consultant = await _consultantRepository.GetConsultantByUserId(request.CreateConsultantDTO.UserId);
            if (consultant != null) { throw new BadRequestException("Người dùng này đã là chuyên viên tư vấn"); }
            var newConsultant = _mapper.Map<Domain.Consultant>(request.CreateConsultantDTO);
            newConsultant.ConsultantId = Guid.NewGuid();
            newConsultant.ExpertiseId = expertise.ExpertiseId;
            newConsultant.Status = false;
            newConsultant.CreatedAt = DateTime.Now;
            newConsultant.UpdatedAt = DateTime.Now;
            _consultantRepository.Add(newConsultant);

            // Create Certificate
            var newCertificate = _mapper.Map<Domain.Certificate>(request.CreateConsultantDTO);
            newCertificate.CertificateId = Guid.NewGuid();
            newCertificate.ExpertiseId = expertise.ExpertiseId;
            newCertificate.ImageUrls = JsonSerializer.Serialize(request.CreateConsultantDTO.Images);
            newCertificate.Status = true;
            newCertificate.CreatedAt = DateTime.Now;
            newCertificate.UpdatedAt = DateTime.Now;
            _certificateRepository.Add(newCertificate);

            await _certificateRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
