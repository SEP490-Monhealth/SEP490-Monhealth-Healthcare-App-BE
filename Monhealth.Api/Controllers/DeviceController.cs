using MediatR;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Models;
using Monhealth.Application.Features.UserDevice.Queries.GetAllUserDevices;
using Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceById;
using Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceByUserId;
using Monhealth.Application.Features.UserDevice.Commands.CreateUserDevice;
using Monhealth.Application.Features.UserDevice.Commands.UpdateUserDevice;
using Monhealth.Application.Features.UserDevice.Commands.DeleteUserDevice;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/devices")]
    [ApiController]
    public class DeviceController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
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
        public async Task<ActionResult<ResultModel>> GetUserDeviceById(Guid deviceId)
        {
            var userDevice = await mediator.Send(new GetDeviceByIdQuery { DeviceId = deviceId });
            if (userDevice == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Thiết bị người dùng không tồn tại",
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
                    Message = "Cập nhật thiết bị người dùng thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật thiết bị người dùng thành công"
            };
        }

        [HttpDelete("{deviceId}")]
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
                    Message = "Xóa thiết bị người dùng thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa thiết bị người dùng thành công"
            };
        }
    }
}
