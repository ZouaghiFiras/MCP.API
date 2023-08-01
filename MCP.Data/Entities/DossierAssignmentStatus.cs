namespace CED.Data.Entities
{
    public class DossierAssignmentStatus
    {
        public Guid AstId { get; set; }

        public byte[] AstTimeStamp { get; set; } = null!;

        public string AstCode { get; set; } = null!;

        public string? AstShortName { get; set; }

        public string AstLongName { get; set; } = null!;

        public bool AstInactive { get; set; }

        public Guid? AstLocalizableEntryId { get; set; }

        public DateTime AstCreatedDate { get; set; }

        public string? AstCreatedBy { get; set; }

        public DateTime AstLastModifiedDate { get; set; }

        public string? AstLastModifiedBy { get; set; }

        public string AstDossierAssignmentStatusTypeId { get; set; } = null!;

        public virtual LocalizableEntry? AstLocalizableEntry { get; set; }

        public virtual ICollection<DossierAssignmentStatusHistory> DossierAssignmentStatusHistories { get; } =
            new List<DossierAssignmentStatusHistory>();
    }
}