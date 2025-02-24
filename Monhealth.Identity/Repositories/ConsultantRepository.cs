﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;

namespace Monhealth.Identity.Repositories
{
    public class ConsultantRepository : GenericRepository<Consultant, Guid>, IConsultantRepository
    {
        public ConsultantRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Consultant>> GetAllConsultants(int page, int limit, bool? status)
        {
            IQueryable<Consultant> query = _context.Consultants
                .Select(c => new Consultant
                {
                    ConsultantId = c.ConsultantId,
                    UserId = c.UserId,
                    Status = c.Status,
                    Bio = c.Bio,
                    Experience = c.Experience,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    AppUser = new AppUser {
                        FullName = c.AppUser.FullName,
                        Avatar = c.AppUser.Avatar,
                    },
                    Expertise = new Expertise
                    {
                        ExpertiseName = c.Expertise.ExpertiseName,
                    }
                })
                .AsQueryable();
            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Consultant>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
