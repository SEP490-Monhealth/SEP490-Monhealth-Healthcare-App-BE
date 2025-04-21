using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/user-categories")]
    [ApiController]
    public class UserCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> Addy([FromBody] CreateUserCategoryRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo danh mục ưa thích thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo danh mục ưa thích thất bại",
                Status = 400,
            });
        }
    }
}