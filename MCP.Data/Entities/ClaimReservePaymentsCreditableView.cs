namespace CED.Data.Entities
{
    public class ClaimReservePaymentsCreditableView
    {
        public Guid Id { get; set; }

        public Guid ClaimReserveId { get; set; }

        public DateTime TransactionDate { get; set; }

        public Guid PurchaseInvoiceLineId { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public bool IsCredit { get; set; }

        public string PaymentCurrencyCode { get; set; } = null!;

        public decimal ClaimValue { get; set; }

        public double LeadExchangeRate { get; set; }

        public Guid? LeadExchangeRateId { get; set; }

        public decimal LeadClaimValue { get; set; }

        public double ClientExchangeRate { get; set; }

        public Guid? ClientExchangeRateId { get; set; }

        public decimal ClientClaimValue { get; set; }

        public bool IsManualTransaction { get; set; }

        public string? TransactionReason { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}