namespace CED.Data.Entities
{
    public class BankStatementLinesReconciliationView
    {
        public Guid Id { get; set; }

        public Guid BankStatementId { get; set; }

        public int SequenceNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTime? BookDate { get; set; }

        public decimal TransactionValue { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string? TransactionCode { get; set; }

        public string? TransactionDescription { get; set; }

        public string? ReferenceAccountOwner { get; set; }

        public string? FurtherReferenceInfo { get; set; }

        public string? AccountNumber { get; set; }

        public string? AccountHolderName { get; set; }

        public string? AccountAddressLine1 { get; set; }

        public string? AccountAddressLine2 { get; set; }

        public string? BankName { get; set; }

        public string? Iban { get; set; }

        public string? Bic { get; set; }

        public string? RemittanceInformation { get; set; }

        public decimal ReconciledValue { get; set; }

        public bool IsReconciled { get; set; }

        public bool IsFullyReconciled { get; set; }

        public bool HasCorrections { get; set; }

        public string? CorrectionReason { get; set; }

        public Guid? PaymentBatchId { get; set; }

        public string? PaymentBatchNumber { get; set; }

        public bool HasDocuments { get; set; }

        public bool IsReadonly { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}