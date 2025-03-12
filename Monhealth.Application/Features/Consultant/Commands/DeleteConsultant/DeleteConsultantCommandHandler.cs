using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Commands.DeleteConsultant
{
    public class DeleteConsultantCommandHandler : IRequestHandler<DeleteConsultantCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        public DeleteConsultantCommandHandler(IConsultantRepository consultantRepository)
        {
            _consultantRepository = consultantRepository;
        }
        public async Task<bool> Handle(DeleteConsultantCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
            {
                return false;
            }
            _consultantRepository.Remove(consultant);
            await _consultantRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
