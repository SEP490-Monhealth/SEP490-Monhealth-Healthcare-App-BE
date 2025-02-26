using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Expertise.Queries.GetExpertiseById
{
    public class GetExpertiseByIdDTO
    {
        [JsonPropertyName("name")]
        public string ExpertiseName { get; set; } = string.Empty;
    }
}
