namespace CED.Data.Entities
{
    public class SkillsServiceGroup
    {
        public Guid SsgId { get; set; }

        public byte[] SsgTimeStamp { get; set; } = null!;

        public Guid SsgSkillId { get; set; }

        public Guid SsgServiceGroupId { get; set; }

        public DateTime SsgEffectiveDate { get; set; }

        public DateTime? SsgTerminationDate { get; set; }

        public DateTime SsgCreatedDate { get; set; }

        public string? SsgCreatedBy { get; set; }

        public DateTime SsgLastModifiedDate { get; set; }

        public string? SsgLastModifiedBy { get; set; }

        public virtual ServiceGroup SsgServiceGroup { get; set; } = null!;

        public virtual Skill SsgSkill { get; set; } = null!;
    }
}