using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Expertise.Commands.CreateExpertise
{
    public class CreateExpertiseCommandHandler : IRequestHandler<CreateExpertiseCommand, Unit>
    {
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly IMapper _mapper;
        public CreateExpertiseCommandHandler(IExpertiseRepository expertiseRepository, IMapper mapper)
        {
            _expertiseRepository = expertiseRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateExpertiseCommand request, CancellationToken cancellationToken)
        {
            var checkExpertiseExisted = await _expertiseRepository.GetExpertiseByNameAsync(request.CreateExpertiseDTO.ExpertiseName);
            if (checkExpertiseExisted != null)
            {
                throw new Exception("Chuyên môn đã tồn tại.");
            }
            var newExpertise = _mapper.Map<Domain.Expertise>(request.CreateExpertiseDTO);
            newExpertise.ExpertiseId = Guid.NewGuid();
            newExpertise.CreatedAt = DateTime.Now;
            newExpertise.UpdatedAt = DateTime.Now;
            _expertiseRepository.Add(newExpertise);
            await _expertiseRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
