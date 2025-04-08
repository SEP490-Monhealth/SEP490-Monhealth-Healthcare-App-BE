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

        public async Task<PaginatedResult<Consultant>> GetAllConsultants(int page, int limit, string? expertise, string? search, bool? verification, bool? popular, bool? status)
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
                    VerificationStatus = c.VerificationStatus,
                    Views = c.Views,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    BookingCount = c.BookingCount,
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
                query = query.Where(c => c.ConsultantId.ToString().ToLower().Contains(search.ToLower().Trim())
                                      || c.UserId.ToString().ToLower().Contains(search.ToLower().Trim())
                                      || c.ExpertiseId.ToString().ToLower().Contains(search.ToLower().Trim())
                                      || c.AppUser.PhoneNumber.Contains(search.ToLower().Trim())
                                      || c.AppUser.Email.Contains(search.ToLower().Trim())
                                      || EF.Functions.Collate(c.AppUser.FullName.ToLower(), "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower().Trim()));
            }

            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            if(verification.HasValue)
            {
                if (verification == true)
                {
                    query = query.Where(s => s.VerificationStatus == VerificationStatus.Verified);
                }
                else
                {
                    query = query.Where(s => s.VerificationStatus == VerificationStatus.Pending && s.VerificationStatus == VerificationStatus.Reject);
                }
            }           
            if (popular.HasValue && popular.Value)
            {
                query = query.OrderByDescending(d => d.Views);
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
                    VerificationStatus = c.VerificationStatus,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    BookingCount = c.BookingCount,
                    Views = c.Views,
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
            if (consultant != null)
            {
                // Tăng số lượt xem lên 1
                await _context.Database.ExecuteSqlRawAsync("UPDATE Consultants SET Views = Views + 1 WHERE ConsultantId = {0}", consultantId);
            }

            return consultant;
        }

        public async Task<Consultant> GetConsultantByUserId(Guid? userId)
        {
            return await _context.Consultants.Include(c => c.AppUser)
            .Include(c => c.Expertise).
            FirstOrDefaultAsync(c => c.UserId == userId);
        }

        public async Task<Consultant> GetConsultantWithWalletAndTransactionsAsync(Guid ConsultantId)
        {
            return await _context.Consultants.Include(c => c.Wallet)
            .ThenInclude(tr => tr.Transactions).FirstOrDefaultAsync(c => c.ConsultantId == ConsultantId);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
