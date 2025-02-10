using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery;


namespace Monhealth.Application.Features.Goals.Queries.GetAllGoals
{
    public class GetAllGoalsListQueryHandler : IRequestHandler<GetAllGoalsListQuery, List<GetAllGoalsDTO>>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetAllGoalsListQueryHandler> _logger;
        public GetAllGoalsListQueryHandler(IGoalRepository goalRepository, IMapper mapper, ILogger<GetAllGoalsListQueryHandler> logger)
        {
            _goalRepository = goalRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<List<GetAllGoalsDTO>> Handle(GetAllGoalsListQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("GetAllGoalsListQueryHandler was called at {Time}", DateTime.UtcNow);
            var goals = await _goalRepository.GetAllAsync();
            var goalsResponse = _mapper.Map<List<GetAllGoalsDTO>>(goals);
            return goalsResponse;
        }
    }
}
