namespace CED.Data.Entities
{
    public class ClaimReservePaymentsView
    {
        public Guid Id { get; set; }

        public Guid ClaimReserveId { get; set; }

        public DateTime TransactionDate { get; set; }

        public Guid PurchaseInvoiceLineId { get; set; }

        public bool IsCredit { get; set; }

        public string PaymentCurrencyCode { get; set; } = null!;

        public decimal ClaimValue { get; set; }

        public double LeadExchangeRate { get; set; }

        public Guid? LeadExchangeRateId { get; set; }

        public string LeadCurrencyCode { get; set; } = null!;

        public decimal LeadClaimValue { get; set; }

        public double ClientExchangeRate { get; set; }

        public Guid? ClientExchangeRateId { get; set; }

        public string ClientCurrencyCode { get; set; } = null!;

        public decimal ClientClaimValue { get; set; }

        public bool IsManualTransaction { get; set; }

        public string? TransactionReason { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public string PurchaseInvoiceNumber { get; set; } = null!;

        public DateTime PurchaseInvoiceDate { get; set; }

        public string? PurchaseInvoiceStatusCode { get; set; }

        public Guid? SupplierId { get; set; }

        public string SupplierCode { get; set; } = null!;

        public string SupplierName { get; set; } = null!;

        public string? SupplierInvoiceNumber { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        public Guid PurchaseLineId { get; set; }

        public int PurchaseLineNumber { get; set; }

        public Guid? PurchaseLineServiceId { get; set; }

        public string PurchaseLineServiceName { get; set; } = null!;

        public string? PurchaseLineDescription { get; set; }

        public decimal PurchaseLineNetAmount { get; set; }

        public decimal PurchaseLineTaxAmount { get; set; }

        public decimal PurchaseLineGrossAmount { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}