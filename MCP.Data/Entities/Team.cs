namespace CED.Data.Entities
{
    public class Team
    {
        public Guid TeaId { get; set; }

        public byte[] TeaTimeStamp { get; set; } = null!;

        public Guid TeaDepartmentId { get; set; }

        public DateTime TeaCreatedDate { get; set; }

        public string? TeaCreatedBy { get; set; }

        public DateTime TeaLastModifiedDate { get; set; }

        public string? TeaLastModifiedBy { get; set; }

        public Guid? TeaManagerId { get; set; }

        public string? TeaGroupRoleId { get; set; }

        public virtual ICollection<EmployeeTeam> EmployeeTeams { get; } = new List<EmployeeTeam>();

        public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

        public virtual OrganizationUnit Tea { get; set; } = null!;

        public virtual Department TeaDepartment { get; set; } = null!;

        public virtual Employee? TeaManager { get; set; }
    }
}