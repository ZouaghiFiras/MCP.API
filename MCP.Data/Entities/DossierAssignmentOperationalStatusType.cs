namespace CED.Data.Entities
{
    public class DossierAssignmentOperationalStatusType
    {
        public string AstId { get; set; } = null!;

        public byte[] AstTimeStamp { get; set; } = null!;

        public string AstName { get; set; } = null!;

        public bool AstInactive { get; set; }

        public Guid? AstLocalizableEntryId { get; set; }

        public DateTime AstCreatedDate { get; set; }

        public string? AstCreatedBy { get; set; }

        public DateTime AstLastModifiedDate { get; set; }

        public string? AstLastModifiedBy { get; set; }

        public virtual LocalizableEntry? AstLocalizableEntry { get; set; }

        public virtual ICollection<DossierAssignmentOperationalStatus> DossierAssignmentOperationalStatuses { get; } =
            new List<DossierAssignmentOperationalStatus>();
    }
}