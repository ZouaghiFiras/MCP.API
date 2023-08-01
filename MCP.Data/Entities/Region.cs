namespace CED.Data.Entities
{
    public class Region
    {
        public Guid RgnId { get; set; }

        public byte[] RgnTimeStamp { get; set; } = null!;

        public string RgnCode { get; set; } = null!;

        public string? RgnShortName { get; set; }

        public string RgnLongName { get; set; } = null!;

        public bool RgnInactive { get; set; }

        public DateTime RgnCreatedDate { get; set; }

        public string? RgnCreatedBy { get; set; }

        public DateTime RgnLastModifiedDate { get; set; }

        public string? RgnLastModifiedBy { get; set; }

        public virtual ICollection<Department> Departments { get; } = new List<Department>();

        public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
    }
}