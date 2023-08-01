namespace CED.Data.Entities
{
    public class Skill
    {
        public Guid SklId { get; set; }

        public byte[] SklTimeStamp { get; set; } = null!;

        public string SklCode { get; set; } = null!;

        public string? SklShortName { get; set; }

        public string SklLongName { get; set; } = null!;

        public bool SklInactive { get; set; }

        public Guid? SklLocalizableEntryId { get; set; }

        public DateTime SklCreatedDate { get; set; }

        public string? SklCreatedBy { get; set; }

        public DateTime SklLastModifiedDate { get; set; }

        public string? SklLastModifiedBy { get; set; }

        public virtual ICollection<DossierLine> DossierLines { get; } = new List<DossierLine>();

        public virtual ICollection<RepairerSkill> RepairerSkills { get; } = new List<RepairerSkill>();

        public virtual ICollection<SkillsServiceGroup> SkillsServiceGroups { get; } = new List<SkillsServiceGroup>();

        public virtual LocalizableEntry? SklLocalizableEntry { get; set; }

        public virtual ICollection<TimeSheet> TimeSheets { get; } = new List<TimeSheet>();

        public virtual ICollection<WorkActivitySkill> WorkActivitySkills { get; } = new List<WorkActivitySkill>();
    }
}