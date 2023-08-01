namespace CED.Data.Entities
{
    public class CoverageProductType
    {
        public Guid CoptId { get; set; }

        public byte[] CoptTimeStamp { get; set; } = null!;

        public string? CoptCode { get; set; }

        public string CoptName { get; set; } = null!;

        public bool CoptInactive { get; set; }

        public Guid? CoptLocalizableEntryId { get; set; }

        public DateTime CoptCreatedDate { get; set; }

        public string? CoptCreatedBy { get; set; }

        public DateTime CoptLastModifiedDate { get; set; }

        public string? CoptLastModifiedBy { get; set; }

        public virtual LocalizableEntry? CoptLocalizableEntry { get; set; }

        public virtual ICollection<CoverageProduct> CoverageProducts { get; } = new List<CoverageProduct>();
    }
}