namespace CED.Data.Entities
{
    public class DossierAssignmentEmployeeType
    {
        public Guid AetId { get; set; }

        public byte[] AetTimeStamp { get; set; } = null!;

        public string AetName { get; set; } = null!;

        public bool AetInactive { get; set; }

        public Guid? AetLocalizableEntryId { get; set; }

        public DateTime AetCreatedDate { get; set; }

        public string? AetCreatedBy { get; set; }

        public DateTime AetLastModifiedDate { get; set; }

        public string? AetLastModifiedBy { get; set; }

        public virtual LocalizableEntry? AetLocalizableEntry { get; set; }

        public virtual ICollection<DossierAssignmentHandlerHistory> DossierAssignmentHandlerHistories { get; } =
            new List<DossierAssignmentHandlerHistory>();
    }
}