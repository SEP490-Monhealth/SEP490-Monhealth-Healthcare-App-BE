using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Review.Commands.Create;
using Monhealth.Application.Features.Review.Commands.Update;
using Monhealth.Application.Features.Review.Queries;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/reviews")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReviewController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllReviews()
        {
            var queries = await _mediator.Send(new GetReviewListQuery());

            return new ResultModel
            {
                Data = queries,
                Status = 200,
                Success = true
            };
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddReview([FromBody] AddReviewRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo dinh dưỡng thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo dinh dưỡng thất bại"
            });
        }
        [HttpPut]
        [Route("{reviewId:Guid}")]
        public async Task<ActionResult<ResultModel>> UpdateReview(Guid reviewId, [FromBody] UpdateReviewRequest request)
        {
            var command = new UpdateReviewCommand(reviewId, request);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật đánh giá không thành công",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật đánh giá thành công",
                Success = true,
                Status = 204,
            });
        }

    }
}