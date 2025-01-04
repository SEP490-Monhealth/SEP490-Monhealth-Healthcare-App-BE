using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Portions.Queries.GetPortionsByFoodId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var listGoals = await _goalRepository.GetGoalsByYserIdAsync(request.UserId);
            return _mapper.Map<List<GetGoalByUserIdDTO>>(listGoals);

        }
    }
}
