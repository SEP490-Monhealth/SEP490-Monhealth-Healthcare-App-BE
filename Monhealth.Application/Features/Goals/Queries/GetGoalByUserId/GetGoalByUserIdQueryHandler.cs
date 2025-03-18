using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Goals.Queries.GetGoalByUserId
{
    public class GetGoalByUserIdQueryHandler : IRequestHandler<GetGoalByUserIdQuery, List<GetGoalByUserIdDTO>>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        public GetGoalByUserIdQueryHandler(IGoalRepository goalRepository, IMapper mapper)
        {
            _goalRepository = goalRepository;
            _mapper = mapper;
        }

        public async Task<List<GetGoalByUserIdDTO>> Handle(GetGoalByUserIdQuery request, CancellationToken cancellationToken)
        {
            var listGoals = await _goalRepository.GetGoalsByUserIdAsync(request.UserId);
            return _mapper.Map<List<GetGoalByUserIdDTO>>(listGoals);
        }
    }
}
