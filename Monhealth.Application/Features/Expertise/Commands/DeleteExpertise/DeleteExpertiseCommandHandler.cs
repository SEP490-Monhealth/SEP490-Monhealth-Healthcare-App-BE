using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Expertise.Commands.DeleteExpertise
{
    public class DeleteExpertiseCommandHandler : IRequestHandler<DeleteExpertiseCommand, bool>
    {
        private readonly IExpertiseRepository _expertiseRepository;
        public DeleteExpertiseCommandHandler(IExpertiseRepository expertiseRepository, IMapper mapper)
        {
            _expertiseRepository = expertiseRepository;
        }
        public async Task<bool> Handle(DeleteExpertiseCommand request, CancellationToken cancellationToken)
        {
            var expertise = await _expertiseRepository.GetByIdAsync(request.ExpertiseId);
            if (expertise == null)
            {
                return false;
            }
            _expertiseRepository.Remove(expertise);
            await _expertiseRepository.SaveChangeAsync();
            return true;
        }
    }
}
