namespace Monhealth.Domain.Common
{
    public abstract class TimeEntity
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
