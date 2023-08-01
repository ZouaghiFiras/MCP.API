namespace CED.Data.Entities
{
    public class EmployeeTeam
    {
        public Guid EmtId { get; set; }

        public byte[] EmtTimeStamp { get; set; } = null!;

        public Guid EmtEmployeeId { get; set; }

        public Guid EmtTeamId { get; set; }

        public DateTime EmtCreatedDate { get; set; }

        public string? EmtCreatedBy { get; set; }

        public DateTime EmtLastModifiedDate { get; set; }

        public string? EmtLastModifiedBy { get; set; }

        public virtual Employee EmtEmployee { get; set; } = null!;

        public virtual Team EmtTeam { get; set; } = null!;
    }
}