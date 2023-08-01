namespace CED.Data.Entities
{
    public class LegalEntity1
    {
        public Guid LeId { get; set; }

        public byte[] LeTimeStamp { get; set; } = null!;

        public Guid LeLegalEntityTypeId { get; set; }

        public Guid? LeFiscalEntityId { get; set; }

        public string? LeExactAdministration { get; set; }

        public string LeCurrencyCode { get; set; } = null!;

        public string? LeDocumentNamePrefix { get; set; }

        public string? LeSalesJournalId { get; set; }

        public string? LePurchaseJournalId { get; set; }

        public string? LeConsolidationDebtorNumber { get; set; }

        public string? LeConsolidationCreditorNumber { get; set; }

        public string? LeCreditSalesJournalId { get; set; }

        public string? LeCreditPurchaseJournalId { get; set; }

        public string? LePurchaseMemorialJournalId { get; set; }

        public string? LePrepaymentSuspenseAccount { get; set; }

        public string? LeEqualizationSuspenseAccount { get; set; }

        public Guid? LeDefaultBankAccountId { get; set; }

        public Guid? LeGeneralSupplierId { get; set; }

        public Guid? LeDefaultPaymentConditionId { get; set; }

        public DateTime LeCreatedDate { get; set; }

        public string? LeCreatedBy { get; set; }

        public DateTime LeLastModifiedDate { get; set; }

        public string? LeLastModifiedBy { get; set; }
    }
}