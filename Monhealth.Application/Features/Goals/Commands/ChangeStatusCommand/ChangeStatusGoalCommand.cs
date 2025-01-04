﻿using MediatR;
using Monhealth.Application.Features.Food.ChangeStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Goals.Commands.ChangeStatusCommand
{
    public class ChangeStatusGoalCommand : IRequest<bool>
    {
        public Guid GoalId { get; set; }
        public ChangeStatusGoalDTO ChangeStatusGoalDTO { get; set; }
        public ChangeStatusGoalCommand(Guid goalId, ChangeStatusGoalDTO changeStatusGoalDTO)
        {
            GoalId = goalId;
            ChangeStatusGoalDTO = changeStatusGoalDTO;
        }
    }
}
