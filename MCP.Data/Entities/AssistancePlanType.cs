namespace CED.Data.Entities
{
    public class AssistancePlanType
    {
        public Guid AptId { get; set; }

        public byte[] AptTimeStamp { get; set; } = null!;

        public string AptCode { get; set; } = null!;

        public string? AptShortName { get; set; }

        public string AptLongName { get; set; } = null!;

        public bool? AptIsApplicableObject { get; set; }

        public bool? AptIsApplicablePerson { get; set; }

        public bool? AptAllowCostSharing { get; set; }

        public bool? AptOnlyAbroad { get; set; }

        public int AptPriority { get; set; }

        public bool AptInactive { get; set; }

        public Guid? AptLocalizableEntryId { get; set; }

        public DateTime AptCreatedDate { get; set; }

        public string? AptCreatedBy { get; set; }

        public DateTime AptLastModifiedDate { get; set; }

        public string? AptLastModifiedBy { get; set; }

        public virtual LocalizableEntry? AptLocalizableEntry { get; set; }

        public virtual ICollection<AssistancePlan> AssistancePlans { get; } = new List<AssistancePlan>();

        public virtual ClaimReserveAssistancePlanType? ClaimReserveAssistancePlanType { get; set; }
    }
}