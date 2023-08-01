namespace CED.Data.Entities
{
    public class SalesLedgerSetting
    {
        public Guid SlsId { get; set; }

        public byte[] SlsTimeStamp { get; set; } = null!;

        public Guid SlsLegalEntityId { get; set; }

        public string? SlsEntrySystem { get; set; }

        public Guid? SlsProductId { get; set; }

        public Guid? SlsProductClassificationId { get; set; }

        public Guid? SlsWorkActivityId { get; set; }

        public string SlsGeneralLedgerId { get; set; } = null!;

        public string? SlsAbbreviation { get; set; }

        public string? SlsDescription { get; set; }

        public bool SlsIsInvoice { get; set; }

        public bool SlsIsRecipientLegalEntity { get; set; }

        public bool SlsIsIntercompany { get; set; }

        public bool? SlsIsCrossBorderClaimDepartment { get; set; }

        public bool SlsIsCredit { get; set; }

        public bool? SlsIsWithHoldingTax { get; set; }

        public bool? SlsIsFee { get; set; }

        public DateTime SlsEffectiveDate { get; set; }

        public DateTime? SlsTerminationDate { get; set; }

        public string? SlsEqualizationJournalId { get; set; }

        public string? SlsEqualizationDebitGeneralLedgerId { get; set; }

        public string? SlsEqualizationCreditGeneralLedgerId { get; set; }

        public DateTime SlsCreatedDate { get; set; }

        public string? SlsCreatedBy { get; set; }

        public DateTime SlsLastModifiedDate { get; set; }

        public string? SlsLastModifiedBy { get; set; }

        public virtual GeneralLedger? SlsEqualizationCreditGeneralLedger { get; set; }

        public virtual GeneralLedger? SlsEqualizationDebitGeneralLedger { get; set; }

        public virtual Journal? SlsEqualizationJournal { get; set; }

        public virtual GeneralLedger SlsGeneralLedger { get; set; } = null!;

        public virtual LegalEntity SlsLegalEntity { get; set; } = null!;

        public virtual Product? SlsProduct { get; set; }

        public virtual WorkActivity? SlsWorkActivity { get; set; }
    }
}