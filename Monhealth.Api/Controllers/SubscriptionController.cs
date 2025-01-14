using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Subscription.Commands.Create;
using Monhealth.Application.Features.Subscription.Queries.GetAll;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/subscriptions")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SubscriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> Add([FromBody] CreateSubscriptionCommand request)
        {

            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo gói thành viên thành công. ",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo gói thành viên thất bại. ",
                Status = 400,
            });

        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll()
        {
            var metrics = await _mediator.Send(new GetAllSubscriptionQuery());

            return new ResultModel
            {
                Data = metrics,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }

    }
}