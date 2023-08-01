namespace CED.Data.Entities
{
    public class AssistancePlanStatus
    {
        public Guid ApsId { get; set; }

        public byte[] ApsTimeStamp { get; set; } = null!;

        public string ApsCode { get; set; } = null!;

        public string? ApsShortName { get; set; }

        public string ApsLongName { get; set; } = null!;

        public bool ApsInactive { get; set; }

        public Guid? ApsLocalizableEntryId { get; set; }

        public DateTime ApsCreatedDate { get; set; }

        public string? ApsCreatedBy { get; set; }

        public DateTime ApsLastModifiedDate { get; set; }

        public string? ApsLastModifiedBy { get; set; }

        public virtual LocalizableEntry? ApsLocalizableEntry { get; set; }

        public virtual ICollection<AssistancePlanStatusHistory> AssistancePlanStatusHistories { get; } =
            new List<AssistancePlanStatusHistory>();
    }
}