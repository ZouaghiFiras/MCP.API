namespace CED.Data.Entities
{
    public class PaymentBatchCreditorsView
    {
        public Guid PaymentBatchId { get; set; }

        public string PaymentBatchNumber { get; set; } = null!;

        public Guid CreditorId { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public string CreditorName { get; set; } = null!;

        public string? EmailAddress { get; set; }

        public Guid CreditTransferId { get; set; }

        public string CreditTransferNumber { get; set; } = null!;

        public string? RemittanceInformation { get; set; }

        public decimal CreditAmount { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}