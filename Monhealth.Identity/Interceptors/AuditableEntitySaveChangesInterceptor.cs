using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Monhealth.Application.Contracts.Identity;
using Monhealth.Domain.Common;

namespace Monhealth.Identity.Interceptors
{
    public class AuditableEntitySaveChangesInterceptor(ICurrentUserService currentUserService)
        : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            UpdateEntities(eventData.Context);
            return base.SavingChanges(eventData, result);
        }
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            UpdateEntities(eventData.Context);
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
        private void UpdateEntities(DbContext? context)
        {
            if (context == null) return;

            var userId = currentUserService.GetCurrentUserId();
            var currentTime = GetCurrentVietnamTime();

            foreach (var entry in context.ChangeTracker.Entries<TimeEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = currentTime;
                    entry.Entity.UpdatedAt = currentTime;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = currentTime;

                    entry.Property(x => x.CreatedAt).IsModified = false;
                }
            }

            foreach (var entry in context.ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = currentTime;
                    entry.Entity.UpdatedAt = currentTime;
                    entry.Entity.CreatedBy = userId;
                    entry.Entity.UpdatedBy = userId;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = currentTime;
                    entry.Entity.UpdatedBy = userId;

                    entry.Property(x => x.CreatedAt).IsModified = false;
                    entry.Property(x => x.CreatedBy).IsModified = false;
                }
            }
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
