namespace CED.Data.Entities
{
    public class BusinessHour
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string WeekDay { get; set; } = null!;

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public bool IsClosed { get; set; }

        public Guid OrganizationUnitId { get; set; }

        public bool Inactive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;
    }
}