namespace CED.Data.Entities
{
    public class LedgerSetting
    {
        public Guid GlsId { get; set; }

        public byte[] GlsTimeStamp { get; set; } = null!;

        public Guid GlsLegalEntityId { get; set; }

        public string GlsEntrySystem { get; set; } = null!;

        public string? GlsFundingJournalId { get; set; }

        public string? GlsFundingGeneralLedgerId { get; set; }

        public string? GlsRecoveryGeneralLedgerId { get; set; }

        public string? GlsPaymentInTransitLocalCurrency { get; set; }

        public string? GlsPaymentInTransitForeignCurrency { get; set; }

        public string? GlsPaymentInTransitExchangeRateDifference { get; set; }

        public string? GlsSalesExchangeRateDifference { get; set; }

        public string? GlsPaymentInTransitCurrency1 { get; set; }

        public string? GlsPaymentInTransitCurrency2 { get; set; }

        public string? GlsPaymentInTransitCurrency3 { get; set; }

        public string? GlsPaymentInTransitCurrency4 { get; set; }

        public DateTime GlsEffectiveDate { get; set; }

        public DateTime? GlsTerminationDate { get; set; }

        public DateTime GlsCreatedDate { get; set; }

        public string? GlsCreatedBy { get; set; }

        public DateTime GlsLastModifiedDate { get; set; }

        public string? GlsLastModifiedBy { get; set; }

        public virtual GeneralLedger? GlsFundingGeneralLedger { get; set; }

        public virtual Journal? GlsFundingJournal { get; set; }

        public virtual LegalEntity GlsLegalEntity { get; set; } = null!;

        public virtual GeneralLedger? GlsPaymentInTransitExchangeRateDifferenceNavigation { get; set; }

        public virtual GeneralLedger? GlsPaymentInTransitForeignCurrencyNavigation { get; set; }

        public virtual GeneralLedger? GlsPaymentInTransitLocalCurrencyNavigation { get; set; }

        public virtual GeneralLedger? GlsRecoveryGeneralLedger { get; set; }

        public virtual GeneralLedger? GlsSalesExchangeRateDifferenceNavigation { get; set; }
    }
}