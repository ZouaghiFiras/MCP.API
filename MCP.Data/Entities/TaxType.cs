namespace CED.Data.Entities
{
    public class TaxType
    {
        public short TatId { get; set; }

        public byte[] TatTimeStamp { get; set; } = null!;

        public string? TatAbbreviation { get; set; }

        public string TatDescription { get; set; } = null!;

        public bool TatInactive { get; set; }

        public Guid? TatLocalizableEntryId { get; set; }

        public DateTime TatCreatedDate { get; set; }

        public string? TatCreatedBy { get; set; }

        public DateTime TatLastModifiedDate { get; set; }

        public string? TatLastModifiedBy { get; set; }

        public virtual LocalizableEntry? TatLocalizableEntry { get; set; }

        public virtual ICollection<TaxCode> TaxCodes { get; } = new List<TaxCode>();
    }
}