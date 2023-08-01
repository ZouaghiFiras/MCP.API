namespace CED.Data.Entities
{
    public class VisitInformationStatus
    {
        public Guid VisId { get; set; }

        public byte[] VisTimeStamp { get; set; } = null!;

        public string VisCode { get; set; } = null!;

        public string? VisShortName { get; set; }

        public string VisLongName { get; set; } = null!;

        public bool VisInactive { get; set; }

        public string? VisVisitInformationStatusTypeId { get; set; }

        public Guid? VisLocalizableEntryId { get; set; }

        public DateTime VisCreatedDate { get; set; }

        public string? VisCreatedBy { get; set; }

        public DateTime VisLastModifiedDate { get; set; }

        public string? VisLastModifiedBy { get; set; }

        public virtual LocalizableEntry? VisLocalizableEntry { get; set; }

        public virtual VisitInformationStatusType? VisVisitInformationStatusType { get; set; }

        public virtual ICollection<VisitInformationStatusHistory> VisitInformationStatusHistories { get; } =
            new List<VisitInformationStatusHistory>();
    }
}