using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Commands.ChangeStatusConsultant
{
    public class ChangeStatusConsultantCommandHandler : IRequestHandler<ChangeStatusConsultantCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        public ChangeStatusConsultantCommandHandler(IConsultantRepository consultantRepository)
        {
            _consultantRepository = consultantRepository;
        }
        public async Task<bool> Handle(ChangeStatusConsultantCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
            {
                return false;
            }
            if(consultant.Status == false)
            {
                consultant.Status = true;
            } else
            {
                consultant.Status = false;
            }
            _consultantRepository.Update(consultant);
            await _consultantRepository.SaveChangeAsync();
            return true;
        }
    }
}
