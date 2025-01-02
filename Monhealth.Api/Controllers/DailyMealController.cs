using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.DailyMeal.Queries.GetAllDailyMeal;
using Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealByCreateAt;
using Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/daily-meals")]
    [ApiController]
    public class DailyMealController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DailyMealController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllDailyMeals()
        {
            var dailyMeals = await _mediator.Send(new GetDailyMealQuery());

            return new ResultModel
            {
                Data = dailyMeals,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("{date:DateTime}")]
        public async Task<ActionResult<ResultModel>> GetDailyMealDetail(DateTime date)
        {
            var categories = await _mediator.
            Send(new GetDailyMealByCreateAtQuery() { CreateAt = date });

            if (categories == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Ngày tạo không tồn tại.",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = categories
            });
        }
        [HttpGet]
        [Route("user{userId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetDailyMealByUser(Guid userId)
        {
            var categories = await _mediator.
            Send(new GetDailyMealByUserQuery { UseId = userId });

            if (categories == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Bữa ăn hằng ngày không tồn tại.",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = categories
            });
        }

    }
}