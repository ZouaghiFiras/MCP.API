namespace CED.Data.Entities
{
    public class RepairerSkill
    {
        public Guid RskId { get; set; }

        public byte[] RskTimeStamp { get; set; } = null!;

        public Guid RskRepairerId { get; set; }

        public Guid RskSkillId { get; set; }

        public DateTime RskCreatedDate { get; set; }

        public string? RskCreatedBy { get; set; }

        public DateTime RskLastModifiedDate { get; set; }

        public string? RskLastModifiedBy { get; set; }

        public virtual Repairer RskRepairer { get; set; } = null!;

        public virtual Skill RskSkill { get; set; } = null!;
    }
}