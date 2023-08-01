namespace CED.Data.Entities
{
    public class AssistanceLocationType
    {
        public Guid AltId { get; set; }

        public byte[] AltTimeStamp { get; set; } = null!;

        public string AltCode { get; set; } = null!;

        public string? AltShortName { get; set; }

        public string AltLongName { get; set; } = null!;

        public bool? AltIsApplicableObject { get; set; }

        public bool? AltIsApplicablePerson { get; set; }

        public bool? AltIsFromLocation { get; set; }

        public bool? AltIsToLocation { get; set; }

        public bool AltInactive { get; set; }

        public Guid? AltLocalizableEntryId { get; set; }

        public DateTime AltCreatedDate { get; set; }

        public string? AltCreatedBy { get; set; }

        public DateTime AltLastModifiedDate { get; set; }

        public string? AltLastModifiedBy { get; set; }

        public virtual LocalizableEntry? AltLocalizableEntry { get; set; }
    }
}