namespace CED.Data.Entities
{
    public class PaymentBatchLinesReconciliationsView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public Guid BankAccountId { get; set; }

        public decimal CreditAmount { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public DateTime? ExecutionDate { get; set; }

        public bool UrgentTransfer { get; set; }

        public string? AccountNumber { get; set; }

        public string? AccountHolderName { get; set; }

        public string? AccountAddressLine1 { get; set; }

        public string? AccountAddressLine2 { get; set; }

        public string? BankName { get; set; }

        public string? Iban { get; set; }

        public string? Bic { get; set; }

        public string? RemittanceInformation { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }

        public Guid? TenantId { get; set; }

        public Guid PaymentBatchId { get; set; }

        public string PaymentBatchNumber { get; set; } = null!;

        public int PaymentBatchLine { get; set; }

        public Guid? ReconcilliationId { get; set; }

        public short? ActionTypeId { get; set; }

        public string? ActionTypeName { get; set; }

        public Guid? BankStatementLineId { get; set; }

        public int? BankStatementLineNumber { get; set; }

        public Guid? RecoveryStatementId { get; set; }

        public bool? IsRecoveryStatement { get; set; }

        public Guid? SalesInvoiceId { get; set; }

        public bool? IsSalesInvoice { get; set; }

        public Guid? PurchaseInvoiceId { get; set; }

        public bool? IsPurchaseInvoice { get; set; }

        public Guid? CreditTransferId { get; set; }

        public Guid? ClientId { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public DateTime? MatchDate { get; set; }

        public decimal? MatchValue { get; set; }

        public string? Description { get; set; }

        public string? LedgerAccount { get; set; }

        public string? DebtorNumber { get; set; }

        public string? CreditorNumber { get; set; }

        public string? InvoiceNumber { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostUnitCode { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}