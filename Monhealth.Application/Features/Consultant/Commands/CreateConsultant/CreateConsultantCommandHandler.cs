using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

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
            var newExpertise = _mapper.Map<Domain.Expertise>(request.CreateConsultantDTO);
            newExpertise.ExpertiseId = Guid.NewGuid();
            newExpertise.CreatedAt = DateTime.Now;
            newExpertise.UpdatedAt = DateTime.Now;
            _expertiseRepository.Add(newExpertise);


            // Create Consultant
            var newConsultant = _mapper.Map<Domain.Consultant>(request.CreateConsultantDTO);
            newConsultant.ConsultantId = Guid.NewGuid();
            newConsultant.ExpertiseId = newExpertise.ExpertiseId;
            newConsultant.Status = false;
            newConsultant.CreatedAt = DateTime.Now;
            newConsultant.UpdatedAt = DateTime.Now;
            _consultantRepository.Add(newConsultant);

            // Create Certificate
            var newCertificate = _mapper.Map<Domain.Certificate>(request.CreateConsultantDTO);
            newCertificate.CertificateId = Guid.NewGuid();
            newCertificate.ExpertiseId = newExpertise.ExpertiseId;
            newCertificate.Status = true;
            newCertificate.CreatedAt = DateTime.Now;
            newCertificate.UpdatedAt = DateTime.Now;
            _certificateRepository.Add(newCertificate);

            // Savechange
            await _expertiseRepository.SaveChangeAsync();
            await _consultantRepository.SaveChangeAsync();
            await _certificateRepository.SaveChangeAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
