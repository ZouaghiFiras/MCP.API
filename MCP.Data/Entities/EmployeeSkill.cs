namespace CED.Data.Entities
{
    public class EmployeeSkill
    {
        public Guid EskId { get; set; }

        public byte[] EskTimeStamp { get; set; } = null!;

        public Guid EskEmployeeId { get; set; }

        public Guid EskSkillId { get; set; }

        public DateTime EskCreatedDate { get; set; }

        public string? EskCreatedBy { get; set; }

        public DateTime EskLastModifiedDate { get; set; }

        public string? EskLastModifiedBy { get; set; }

        public virtual Employee EskEmployee { get; set; } = null!;
    }
}