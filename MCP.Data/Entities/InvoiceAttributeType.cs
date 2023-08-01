namespace CED.Data.Entities
{
    public class InvoiceAttributeType
    {
        public string IatId { get; set; } = null!;

        public byte[] IatTimeStamp { get; set; } = null!;

        public string? IatLabel { get; set; }

        public string IatValueType { get; set; } = null!;

        public bool IatInactive { get; set; }

        public Guid? IatLocalizableEntryId { get; set; }

        public DateTime IatCreatedDate { get; set; }

        public string? IatCreatedBy { get; set; }

        public DateTime IatLastModifiedDate { get; set; }

        public string? IatLastModifiedBy { get; set; }

        public virtual LocalizableEntry? IatLocalizableEntry { get; set; }
    }
}