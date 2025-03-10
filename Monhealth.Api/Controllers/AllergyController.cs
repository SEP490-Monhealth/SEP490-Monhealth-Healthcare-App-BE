using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Allergy.Queries.GetAll;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/allergies")]
    [ApiController]
    public class AllergyController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AllergyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllAllergies()
        {
            var categories = await _mediator.Send(new GetAllergyQuery());

            return new ResultModel
            {
                Data = categories,
                Status = 200,
                Success = true
            };
        }

        // [HttpGet]
        // [Route("{allergyId:Guid}")]
        // public async Task<ActionResult<ResultModel>> GetAllergyIdDetail(Guid allergyId)
        // {
        //     var categories = await _mediator.
        //     Send(new GetAllergyDetailQuery { AllergyId = allergyId });

        //     if (categories == null)
        //     {
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Triệu chứng không tồn tại",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Status = 200,
        //         Data = categories
        //     });
        // }

        // [HttpGet]
        // [Route("user/{userId:Guid}")]
        // public async Task<ActionResult<ResultModel>> GetAllergyByUser(Guid userId)
        // {
        //     var categories = await _mediator.
        //     Send(new GetAllergyByUserQuery { UserId = userId });

        //     if (categories == null)
        //     {
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Triệu chứng không tồn tại",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Status = 200,
        //         Data = categories
        //     });
        // }

        // [HttpPost]
        // public async Task<ActionResult<ResultModel>> AddAllergy([FromBody] CreateAllergyRequest request)
        // {
        //     var result = await _mediator.Send(request);
        //     if (result != null)
        //     {
        //         return Ok(new ResultModel
        //         {
        //             Success = true,
        //             Message = "Tạo dị ứng thành công. ",
        //             Status = 201,
        //         });
        //     }

        //     return BadRequest(new ResultModel
        //     {
        //         Success = false,
        //         Message = "Tạo dị ứng thất bại",
        //         Status = 400,
        //     });
        // }

        // [HttpPut]
        // [Route("{allergyId:Guid}")]
        // public async Task<ActionResult<ResultModel>> UpdateAllergy(Guid allergyId, [FromBody] UpdateAllergyRequest request)
        // {
        //     var command = new UpdateAllergyRequestHandler(allergyId, request);
        //     var result = await _mediator.Send(command);
        //     if (!result)
        //         return new ResultModel
        //         {
        //             Message = "Cập nhật triệu chứng thất bại",
        //             Success = false,
        //             Data = null
        //         };
        //     return Ok(new ResultModel
        //     {
        //         Message = "Cập nhật triệu ch thành công",
        //         Success = true,
        //         Status = 204,
        //     });
        // }

        // [HttpDelete]
        // [Route("{allergyId:Guid}")]
        // public async Task<ActionResult<ResultModel>> RemoveAllergy(Guid allergyId)
        // {
        //     var result = await _mediator.Send(new DeleteAllergyRequest(allergyId));

        //     if (!result)
        //     {
        //         // Trả về lỗi nếu xóa không thành công
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Triệu chứng không tồn tại",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }

        //     // Trả về kết quả thành công
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Message = "Xóa triệu chứng thành công",
        //         Status = 204,
        //         Data = null
        //     });
        // }
    }
}