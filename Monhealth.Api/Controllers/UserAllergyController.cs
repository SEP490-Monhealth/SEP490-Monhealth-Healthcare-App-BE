using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/user-allergies")]
    [ApiController]
    public class UserAllergyController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<UserAllergyController> _logger;
        public UserAllergyController(IMediator mediator,
        ILogger<UserAllergyController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [Route("{userId:guid}/user")]
        public async Task<ActionResult<ResultModel>> GetAllergyByUser(Guid userId)
        {
            var allergies = await _mediator.Send(new GetUserAllergyQuery { UserId = userId });

            if (allergies == null)
            {
                _logger.LogWarning($"Không tìm thấy dữ liệu thức ăn cho người dùng có ID {userId}");
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy dữ liệu dị ứng ăn cho người dùng."
                };
            }

            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = allergies
            };


        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> Add([FromBody] CreateUserAllergyRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo dị ứng người dùng thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo dị ứng người dùng thất bại",
                Status = 400,
            });
        }
        [HttpPut("{userId:guid}")]
        public async Task<ActionResult<ResultModel>> Update([FromRoute] Guid userId, [FromBody] UserAllergyDTO dto)
        {
            // Tạo UpdateUserAllergyRequest từ thông tin UserAllergyDTO nhận được ở body.
            // Sau đó gán UserId từ route vào request.
            var updateRequest = new UpdateUserAllergyRequest(dto)
            {
                UserId = userId
            };

            var result = await _mediator.Send(updateRequest);

            if (result)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Cập nhật dị ứng người dùng thành công",
                    Status = 200
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Cập nhật dị ứng người dùng thất bại",
                Status = 400
            });
        }


    }
}