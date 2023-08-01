namespace CED.Data.Entities
{
    public class ClientInvoiceRuleMethod
    {
        public Guid IrmId { get; set; }

        public byte[] IrmTimeStamp { get; set; } = null!;

        public Guid IrmLegalEntityId { get; set; }

        public Guid IrmClientId { get; set; }

        public string IrmInvoiceRuleTypeId { get; set; } = null!;

        public DateTime IrmEffectiveDate { get; set; }

        public DateTime? IrmTerminationDate { get; set; }

        public DateTime IrmCreatedDate { get; set; }

        public string? IrmCreatedBy { get; set; }

        public DateTime IrmLastModifiedDate { get; set; }

        public string? IrmLastModifiedBy { get; set; }

        public virtual Client IrmClient { get; set; } = null!;

        public virtual InvoiceRuleType IrmInvoiceRuleType { get; set; } = null!;

        public virtual LegalEntity IrmLegalEntity { get; set; } = null!;
    }
}