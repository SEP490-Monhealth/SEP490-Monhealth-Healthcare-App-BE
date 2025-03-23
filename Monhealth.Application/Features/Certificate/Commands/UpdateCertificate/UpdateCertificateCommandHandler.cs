using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

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
            var isNameExist = await _certificateRepository
            .AnyAsync(c => c.CertificateName == request.UpdateCertificateDTO.CertificateName);
            if (isNameExist) throw new BadRequestException("Tên chứng chỉ đã tồn tại");

            var checkExpertiseExisted = await _expertiseRepository.GetExpertiseByNameAsync(request.UpdateCertificateDTO.ExpertiseName);

            var certificate = await _certificateRepository.GetByIdAsync(request.CertificateId);
            if (certificate == null)
            {
                return false;
            }
            var updateCertificate = _mapper.Map(request.UpdateCertificateDTO, certificate);
            updateCertificate.ExpertiseId = checkExpertiseExisted.ExpertiseId;
            updateCertificate.IsVerified = false;
            updateCertificate.UpdatedAt = DateTime.Now;
            _certificateRepository.Update(updateCertificate);
            await _certificateRepository.SaveChangeAsync();
            return true;
        }
    }
}
