namespace CED.Data.Entities
{
    public class WorkActivitySkill
    {
        public Guid WasId { get; set; }

        public byte[] WasTimeStamp { get; set; } = null!;

        public Guid WasWorkActivityId { get; set; }

        public Guid WasSkillId { get; set; }

        public DateTime WasEffectiveDate { get; set; }

        public DateTime? WasTerminationDate { get; set; }

        public DateTime WasCreatedDate { get; set; }

        public string? WasCreatedBy { get; set; }

        public DateTime WasLastModifiedDate { get; set; }

        public string? WasLastModifiedBy { get; set; }

        public virtual Skill WasSkill { get; set; } = null!;

        public virtual WorkActivity WasWorkActivity { get; set; } = null!;
    }
}