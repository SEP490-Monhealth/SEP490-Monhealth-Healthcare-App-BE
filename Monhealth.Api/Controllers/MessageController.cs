using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Message.Commands.CreateMessage;
using Monhealth.Application.Features.Message.Commands.DeleteMessage;
using Monhealth.Application.Features.Message.Commands.MarkMessageIsRead;
using Monhealth.Application.Features.Message.Commands.UpdateMessageById;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;
using Monhealth.Application.Features.Message.Queries.GetMessageByChatId;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/messages")]
    [ApiController]
    public class MessageController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách tin nhắn")]
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

        [HttpGet("chat/{chatId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách tin nhắn theo ID cuộc trò chuyện")]
        public async Task<ActionResult<ResultModel>> GetMessageByChatId(Guid chatId)
        {
            var messages = await mediator.Send(new GetMessageByChatIdQuery { ChatId = chatId });

            return new ResultModel
            {
                Data = messages,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Gửi tin nhắn")]
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

        [HttpPut("{messageId}")]
        [SwaggerOperation(Summary = "Cập nhật tin nhắn")]
        public async Task<ActionResult<ResultModel>> UpdateMessage([FromRoute] Guid messageId, [FromBody] UpdateMessageDto updateMessageDto)
        {
            var command = new UpdateMessageCommand(messageId, updateMessageDto);
            var result = await mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật tin nhắn thành công"
            };
        }

        [HttpDelete("{messageId}")]
        [SwaggerOperation(Summary = "Xóa tin nhắn")]
        public async Task<ActionResult<ResultModel>> DeleteMessage([FromRoute] Guid messageId)
        {

            var result = await mediator.Send(new DeleteMessageCommand { MessageId = messageId });
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Xóa thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa tin nhắn thành công"
            };
        }

        [HttpPatch("{messageId}/read")]
        [SwaggerOperation(Summary = "Đánh dấu tin nhắn đã đọc")]
        public async Task<ActionResult<ResultModel>> MarkMessageIsRead([FromRoute] Guid messageId)
        {
            var changeStatus = await mediator.Send(new MarkMessageCommand { MessageId = messageId });
            if (!changeStatus)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Thay đổi tin nhắn đã đọc thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Thay đổi tin nhắn đã đọc thành công"
            };
        }
    }
}
