namespace CED.Data.Entities
{
    public class DossierAssignmentOperationalStatus
    {
        public Guid AosId { get; set; }

        public byte[] AosTimeStamp { get; set; } = null!;

        public string AosCode { get; set; } = null!;

        public string? AosShortName { get; set; }

        public string AosLongName { get; set; } = null!;

        public bool AosInactive { get; set; }

        public string? AosDossierAssignmentOperationalStatusTypeId { get; set; }

        public Guid? AosLocalizableEntryId { get; set; }

        public DateTime AosCreatedDate { get; set; }

        public string? AosCreatedBy { get; set; }

        public DateTime AosLastModifiedDate { get; set; }

        public string? AosLastModifiedBy { get; set; }

        public virtual DossierAssignmentOperationalStatusType? AosDossierAssignmentOperationalStatusType { get; set; }

        public virtual LocalizableEntry? AosLocalizableEntry { get; set; }

        public virtual ICollection<DossierAssignmentOperationalStatusHistory>
            DossierAssignmentOperationalStatusHistories { get; } =
            new List<DossierAssignmentOperationalStatusHistory>();
    }
}