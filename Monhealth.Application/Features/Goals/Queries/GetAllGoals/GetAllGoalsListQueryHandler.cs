using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery;


namespace Monhealth.Application.Features.Goals.Queries.GetAllGoals
{
    public class GetAllGoalsListQueryHandler : IRequestHandler<GetAllGoalsListQuery, List<GetAllGoalsDTO>>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        public GetAllGoalsListQueryHandler(IGoalRepository goalRepository, IMapper mapper)
        {
            _goalRepository = goalRepository;
            _mapper = mapper;
        }
        public async Task<List<GetAllGoalsDTO>> Handle(GetAllGoalsListQuery request, CancellationToken cancellationToken)
        {
            var goals = await _goalRepository.GetAllAsync();
            var goalsResponse = _mapper.Map<List<GetAllGoalsDTO>>(goals);
            return goalsResponse;
        }
    }
}
