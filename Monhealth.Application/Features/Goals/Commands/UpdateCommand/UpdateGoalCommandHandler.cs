using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Commands.UpdateCommand
{
    public class UpdateGoalCommandHandler : IRequestHandler<UpdateGoalCommand, bool>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        public UpdateGoalCommandHandler(IGoalRepository goalRepository, IMapper mapper)
        {
            _goalRepository = goalRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(UpdateGoalCommand request, CancellationToken cancellationToken)
        {
            var goal = await _goalRepository.GetByIdAsync(request.GoalId);
            if (goal == null)
            {
                throw new Exception("Không tìm thấy mục tiêu.");
            }
            goal.UpdatedAt = DateTime.Now;
            _mapper.Map(request.UpdateGoalDTO, goal);
            _goalRepository.Update(goal);
            await _goalRepository.SaveChangeAsync();
            return true;


        }
    }
}
