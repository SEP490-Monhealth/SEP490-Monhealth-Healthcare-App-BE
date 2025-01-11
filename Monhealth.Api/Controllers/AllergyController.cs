using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Allergy.Commands.CreateAllergy;
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
        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddAllergy([FromBody] CreateAllergyRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo dị ứng thành công. ",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo dị ứng thất bại.",
                Status = 400,
            });
        }
    }
}