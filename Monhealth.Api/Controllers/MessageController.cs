using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Message.Commands.CreateMessage;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/messages")]
    [ApiController]
    public class MessageController(IMediator mediator) : ControllerBase
    {


        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllMessages()
        {
            var messages = await mediator.Send(new GetAllMessageQueries());

            return new ResultModel
            {
                Data = messages,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }


        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateMessage([FromBody] CreateMessageCommand command)
        {
            var chatId = await mediator.Send(command);
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Tạo tin nhắn thành công",
                Status = 201,
            });
        }
    }
}
