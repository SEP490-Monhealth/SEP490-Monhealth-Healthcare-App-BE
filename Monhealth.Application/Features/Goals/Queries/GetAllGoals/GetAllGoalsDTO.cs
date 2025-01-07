using Monhealth.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery
{
    public class GetAllGoalsDTO
    {
        public Guid GoalId { get; set; }
        public Guid UserId { get; set; }
        public string GoalType { get; set; }
        public int WeightGoal { get; set; }
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        public float CarbGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
        public int WaterGoal { get; set; }
        public float ExerciseGoal { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
