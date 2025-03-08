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

        [HttpPost]
        public async Task<ActionResult<ResultModel>> Add([FromBody] CreateUserAllergyRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo Dị ứng người dùng thành công",
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
        [HttpGet("{userId:guid}/FoodAllergies")]
        public async Task<ActionResult<ResultModel>> GetByFoodByUserId(Guid userId)
        {
            try
            {
                var goal = await _mediator.Send(new FilterFoodListQuery { UserId = userId });

                if (goal == null )
                {
                    _logger.LogWarning($"Không tìm thấy dữ liệu thức ăn cho người dùng có ID {userId}");
                    return new ResultModel
                    {
                        Success = false,
                        Status = (int)HttpStatusCode.NotFound,
                        Message = "Không tìm thấy dữ liệu thức ăn cho người dùng."
                    };
                }

                return new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = goal
                };
            }
            catch (Exception ex)
            {
                // Log lỗi chi tiết và trả về lỗi server
                _logger.LogError(ex, "Đã xảy ra lỗi khi xử lý yêu cầu GetByFoodByUserId");
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = "Đã xảy ra lỗi khi xử lý yêu cầu."
                };
            }
        }


    }
}