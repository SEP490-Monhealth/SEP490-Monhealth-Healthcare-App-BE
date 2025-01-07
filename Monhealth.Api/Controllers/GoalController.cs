﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Food.ChangeStatus;
using Monhealth.Application.Features.Goals.Commands.ChangeStatusCommand;
using Monhealth.Application.Features.Goals.Commands.CreateCommand;
using Monhealth.Application.Features.Goals.Commands.DeleteCommand;
using Monhealth.Application.Features.Goals.Commands.UpdateCommand;
using Monhealth.Application.Features.Goals.Queries.GetAllGoals;
using Monhealth.Application.Features.Goals.Queries.GetGoalById;
using Monhealth.Application.Features.Goals.Queries.GetGoalByUserId;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/goals")]
    [ApiController]
    public class GoalController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GoalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll()
        {
            var goals = await _mediator.Send(new GetAllGoalsListQuery());

            return new ResultModel
            {
                Data = goals,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }

        [HttpGet("{goalId:guid}")]
        public async Task<ActionResult<ResultModel>> GetById(Guid goalId)
        {
            var goal = await _mediator.Send(new GetGoalByIdQuery() { GoalId = goalId });
            if (goal == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Mục tiêu không tồn tại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = goal
            };
        }

        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetByUserId(Guid userId)
        {
            var queries = await _mediator.Send(new GetGoalByUserIdQuery() { UserId = userId });
            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Mục tiêu không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> Create([FromBody] CreateGoalDTO createGoalDTO)
        {
            var command = new CreateGoalCommand(createGoalDTO);
            var createMetric = await _mediator.Send(command);
            if (createMetric == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo mục tiêu thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo mục tiêu thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{goalId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid goalId, [FromBody] UpdateGoalDTO updateGoalDTO)
        {
            var command = new UpdateGoalCommand(goalId, updateGoalDTO);
            var result = await _mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật mục tiêu thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật mục tiêu thành công"
            };
        }

        [HttpDelete("{goalId}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid goalId)
        {
            var command = new DeleteGoalCommand { GoalId = goalId };
            var delete = await _mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy mục tiêu"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa số liệu thành công"
            };
        }

        [HttpPatch("{goalId}/status")]
        public async Task<ActionResult<ResultModel>> ChangeStatus(Guid goalId, [FromBody] ChangeStatusGoalDTO statusGoalDTO)
        {
            var command = new ChangeStatusGoalCommand(goalId, statusGoalDTO);
            var changeStatus = await _mediator.Send(command);
            if (!changeStatus)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy mục tiêu"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Thay đổi trạng thái thành công"
            };
        }
    }
}
