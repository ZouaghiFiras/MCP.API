namespace CED.Data.Entities
{
    public class Job
    {
        public Guid JobId { get; set; }

        public byte[] JobTimeStamp { get; set; } = null!;

        public string JobCode { get; set; } = null!;

        public string? JobShortName { get; set; }

        public string JobLongName { get; set; } = null!;

        public bool JobInactive { get; set; }

        public DateTime JobCreatedDate { get; set; }

        public string? JobCreatedBy { get; set; }

        public DateTime JobLastModifiedDate { get; set; }

        public string? JobLastModifiedBy { get; set; }

        public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
    }
}