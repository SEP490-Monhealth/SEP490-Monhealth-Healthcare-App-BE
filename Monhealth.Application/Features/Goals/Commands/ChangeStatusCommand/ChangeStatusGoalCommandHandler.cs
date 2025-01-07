using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Commands.ChangeStatusCommand
{
    public class ChangeStatusGoalCommandHandler : IRequestHandler<ChangeStatusGoalCommand, bool>
    {
        private readonly IGoalRepository _goalRepository;
        public ChangeStatusGoalCommandHandler(IGoalRepository goalRepository)
        {
            _goalRepository = goalRepository;
        }
        public async Task<bool> Handle(ChangeStatusGoalCommand request, CancellationToken cancellationToken)
        {
            var goal = await _goalRepository.GetByIdAsync(request.GoalId);
            if(goal == null)
            {
                return false;
            }
            if(!Enum.TryParse<GoalStatus>(request.ChangeStatusGoalDTO.Status, out var status))
            {
                throw new Exception("Trạng thái không hợp lệ");
            }
            goal.Status = status;
            _goalRepository.Update(goal);
            await _goalRepository.SaveChangeAsync();
            return true;
        }
    }
}
