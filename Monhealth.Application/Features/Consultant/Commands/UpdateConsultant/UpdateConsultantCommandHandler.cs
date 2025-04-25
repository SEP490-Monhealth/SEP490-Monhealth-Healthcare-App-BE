using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Commands.UpdateConsultant
{
    public class UpdateConsultantCommandHandler : IRequestHandler<UpdateConsultantCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly IMapper _mapper;
        public UpdateConsultantCommandHandler(IConsultantRepository consultantRepository, IExpertiseRepository expertiseRepository, IMapper mapper)
        {
            _consultantRepository = consultantRepository;
            _expertiseRepository = expertiseRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(UpdateConsultantCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
            {
                return false;
            }
            var updateConsultant = _mapper.Map(request.UpdateConsultantDTO, consultant);
            updateConsultant.UpdatedAt = DateTime.Now;
            _consultantRepository.Update(updateConsultant);

            await _consultantRepository.SaveChangeAsync();
            return true;
        }
    }
}
