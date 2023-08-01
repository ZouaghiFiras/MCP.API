namespace CED.Data.Entities
{
    public class VisitInformationStatusType
    {
        public string VistId { get; set; } = null!;

        public byte[] VistTimeStamp { get; set; } = null!;

        public string VistName { get; set; } = null!;

        public bool VistInactive { get; set; }

        public Guid? VistLocalizableEntryId { get; set; }

        public DateTime VistCreatedDate { get; set; }

        public string? VistCreatedBy { get; set; }

        public DateTime VistLastModifiedDate { get; set; }

        public string? VistLastModifiedBy { get; set; }

        public virtual ICollection<VisitInformationStatus> VisitInformationStatuses { get; } =
            new List<VisitInformationStatus>();

        public virtual LocalizableEntry? VistLocalizableEntry { get; set; }
    }
}