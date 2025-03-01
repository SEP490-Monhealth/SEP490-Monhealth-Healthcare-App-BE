using MediatR;

namespace Monhealth.Application.Features
{
    public class CreateUserCategoryRequest : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public List<string> Category { get; set; } 
         
    }
}