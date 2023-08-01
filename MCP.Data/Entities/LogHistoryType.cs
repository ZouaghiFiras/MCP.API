namespace CED.Data.Entities
{
    public class LogHistoryType
    {
        public Guid LhtId { get; set; }

        public byte[] LhtTimeStamp { get; set; } = null!;

        public string LhtCode { get; set; } = null!;

        public string? LhtShortName { get; set; }

        public string LhtLongName { get; set; } = null!;

        public bool LhtInactive { get; set; }

        public Guid? LhtLocalizableEntryId { get; set; }

        public DateTime LhtCreatedDate { get; set; }

        public string? LhtCreatedBy { get; set; }

        public DateTime LhtLastModifiedDate { get; set; }

        public string? LhtLastModifiedBy { get; set; }

        public virtual ICollection<DossierAssignmentLogHistory> DossierAssignmentLogHistories { get; } =
            new List<DossierAssignmentLogHistory>();

        public virtual ICollection<DossierLogHistory> DossierLogHistories { get; } = new List<DossierLogHistory>();

        public virtual LocalizableEntry? LhtLocalizableEntry { get; set; }

        public virtual ICollection<VisitInformationLogHistory> VisitInformationLogHistories { get; } =
            new List<VisitInformationLogHistory>();

        public virtual ICollection<WorkingOrderLineLogHistory> WorkingOrderLineLogHistories { get; } =
            new List<WorkingOrderLineLogHistory>();

        public virtual ICollection<WorkingOrderLogHistory> WorkingOrderLogHistories { get; } =
            new List<WorkingOrderLogHistory>();
    }
}