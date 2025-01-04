using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Commands.CreateCommand
{
    public class CreateGoalCommandHandler : IRequestHandler<CreateGoalCommand, Unit>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        public CreateGoalCommandHandler(IGoalRepository goalRepository, IMapper mapper)
        {
            _goalRepository = goalRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateGoalCommand request, CancellationToken cancellationToken)
        {
            var newGoal = _mapper.Map<Monhealth.Domain.Goal>(request.CreateGoalDTO);
            newGoal.GoalId = Guid.NewGuid();
            newGoal.CreatedAt = DateTime.Now;
            newGoal.UpdatedAt = DateTime.Now;
            _goalRepository.Add(newGoal);
            await _goalRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
