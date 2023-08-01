namespace CED.Data.Entities
{
    public class JournalEntryLine
    {
        public Guid JelId { get; set; }

        public byte[] JelTimeStamp { get; set; } = null!;

        public Guid JelJournalEntryId { get; set; }

        public int JelSequenceNumber { get; set; }

        public string? JelEntryType { get; set; }

        public string? JelEntrySubType { get; set; }

        public string? JelDescription { get; set; }

        public DateTime? JelDate { get; set; }

        public string JelLedgerAccount { get; set; } = null!;

        public string? JelDebtorNumber { get; set; }

        public string? JelCreditorNumber { get; set; }

        public string? JelInvoiceNumber { get; set; }

        public decimal? JelDebitValue { get; set; }

        public decimal? JelCreditValue { get; set; }

        public string? JelCurrencyCode { get; set; }

        public string? JelTaxCode { get; set; }

        public decimal? JelTaxValue { get; set; }

        public string? JelCostCenterCode { get; set; }

        public string? JelCostUnitCode { get; set; }

        public string? JelYourReference { get; set; }

        public string? JelOurReference { get; set; }

        public int? JelLinkId { get; set; }

        public DateTime? JelLinkDate { get; set; }

        public Guid? JelDebtorId { get; set; }

        public Guid? JelCreditorId { get; set; }

        public decimal? JelForeignDebitValue { get; set; }

        public decimal? JelForeignCreditValue { get; set; }

        public decimal? JelForeignTaxValue { get; set; }

        public string? JelForeignCurrencyCode { get; set; }

        public DateTime JelCreatedDate { get; set; }

        public string? JelCreatedBy { get; set; }

        public DateTime JelLastModifiedDate { get; set; }

        public string? JelLastModifiedBy { get; set; }

        public virtual ICollection<BankJournalEntryLine> BankJournalEntryLines { get; } =
            new List<BankJournalEntryLine>();

        public virtual ICollection<CostOfSalesJournalEntryLine> CostOfSalesJournalEntryLines { get; } =
            new List<CostOfSalesJournalEntryLine>();

        public virtual ICollection<CreditTransferJournalEntryLine> CreditTransferJournalEntryLines { get; } =
            new List<CreditTransferJournalEntryLine>();

        public virtual Creditor? JelCreditor { get; set; }

        public virtual Debtor? JelDebtor { get; set; }

        public virtual JournalEntry JelJournalEntry { get; set; } = null!;

        public virtual ICollection<PurchaseJournalEntryLine> PurchaseJournalEntryLines { get; } =
            new List<PurchaseJournalEntryLine>();

        public virtual ICollection<PurchasePaymentJournalEntryLine> PurchasePaymentJournalEntryLines { get; } =
            new List<PurchasePaymentJournalEntryLine>();

        public virtual ICollection<SalesJournalEntryLine> SalesJournalEntryLines { get; } =
            new List<SalesJournalEntryLine>();
    }
}