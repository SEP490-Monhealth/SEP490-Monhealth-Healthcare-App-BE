using System.Net;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Activity.Commands.CreateActivity;
using Monhealth.Application.Features.Expertise.Commands.CreateExpertise;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/activities")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ActivityController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateActivity([FromBody] CreateActivityDTO createActivityDTO)
        {
            var command = new CreateActivityCommand(createActivityDTO);
            var createActivity = await _mediator.Send(command);
            if (createActivity == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo hoạt động thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo hoạt động thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }
    }
}
