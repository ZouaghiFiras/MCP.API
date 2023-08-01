namespace CED.Data.Entities
{
    public class PurchaseLedgerSetting
    {
        public Guid PlsId { get; set; }

        public byte[] PlsTimeStamp { get; set; } = null!;

        public Guid PlsLegalEntityId { get; set; }

        public string? PlsEntrySystem { get; set; }

        public string PlsGeneralLedgerId { get; set; } = null!;

        public string? PlsAbbreviation { get; set; }

        public string? PlsDescription { get; set; }

        public bool PlsIsInvoice { get; set; }

        public bool PlsIsRecipientLegalEntity { get; set; }

        public bool PlsIsIntercompany { get; set; }

        public bool? PlsIsCrossBorderClaimDepartment { get; set; }

        public bool PlsIsCredit { get; set; }

        public bool? PlsIsWithHoldingTax { get; set; }

        public bool? PlsIsFee { get; set; }

        public bool PlsIsCostOfSales { get; set; }

        public DateTime PlsEffectiveDate { get; set; }

        public DateTime? PlsTerminationDate { get; set; }

        public string? PlsEqualizationJournalId { get; set; }

        public string? PlsEqualizationDebitGeneralLedgerId { get; set; }

        public string? PlsEqualizationCreditGeneralLedgerId { get; set; }

        public DateTime PlsCreatedDate { get; set; }

        public string? PlsCreatedBy { get; set; }

        public DateTime PlsLastModifiedDate { get; set; }

        public string? PlsLastModifiedBy { get; set; }

        public virtual GeneralLedger? PlsEqualizationCreditGeneralLedger { get; set; }

        public virtual GeneralLedger? PlsEqualizationDebitGeneralLedger { get; set; }

        public virtual Journal? PlsEqualizationJournal { get; set; }

        public virtual GeneralLedger PlsGeneralLedger { get; set; } = null!;

        public virtual LegalEntity PlsLegalEntity { get; set; } = null!;

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();
    }
}