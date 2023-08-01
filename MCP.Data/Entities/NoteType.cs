namespace CED.Data.Entities
{
    public class NoteType
    {
        public Guid NotId { get; set; }

        public byte[] NotTimeStamp { get; set; } = null!;

        public string NotCode { get; set; } = null!;

        public string? NotShortName { get; set; }

        public string NotLongName { get; set; } = null!;

        public bool NotInactive { get; set; }

        public Guid? NotLocalizableEntryId { get; set; }

        public DateTime NotCreatedDate { get; set; }

        public string? NotCreatedBy { get; set; }

        public DateTime NotLastModifiedDate { get; set; }

        public string? NotLastModifiedBy { get; set; }

        public virtual ICollection<DossierAssignmentNote> DossierAssignmentNotes { get; } =
            new List<DossierAssignmentNote>();

        public virtual ICollection<DossierNote> DossierNotes { get; } = new List<DossierNote>();

        public virtual LocalizableEntry? NotLocalizableEntry { get; set; }

        public virtual ICollection<WorkingOrderLineCostNote> WorkingOrderLineCostNotes { get; } =
            new List<WorkingOrderLineCostNote>();

        public virtual ICollection<WorkingOrderLineCoverageNote> WorkingOrderLineCoverageNotes { get; } =
            new List<WorkingOrderLineCoverageNote>();

        public virtual ICollection<WorkingOrderLineNote> WorkingOrderLineNotes { get; } =
            new List<WorkingOrderLineNote>();

        public virtual ICollection<WorkingOrderNote> WorkingOrderNotes { get; } = new List<WorkingOrderNote>();
    }
}