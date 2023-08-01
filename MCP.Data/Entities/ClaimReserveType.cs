namespace CED.Data.Entities
{
    public class ClaimReserveType
    {
        public Guid RvtId { get; set; }

        public byte[] RvtTimeStamp { get; set; } = null!;

        public string RvtCode { get; set; } = null!;

        public string? RvtShortName { get; set; }

        public string RvtLongName { get; set; } = null!;

        public bool? RvtIsApplicableBodilyInjury { get; set; }

        public bool? RvtIsApplicableCostsOfClaims { get; set; }

        public bool? RvtIsApplicableMaterialDamage { get; set; }

        public bool RvtInactive { get; set; }

        public Guid? RvtLocalizableEntryId { get; set; }

        public DateTime RvtCreatedDate { get; set; }

        public string? RvtCreatedBy { get; set; }

        public DateTime RvtLastModifiedDate { get; set; }

        public string? RvtLastModifiedBy { get; set; }

        public virtual ICollection<ClaimReserveAssistancePlanType> ClaimReserveAssistancePlanTypes { get; } =
            new List<ClaimReserveAssistancePlanType>();

        public virtual ICollection<ClaimReserf> ClaimReserves { get; } = new List<ClaimReserf>();

        public virtual LocalizableEntry? RvtLocalizableEntry { get; set; }
    }
}