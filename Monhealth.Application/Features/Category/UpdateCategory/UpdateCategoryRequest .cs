using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Category.UpdateCategory
{
    public class UpdateCategoryRequest : IRequest<bool>
    {
     
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}