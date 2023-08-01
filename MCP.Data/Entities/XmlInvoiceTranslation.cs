namespace CED.Data.Entities
{
    public class XmlInvoiceTranslation
    {
        public Guid XitId { get; set; }

        public byte[] XitTimeStamp { get; set; } = null!;

        public string? XitDescriptor { get; set; }

        public string XitElementName { get; set; } = null!;

        public string XitOriginalValue { get; set; } = null!;

        public string XitTranslatedValue { get; set; } = null!;

        public bool XitInactive { get; set; }

        public DateTime XitCreatedDate { get; set; }

        public string? XitCreatedBy { get; set; }

        public DateTime XitLastModifiedDate { get; set; }

        public string? XitLastModifiedBy { get; set; }
    }
}