namespace CED.Data.Entities
{
    public class DossierAssignmentType
    {
        public short FatId { get; set; }

        public byte[] FatTimeStamp { get; set; } = null!;

        public string FatCode { get; set; } = null!;

        public string? FatShortName { get; set; }

        public string FatLongName { get; set; } = null!;

        public bool FatInactive { get; set; }

        public Guid? FatLocalizableEntryId { get; set; }

        public DateTime FatCreatedDate { get; set; }

        public string? FatCreatedBy { get; set; }

        public DateTime FatLastModifiedDate { get; set; }

        public string? FatLastModifiedBy { get; set; }

        public virtual ICollection<DossierAssignment> DossierAssignments { get; } = new List<DossierAssignment>();

        public virtual LocalizableEntry? FatLocalizableEntry { get; set; }
    }
}