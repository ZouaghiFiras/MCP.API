namespace CED.Data.Entities
{
    public class LegalEntityPaymentMethod
    {
        public Guid LpmId { get; set; }

        public byte[] LpmTimeStamp { get; set; } = null!;

        public Guid LpmLegalEntityId { get; set; }

        public Guid LpmPaymentMethodId { get; set; }

        public string? LpmExactCode { get; set; }

        public bool LpmInactive { get; set; }

        public DateTime LpmCreatedDate { get; set; }

        public string? LpmCreatedBy { get; set; }

        public DateTime LpmLastModifiedDate { get; set; }

        public string? LpmLastModifiedBy { get; set; }

        public virtual LegalEntity LpmLegalEntity { get; set; } = null!;

        public virtual PaymentMethod LpmPaymentMethod { get; set; } = null!;
    }
}