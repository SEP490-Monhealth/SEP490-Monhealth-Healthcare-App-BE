using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Category.Queries.GetAllCategories
{
    public class CategoryDto
    {
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}