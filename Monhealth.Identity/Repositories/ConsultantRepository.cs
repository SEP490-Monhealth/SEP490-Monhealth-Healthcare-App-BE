using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;

namespace Monhealth.Identity.Repositories
{
    public class ConsultantRepository : GenericRepository<Consultant, Guid>, IConsultantRepository
    {
        public ConsultantRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Consultant>> GetAllConsultants(int page, int limit, string? expertise, string? search, bool? status, bool? isVerified)
        {
            IQueryable<Consultant> query = _context.Consultants
                .Select(c => new Consultant
                {
                    ConsultantId = c.ConsultantId,
                    UserId = c.UserId,
                    Status = c.Status,
                    Bio = c.Bio,
                    Experience = c.Experience,
                    RatingCount = c.RatingCount,
                    AverageRating = c.AverageRating,
                    IsVerified = c.IsVerified,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    AppUser = new AppUser
                    {
                        FullName = c.AppUser.FullName,
                        Avatar = c.AppUser.Avatar,
                        PhoneNumber = c.AppUser.PhoneNumber,
                        Email = c.AppUser.Email,
                    },
                    Expertise = new Expertise
                    {
                        ExpertiseName = c.Expertise.ExpertiseName,
                    }
                })
                .AsQueryable();

            if (!string.IsNullOrEmpty(expertise))
            {
                query = query.Where(c => EF.Functions.Collate(c.Expertise.ExpertiseName.ToLower(), "SQL_Latin1_General_CP1_CI_AI").Contains(expertise.ToLower()));
            }

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => EF.Functions.Collate(c.AppUser.FullName.ToLower(), "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                                c.AppUser.FullName.ToLower().Contains(search.ToLower())
                                 || c.AppUser.PhoneNumber.Contains(search)
                                 || c.ConsultantId.ToString().Contains(search.ToLower())

                                 );
            }

            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            if (isVerified.HasValue)
            {
                query = query.Where(s => s.IsVerified == isVerified.Value);
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

        public async Task<Consultant> GetConsultantById(Guid consultantId)
        {
            var consultant = await _context.Consultants
                .Where(i => i.ConsultantId == consultantId)
                .Select(c => new Consultant
                {
                    ConsultantId = c.ConsultantId,
                    UserId = c.UserId,
                    Status = c.Status,
                    Bio = c.Bio,
                    Experience = c.Experience,
                    RatingCount = c.RatingCount,
                    AverageRating = c.AverageRating,
                    IsVerified = c.IsVerified,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    AppUser = new AppUser
                    {
                        FullName = c.AppUser.FullName,
                        Avatar = c.AppUser.Avatar,
                        PhoneNumber = c.AppUser.PhoneNumber,
                        Email = c.AppUser.Email,
                    },
                    Expertise = new Expertise
                    {
                        ExpertiseName = c.Expertise.ExpertiseName,
                    }
                }).FirstOrDefaultAsync();
            return consultant;
        }

        public async Task<Consultant> GetConsultantByUserId(Guid? userId)
        {
            return await _context.Consultants.Include(c => c.AppUser)
            .Include(c => c.Expertise).
            FirstOrDefaultAsync(c => c.UserId == userId);
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
