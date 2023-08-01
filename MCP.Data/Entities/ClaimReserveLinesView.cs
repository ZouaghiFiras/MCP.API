namespace CED.Data.Entities
{
    public class ClaimReserveLinesView
    {
        public Guid Id { get; set; }

        public Guid ClaimReserveId { get; set; }

        public DateTime TransactionDate { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public decimal ReservedValue { get; set; }

        public double LeadExchangeRate { get; set; }

        public Guid? LeadExchangeRateId { get; set; }

        public string LeadCurrencyCode { get; set; } = null!;

        public decimal LeadReservedValue { get; set; }

        public double ClientExchangeRate { get; set; }

        public Guid? ClientExchangeRateId { get; set; }

        public string ClientCurrencyCode { get; set; } = null!;

        public decimal ClientReservedValue { get; set; }

        public bool IsManualTransaction { get; set; }

        public string? TransactionReason { get; set; }

        public Guid? PurchaseInvoiceId { get; set; }

        public string? PurchaseInvoiceNumber { get; set; }

        public Guid? AssistancePlanLineId { get; set; }

        public int? AssistancePlanLineNumber { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public string? AssistancePlanNumber { get; set; }

        public Guid? WorkingOrderLineId { get; set; }

        public string? WorkingOrderLineNumber { get; set; }

        public Guid? WorkingOrderId { get; set; }

        public string? WorkingOrderNumber { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}