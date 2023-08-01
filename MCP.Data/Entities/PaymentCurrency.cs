namespace CED.Data.Entities
{
    public class PaymentCurrency
    {
        public Guid PcuId { get; set; }

        public byte[] PcuTimeStamp { get; set; } = null!;

        public Guid? PcuLegalEntityId { get; set; }

        public string PcuPaymentCurrencyCode { get; set; } = null!;

        public string PcuForeignCurrencyCode { get; set; } = null!;

        public DateTime PcuEffectiveDate { get; set; }

        public DateTime? PcuTerminationDate { get; set; }

        public DateTime PcuCreatedDate { get; set; }

        public string? PcuCreatedBy { get; set; }

        public DateTime PcuLastModifiedDate { get; set; }

        public string? PcuLastModifiedBy { get; set; }

        public virtual LegalEntity? PcuLegalEntity { get; set; }
    }
}