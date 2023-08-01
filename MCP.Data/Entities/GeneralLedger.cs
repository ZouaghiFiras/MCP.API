namespace CED.Data.Entities
{
    public class GeneralLedger
    {
        public string GlId { get; set; } = null!;

        public byte[] GlTimeStamp { get; set; } = null!;

        public string GlDescription { get; set; } = null!;

        public Guid? GlMainCategoryId { get; set; }

        public Guid? GlSubCategroyId { get; set; }

        public bool GlIsSuspenseAccount { get; set; }

        public bool GlIsProfitLossAccount { get; set; }

        public bool? GlIsPrimaryProcess { get; set; }

        public string? GlExactAdministration { get; set; }

        public string? GlExactGeneralLedger { get; set; }

        public bool GlInactive { get; set; }

        public Guid? GlLocalizableEntryId { get; set; }

        public DateTime GlCreatedDate { get; set; }

        public string? GlCreatedBy { get; set; }

        public DateTime GlLastModifiedDate { get; set; }

        public string? GlLastModifiedBy { get; set; }

        public virtual LocalizableEntry? GlLocalizableEntry { get; set; }

        public virtual ICollection<Journal> Journals { get; } = new List<Journal>();

        public virtual ICollection<LedgerSetting> LedgerSettingGlsFundingGeneralLedgers { get; } =
            new List<LedgerSetting>();

        public virtual ICollection<LedgerSetting> LedgerSettingGlsPaymentInTransitExchangeRateDifferenceNavigations
        {
            get;
        } = new List<LedgerSetting>();

        public virtual ICollection<LedgerSetting> LedgerSettingGlsPaymentInTransitForeignCurrencyNavigations { get; } =
            new List<LedgerSetting>();

        public virtual ICollection<LedgerSetting> LedgerSettingGlsPaymentInTransitLocalCurrencyNavigations { get; } =
            new List<LedgerSetting>();

        public virtual ICollection<LedgerSetting> LedgerSettingGlsRecoveryGeneralLedgers { get; } =
            new List<LedgerSetting>();

        public virtual ICollection<LedgerSetting> LedgerSettingGlsSalesExchangeRateDifferenceNavigations { get; } =
            new List<LedgerSetting>();

        public virtual ICollection<PurchaseLedgerSetting> PurchaseLedgerSettingPlsEqualizationCreditGeneralLedgers
        {
            get;
        } = new List<PurchaseLedgerSetting>();

        public virtual ICollection<PurchaseLedgerSetting> PurchaseLedgerSettingPlsEqualizationDebitGeneralLedgers
        {
            get;
        } = new List<PurchaseLedgerSetting>();

        public virtual ICollection<PurchaseLedgerSetting> PurchaseLedgerSettingPlsGeneralLedgers { get; } =
            new List<PurchaseLedgerSetting>();

        public virtual ICollection<SalesLedgerSetting> SalesLedgerSettingSlsEqualizationCreditGeneralLedgers { get; } =
            new List<SalesLedgerSetting>();

        public virtual ICollection<SalesLedgerSetting> SalesLedgerSettingSlsEqualizationDebitGeneralLedgers { get; } =
            new List<SalesLedgerSetting>();

        public virtual ICollection<SalesLedgerSetting> SalesLedgerSettingSlsGeneralLedgers { get; } =
            new List<SalesLedgerSetting>();
    }
}