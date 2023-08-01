namespace CED.Data.Entities
{
    public class BankStatementReconcilliation
    {
        public Guid BsrId { get; set; }

        public byte[] BsrTimeStamp { get; set; } = null!;

        public short BsrReconcilliationActionTypeId { get; set; }

        public Guid BsrBankStatementLineId { get; set; }

        public Guid? BsrRecoveryStatementId { get; set; }

        public Guid? BsrSalesInvoiceId { get; set; }

        public Guid? BsrPurchaseInvoiceId { get; set; }

        public Guid? BsrCreditTransferId { get; set; }

        public Guid? BsrClientId { get; set; }

        public Guid? BsrDossierId { get; set; }

        public string? BsrDossierNumber { get; set; }

        public DateTime BsrMatchDate { get; set; }

        public decimal BsrMatchValue { get; set; }

        public string? BsrDescription { get; set; }

        public string BsrLedgerAccount { get; set; } = null!;

        public string? BsrDebtorNumber { get; set; }

        public string? BsrCreditorNumber { get; set; }

        public string? BsrInvoiceNumber { get; set; }

        public string? BsrCostCenterCode { get; set; }

        public string? BsrCostUnitCode { get; set; }

        public string? BsrYourReference { get; set; }

        public string? BsrOurReference { get; set; }

        public string? BsrAccountNumber { get; set; }

        public string? BsrAccountHolderName { get; set; }

        public string? BsrAccountAddressLine1 { get; set; }

        public string? BsrAccountAddressLine2 { get; set; }

        public string? BsrBankName { get; set; }

        public string? BsrIban { get; set; }

        public string? BsrBic { get; set; }

        public string? BsrNotes { get; set; }

        public DateTime BsrCreatedDate { get; set; }

        public string? BsrCreatedBy { get; set; }

        public DateTime BsrLastModifiedDate { get; set; }

        public string? BsrLastModifiedBy { get; set; }

        public virtual ICollection<BankJournalEntryLine> BankJournalEntryLines { get; } =
            new List<BankJournalEntryLine>();

        public virtual BankStatementCorrection? BankStatementCorrection { get; set; }

        public virtual ICollection<BankStatementCorrectionLine> BankStatementCorrectionLines { get; } =
            new List<BankStatementCorrectionLine>();

        public virtual BankStatementLine BsrBankStatementLine { get; set; } = null!;

        public virtual Client? BsrClient { get; set; }

        public virtual Dossier? BsrDossier { get; set; }

        public virtual PurchaseInvoice? BsrPurchaseInvoice { get; set; }

        public virtual ReconcilliationActionType BsrReconcilliationActionType { get; set; } = null!;

        public virtual RecoveryStatement? BsrRecoveryStatement { get; set; }

        public virtual SalesInvoice? BsrSalesInvoice { get; set; }

        public virtual ICollection<CreditTransferReconcilliation> CreditTransferReconcilliations { get; } =
            new List<CreditTransferReconcilliation>();
    }
}