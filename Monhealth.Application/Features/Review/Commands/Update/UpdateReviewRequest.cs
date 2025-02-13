using MediatR;

namespace Monhealth.Application.Features.Review.Commands.Update
{
    public class UpdateReviewRequest : IRequest<bool>
    {
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}