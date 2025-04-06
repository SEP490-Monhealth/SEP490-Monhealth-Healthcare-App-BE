using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Review.Commands.Create;
using Monhealth.Application.Features.Review.Commands.Delete;
using Monhealth.Application.Features.Review.Commands.Update;
using Monhealth.Application.Features.Review.Queries;
using Monhealth.Application.Features.Review.Queries.GetById;
using Monhealth.Application.Features.Review.Queries.GetReviewByBookingId;
using Monhealth.Application.Features.Review.Queries.GetReviewByConsultant;
using Monhealth.Application.Features.Review.Queries.GetReviewByUser;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

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
        [SwaggerOperation(Summary = "Lấy danh sách đánh giá")]
        public async Task<ActionResult<ResultModel>> GetAllReviews(int page = 1, int limit = 10, int? rating = null)
        {
            if (rating.HasValue && (rating < 1 || rating > 5))
            {
                throw new ArgumentException("Rating must be between 1 and 5", nameof(rating));
            }

            // Nếu không có rating thì gán giá trị mặc định cho rating
            var queries = await _mediator.Send(new GetReviewListQuery(page, limit, rating ?? 0));


            return new ResultModel
            {
                Data = queries,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("user/{userId:Guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách đánh giá theo ID người dùng")]
        public async Task<ActionResult<ResultModel>> GetReviewByUser(Guid userId)
        {
            var queries = await _mediator.
            Send(new GetReviewByUserQuery { userId = userId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Đánh giá không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpGet]
        [Route("consultant/{consultantId:Guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách đánh giá theo ID chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetReviewByConsultant(Guid consultantId)
        {
            var queries = await _mediator.
            Send(new GetReviewByConsultantQuery { ConsultantId = consultantId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Đánh giá không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpGet]
        [Route("booking/{bookingId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin đánh giá theo ID đặt lịch")]
        public async Task<ActionResult<ResultModel>> GetReviewByBookingId(Guid bookingId)
        {
            var queries = await _mediator.
            Send(new GetReviewByBookingIdQueries { BookingId = bookingId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Đánh giá không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpGet]
        [Route("{reviewId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin đánh giá theo ID")]
        public async Task<ActionResult<ResultModel>> GetReviewDetail(Guid reviewId)
        {
            var queries = await _mediator.
            Send(new GetReviewDetailQuery { ReviewId = reviewId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Đánh giá không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo đánh giá")]
        public async Task<ActionResult<ResultModel>> AddReview([FromBody] AddReviewRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo đánh giá thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo đánh giá thất bại"
            });
        }

        [HttpPut]
        [Route("{reviewId:Guid}")]
        [SwaggerOperation(Summary = "Cập nhật đánh giá")]
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

        [HttpDelete]
        [Route("{reviewId:Guid}")]
        [SwaggerOperation(Summary = "Xóa đánh giá")]
        public async Task<ActionResult<ResultModel>> RemoveReview(Guid reviewId)
        {
            var result = await _mediator.Send(new DeleteReviewRequest(reviewId));

            if (!result)
            {
                // Trả về lỗi nếu xóa không thành công
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Xóa đánh giá không thành công",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }

            // Trả về kết quả thành công
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa đánh giá thành công",
                Status = 204,
                Data = null
            });
        }
    }
}