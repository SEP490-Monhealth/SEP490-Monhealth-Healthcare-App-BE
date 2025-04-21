using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Allergy.Commands.CreateAllergy;
using Monhealth.Application.Features.Allergy.Commands.DeleteAllergy;
using Monhealth.Application.Features.Allergy.Commands.UpdateAllergy;
using Monhealth.Application.Features.Allergy.Queries.GetAll;
using Monhealth.Application.Features.Allergy.Queries.GetDetail;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
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
        [SwaggerOperation(Summary = "Lấy danh sách dị ứng")]
        public async Task<ActionResult<ResultModel>> GetAllAllergies(int page = 1, int limit = 10, string? search = null)
        {
            var categories = await _mediator.Send(new GetAllergyQuery { Page = page, Limit = limit, Search = search });

            return new ResultModel
            {
                Data = categories,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("user/{userId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách dị ứng theo người dùng")]
        public async Task<ActionResult<ResultModel>> GetAllergyByUser(Guid userId)
        {
            var allergies = await _mediator.Send(new GetUserAllergyQuery { UserId = userId });

            if (allergies == null)
            {
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

        [HttpGet]
        [Route("{allergyId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin dị ứng theo ID")]
        public async Task<ActionResult<ResultModel>> GetAllergyIdDetail(Guid allergyId)
        {
            var categories = await _mediator.
            Send(new GetAllergyDetailQuery { AllergyId = allergyId });

            if (categories == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Dị ứng không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = categories
            });
        }

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
        //             Message = "Dị ứng không tồn tại",
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

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo dị ứng")]
        public async Task<ActionResult<ResultModel>> AddAllergy([FromBody] CreateAllergyRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo dị ứng thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo dị ứng thất bại",
                Status = 400,
            });
        }

        [HttpPost]
        [Route("user")]
        [SwaggerOperation(Summary = "Tạo dị ứng người dùng")]
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

        [HttpPut]
        [Route("{allergyId:Guid}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin dị ứng")]
        public async Task<ActionResult<ResultModel>> UpdateAllergy(Guid allergyId, [FromBody] UpdateAllergyRequest request)
        {
            var command = new UpdateAllergyRequestHandler(allergyId, request);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật dị ứng thất bại",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật dị ứng thành công",
                Success = true,
                Status = 204,
            });
        }

        [HttpPut("user/{userId:guid}")]
        [SwaggerOperation(Summary = "Cập nhật dị ứng người dùng")]
        public async Task<ActionResult<ResultModel>> Update([FromRoute] Guid userId, [FromBody] UserAllergyDTO dto)
        {
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

        [HttpDelete]
        [Route("{allergyId:Guid}")]
        [SwaggerOperation(Summary = "Xóa dị ứng")]
        public async Task<ActionResult<ResultModel>> RemoveAllergy(Guid allergyId)
        {
            var result = await _mediator.Send(new DeleteAllergyRequest(allergyId));

            if (!result)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Dị ứng không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }

            // Trả về kết quả thành công
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa dị ứng thành công",
                Status = 204,
                Data = null
            });
        }
    }
}