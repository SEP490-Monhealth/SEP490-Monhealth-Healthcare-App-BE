using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Category.Queries.GetCategoryDetail
{
    public class CategoryDetailDto
    {
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
    }
}