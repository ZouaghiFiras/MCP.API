namespace CED.Data.Entities
{
    public class InvoiceDeliveryMethodType
    {
        public string DmtId { get; set; } = null!;

        public byte[] DmtTimeStamp { get; set; } = null!;

        public string DmtDescription { get; set; } = null!;

        public bool DmtInactive { get; set; }

        public Guid? DmtLocalizableEntryId { get; set; }

        public DateTime DmtCreatedDate { get; set; }

        public string? DmtCreatedBy { get; set; }

        public DateTime DmtLastModifiedDate { get; set; }

        public string? DmtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? DmtLocalizableEntry { get; set; }

        public virtual ICollection<InvoiceDeliveryMethod> InvoiceDeliveryMethods { get; } =
            new List<InvoiceDeliveryMethod>();
    }
}