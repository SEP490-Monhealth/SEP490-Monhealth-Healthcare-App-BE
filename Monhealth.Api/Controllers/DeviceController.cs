using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.UserDevice.Commands.CreateUserDevice;
using Monhealth.Application.Features.UserDevice.Commands.DeleteUserDevice;
using Monhealth.Application.Features.UserDevice.Commands.UpdateUserDevice;
using Monhealth.Application.Features.UserDevice.Queries.GetAllUserDevices;
using Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceById;
using Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceByUserId;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/devices")]
    [ApiController]
    public class DeviceController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách thiết bị")]
        public async Task<ActionResult<ResultModel>> GetAllUserDevices(int page = 1, int limit = 10)
        {
            var userDeviceList = await mediator.Send(new GetAllDevicesQuery(page, limit));

            return new ResultModel
            {
                Data = userDeviceList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{deviceId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin thiết bị")]
        public async Task<ActionResult<ResultModel>> GetUserDeviceById(Guid deviceId)
        {
            var userDevice = await mediator.Send(new GetDeviceByIdQuery { DeviceId = deviceId });
            if (userDevice == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Không tìm thấy thiết bị",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = userDevice
            });
        }

        [HttpGet("user/{userId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách thiết bị người dùng")]
        public async Task<ActionResult<ResultModel>> GetUserDeviceByUserId(Guid userId)
        {
            var consultantBank = await mediator.Send(new GetDeviceByUserIdQuery { UserId = userId });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = consultantBank
            });
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo thiết bị người dùng")]
        public async Task<ActionResult<ResultModel>> CreateUserDevice([FromBody] CreateDeviceDTO createUserDeviceDTO)
        {
            var command = new CreateDeviceCommand(createUserDeviceDTO);
            var create = await mediator.Send(command);
            if (create == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo thiết bị thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo thiết bị thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{deviceId}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin thiết bị")]
        public async Task<ActionResult<ResultModel>> UpdateUserDevice(Guid deviceId, [FromBody] UpdateDeviceDTO updateUserDeviceDTO)
        {
            var command = new UpdateDeviceCommand(deviceId, updateUserDeviceDTO);
            var result = await mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật thông tin thiết bị thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật thông tin thiết bị thành công"
            };
        }

        [HttpDelete("{deviceId}")]
        [SwaggerOperation(Summary = "Xóa thiết bị")]
        public async Task<ActionResult<ResultModel>> DeleteUserDevice(Guid deviceId)
        {
            var command = new DeleteDeviceCommand { DeviceId = deviceId };
            var delete = await mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Xóa thiết bị thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa thiết bị thành công"
            };
        }
    }
}
