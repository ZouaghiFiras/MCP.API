namespace CED.Data.Entities
{
    public class DossierAssignmentStatusType
    {
        public string DasId { get; set; } = null!;

        public byte[] DasTimeStamp { get; set; } = null!;

        public string DasName { get; set; } = null!;

        public bool DasInactive { get; set; }

        public Guid? DasLocalizableEntryId { get; set; }

        public DateTime DasCreatedDate { get; set; }

        public string? DasCreatedBy { get; set; }

        public DateTime DasLastModifiedDate { get; set; }

        public string? DasLastModifiedBy { get; set; }

        public virtual LocalizableEntry? DasLocalizableEntry { get; set; }
    }
}