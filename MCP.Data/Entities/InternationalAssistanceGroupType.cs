namespace CED.Data.Entities
{
    public class InternationalAssistanceGroupType
    {
        public Guid AigtId { get; set; }

        public byte[] AigtTimeStamp { get; set; } = null!;

        public string AigtCode { get; set; } = null!;

        public string? AigtShortName { get; set; }

        public string AigtLongName { get; set; } = null!;

        public bool AigtInactive { get; set; }

        public Guid? AigtLocalizableEntryId { get; set; }

        public DateTime AigtCreatedDate { get; set; }

        public string? AigtCreatedBy { get; set; }

        public DateTime AigtLastModifiedDate { get; set; }

        public string? AigtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? AigtLocalizableEntry { get; set; }

        public virtual ICollection<InternationalAssistanceGroup> InternationalAssistanceGroups { get; } =
            new List<InternationalAssistanceGroup>();
    }
}