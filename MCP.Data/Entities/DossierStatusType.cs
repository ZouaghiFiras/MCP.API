namespace CED.Data.Entities
{
    public class DossierStatusType
    {
        public string DtyId { get; set; } = null!;

        public byte[] DtyTimeStamp { get; set; } = null!;

        public string DtyName { get; set; } = null!;

        public bool DtyInactive { get; set; }

        public Guid? DtyLocalizableEntryId { get; set; }

        public DateTime DtyCreatedDate { get; set; }

        public string? DtyCreatedBy { get; set; }

        public DateTime DtyLastModifiedDate { get; set; }

        public string? DtyLastModifiedBy { get; set; }

        public virtual ICollection<DossierStatus> DossierStatuses { get; } = new List<DossierStatus>();

        public virtual LocalizableEntry? DtyLocalizableEntry { get; set; }
    }
}