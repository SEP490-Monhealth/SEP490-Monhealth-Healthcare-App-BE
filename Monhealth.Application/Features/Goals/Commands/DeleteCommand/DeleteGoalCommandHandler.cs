using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Goals.Commands.DeleteCommand
{
    public class DeleteGoalCommandHandler : IRequestHandler<DeleteGoalCommand, bool>
    {
        private readonly IGoalRepository _goalRepository;

        public DeleteGoalCommandHandler(IGoalRepository goalRepository)
        {
            _goalRepository = goalRepository;
        }
        public async Task<bool> Handle(DeleteGoalCommand request, CancellationToken cancellationToken)
        {
            var goal = await _goalRepository.GetByIdAsync(request.GoalId);
            if (goal == null)
            {
                return false;
            }
            _goalRepository.Remove(goal);
            await _goalRepository.SaveChangeAsync();
            return true;
        }
    }
}
