namespace CED.Data.Entities
{
    public class BankStatementLine
    {
        public Guid BslId { get; set; }

        public byte[] BslTimeStamp { get; set; } = null!;

        public Guid BslBankStatementId { get; set; }

        public int BslSequenceNumber { get; set; }

        public DateTime BslTransactionDate { get; set; }

        public decimal BslTransactionValue { get; set; }

        public string BslCurrencyCode { get; set; } = null!;

        public DateTime? BslBookDate { get; set; }

        public string? BslTransactionCode { get; set; }

        public string? BslReferenceAccountOwner { get; set; }

        public string? BslFurtherReferenceInfo { get; set; }

        public string? BslTransactionDescription { get; set; }

        public string? BslAccountNumber { get; set; }

        public string? BslAccountHolderName { get; set; }

        public string? BslAccountAddressLine1 { get; set; }

        public string? BslAccountAddressLine2 { get; set; }

        public string? BslBankName { get; set; }

        public string? BslIban { get; set; }

        public string? BslBic { get; set; }

        public string? BslRemittanceInformation { get; set; }

        public bool BslUrgentTransfer { get; set; }

        public Guid? BslPaymentBatchId { get; set; }

        public DateTime BslCreatedDate { get; set; }

        public string? BslCreatedBy { get; set; }

        public DateTime BslLastModifiedDate { get; set; }

        public string? BslLastModifiedBy { get; set; }

        public virtual ICollection<BankStatementLineAttachment> BankStatementLineAttachments { get; } =
            new List<BankStatementLineAttachment>();

        public virtual ICollection<BankStatementReconcilliation> BankStatementReconcilliations { get; } =
            new List<BankStatementReconcilliation>();

        public virtual BankStatement BslBankStatement { get; set; } = null!;

        public virtual PaymentBatch? BslPaymentBatch { get; set; }

        public virtual ICollection<FundingsPayment> FundingsPayments { get; } = new List<FundingsPayment>();

        public virtual ICollection<PurchasePayment> PurchasePayments { get; } = new List<PurchasePayment>();

        public virtual ICollection<RecoveryPayment> RecoveryPayments { get; } = new List<RecoveryPayment>();

        public virtual ICollection<SalesPayment> SalesPayments { get; } = new List<SalesPayment>();
    }
}