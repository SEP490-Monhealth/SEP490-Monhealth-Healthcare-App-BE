using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Metric.Queries.GetMetricDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Queries.GetGoalById
{
    public class GetGoalByIdQueryHandler : IRequestHandler<GetGoalByIdQuery, GetGoalByIdDTO>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        public GetGoalByIdQueryHandler(IGoalRepository goalRepository, IMapper mapper)
        {
            _goalRepository = goalRepository;
            _mapper = mapper;
        }
        public async Task<GetGoalByIdDTO> Handle(GetGoalByIdQuery request, CancellationToken cancellationToken)
        {
            var goal = await _goalRepository.GetByIdAsync(request.GoalId);
            if (goal == null) { throw new Exception("Not found goal"); }
            return _mapper.Map<GetGoalByIdDTO>(goal);
        }
    }
}
