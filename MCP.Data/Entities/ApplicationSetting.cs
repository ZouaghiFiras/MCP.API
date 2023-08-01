namespace CED.Data.Entities
{
    public class ApplicationSetting
    {
        public Guid AcsId { get; set; }

        public byte[] AcsTimeStamp { get; set; } = null!;

        public Guid AcsLegalEntityId { get; set; }

        public string AcsEntrySystem { get; set; } = null!;

        public string AcsApplicationRuleId { get; set; } = null!;

        public string? AcsApplicationRuleValue { get; set; }

        public DateTime AcsEffectiveDate { get; set; }

        public DateTime? AcsTerminationDate { get; set; }

        public DateTime AcsCreatedDate { get; set; }

        public string? AcsCreatedBy { get; set; }

        public DateTime AcsLastModifiedDate { get; set; }

        public string? AcsLastModifiedBy { get; set; }

        public virtual LegalEntity AcsLegalEntity { get; set; } = null!;
    }
}