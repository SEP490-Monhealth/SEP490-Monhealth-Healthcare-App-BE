using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Goals.Commands.UpdateCommand
{
    public class UpdateGoalDTO
    {
        public GoalType GoalType { get; set; }
        public int WeightGoal { get; set; }
    }
}
