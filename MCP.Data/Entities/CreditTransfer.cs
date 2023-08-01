namespace CED.Data.Entities
{
    public class CreditTransfer
    {
        public Guid CrtId { get; set; }

        public byte[] CrtTimeStamp { get; set; } = null!;

        public string CrtNumber { get; set; } = null!;

        public Guid CrtBankAccountId { get; set; }

        public decimal CrtCreditAmount { get; set; }

        public string CrtCurrencyCode { get; set; } = null!;

        public DateTime? CrtExecutionDate { get; set; }

        public bool CrtUrgentTransfer { get; set; }

        public string? CrtAccountNumber { get; set; }

        public string? CrtAccountHolderName { get; set; }

        public string? CrtAccountAddressLine1 { get; set; }

        public string? CrtAccountAddressLine2 { get; set; }

        public string? CrtCountryCode { get; set; }

        public string? CrtBankName { get; set; }

        public Guid? CrtBankId { get; set; }

        public string? CrtIban { get; set; }

        public string? CrtBic { get; set; }

        public string? CrtRemittanceInformation { get; set; }

        public string? CrtEntrySystem { get; set; }

        public string? CrtEntryNumber { get; set; }

        public string? CrtEntryBatch { get; set; }

        public Guid? CrtCanceledCreditTransferId { get; set; }

        public Guid? CrtTenantId { get; set; }

        public DateTime CrtCreatedDate { get; set; }

        public string? CrtCreatedBy { get; set; }

        public DateTime CrtLastModifiedDate { get; set; }

        public string? CrtLastModifiedBy { get; set; }

        public Guid? CrtCurrentStatusHistoryId { get; set; }

        public DateTime? CrtCurrentStatusHistoryStartDate { get; set; }

        public string? CrtCurrentStatusCode { get; set; }

        public virtual ICollection<CreditTransferDossier> CreditTransferDossiers { get; } =
            new List<CreditTransferDossier>();

        public virtual ICollection<CreditTransferJournalEntryLine> CreditTransferJournalEntryLines { get; } =
            new List<CreditTransferJournalEntryLine>();

        public virtual ICollection<CreditTransferPurchaseInvoice> CreditTransferPurchaseInvoices { get; } =
            new List<CreditTransferPurchaseInvoice>();

        public virtual ICollection<CreditTransferReconcilliation> CreditTransferReconcilliations { get; } =
            new List<CreditTransferReconcilliation>();

        public virtual ICollection<CreditTransferRecoveryStatement> CreditTransferRecoveryStatements { get; } =
            new List<CreditTransferRecoveryStatement>();

        public virtual ICollection<CreditTransferSalesInvoice> CreditTransferSalesInvoices { get; } =
            new List<CreditTransferSalesInvoice>();

        public virtual ICollection<CreditTransferStatusHistory> CreditTransferStatusHistories { get; } =
            new List<CreditTransferStatusHistory>();

        public virtual Bank? CrtBank { get; set; }

        public virtual BankAccount CrtBankAccount { get; set; } = null!;

        public virtual CreditTransfer? CrtCanceledCreditTransfer { get; set; }

        public virtual Tenant? CrtTenant { get; set; }

        public virtual ICollection<CreditTransfer> InverseCrtCanceledCreditTransfer { get; } =
            new List<CreditTransfer>();

        public virtual ICollection<PaymentBatchLine> PaymentBatchLines { get; } = new List<PaymentBatchLine>();

        public virtual ICollection<PurchasePaymentBatchLine> PurchasePaymentBatchLines { get; } =
            new List<PurchasePaymentBatchLine>();
    }
}