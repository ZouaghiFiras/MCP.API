namespace CED.Data.Entities
{
    public class TimeWindowList
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string Code { get; set; } = null!;

        public string? ShortName { get; set; }

        public string LongName { get; set; } = null!;

        public bool IsDefault { get; set; }

        public Guid? DepartmentId { get; set; }

        public bool Inactive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public virtual OrganizationUnit? Department { get; set; }

        public virtual ICollection<TimeWindow> TimeWindows { get; } = new List<TimeWindow>();
    }
}