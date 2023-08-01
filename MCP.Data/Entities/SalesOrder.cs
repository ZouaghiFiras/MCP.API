namespace CED.Data.Entities
{
    public class SalesOrder
    {
        public Guid SohId { get; set; }

        public byte[] SohTimeStamp { get; set; } = null!;

        public string SohNumber { get; set; } = null!;

        public DateTime SohOrderDate { get; set; }

        public string? SohEntryNumber { get; set; }

        public string? SohEntrySystem { get; set; }

        public string? SohEntryBatch { get; set; }

        public string? SohDescription { get; set; }

        public string? SohYourReference { get; set; }

        public string? SohOurReference { get; set; }

        public decimal SohGrossAmount { get; set; }

        public decimal SohTaxAmount { get; set; }

        public decimal SohNetAmount { get; set; }

        public decimal SohDiscount { get; set; }

        public decimal SohTaxExemptedAmount { get; set; }

        public decimal SohTaxReversedChargeAmount { get; set; }

        public decimal SohTaxImportAmount { get; set; }

        public DateTime? SohDueDate { get; set; }

        public string? SohCurrencyCode { get; set; }

        public double? SohExchangeRate { get; set; }

        public bool SohIsPrinted { get; set; }

        public bool SohIsImported { get; set; }

        public Guid SohLegalEntityId { get; set; }

        public Guid SohClientId { get; set; }

        public Guid? SohSalesOrderTypeId { get; set; }

        public Guid? SohPaymentConditionId { get; set; }

        public bool SohIsCredit { get; set; }

        public string? SohCreditReason { get; set; }

        public string? SohDebitEntryNumber { get; set; }

        public Guid? SohDebitSalesOrderId { get; set; }

        public Guid? SohTenantId { get; set; }

        public string? SohDossierNumber { get; set; }

        public Guid? SohDossierId { get; set; }

        public Guid? SohDossierAssignmentId { get; set; }

        public Guid? SohDossierPartyId { get; set; }

        public bool SohIsIntercompany { get; set; }

        public bool SohIsVoided { get; set; }

        public string? SohPaymentReference { get; set; }

        public string? SohLeadCurrencyCode { get; set; }

        public Guid? SohExchangeRateId { get; set; }

        public string? SohInUseBy { get; set; }

        public Guid? SohDeprecatedSalesOrderId { get; set; }

        public DateTime SohCreatedDate { get; set; }

        public string? SohCreatedBy { get; set; }

        public DateTime SohLastModifiedDate { get; set; }

        public string? SohLastModifiedBy { get; set; }

        public Guid? SohCurrentStatusHistoryId { get; set; }

        public DateTime? SohCurrentStatusHistoryStartDate { get; set; }

        public string? SohCurrentStatusCode { get; set; }

        public string? SohTaxCountryCode { get; set; }

        public string? SohCurrentStatusHistoryStatusChangeReason { get; set; }

        public Guid? SohParentId { get; set; }

        public decimal? SohOwnRiskAmount { get; set; }

        public decimal? SohVatDeductableAmount { get; set; }

        public virtual ICollection<SalesOrder> InverseSohDebitSalesOrder { get; } = new List<SalesOrder>();

        public virtual ICollection<SalesOrder> InverseSohDeprecatedSalesOrder { get; } = new List<SalesOrder>();

        public virtual ICollection<SalesOrder> InverseSohParent { get; } = new List<SalesOrder>();

        public virtual ICollection<SalesOrderAttachment> SalesOrderAttachments { get; } =
            new List<SalesOrderAttachment>();

        public virtual ICollection<SalesOrderAuthorization> SalesOrderAuthorizations { get; } =
            new List<SalesOrderAuthorization>();

        public virtual ICollection<SalesOrderCorrection> SalesOrderCorrections { get; } =
            new List<SalesOrderCorrection>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual ICollection<SalesOrderNote> SalesOrderNotes { get; } = new List<SalesOrderNote>();

        public virtual ICollection<SalesOrderStatusHistory> SalesOrderStatusHistories { get; } =
            new List<SalesOrderStatusHistory>();

        public virtual Client SohClient { get; set; } = null!;

        public virtual SalesOrder? SohDebitSalesOrder { get; set; }

        public virtual SalesOrder? SohDeprecatedSalesOrder { get; set; }

        public virtual Dossier? SohDossier { get; set; }

        public virtual DossierAssignment? SohDossierAssignment { get; set; }

        public virtual DossierParty? SohDossierParty { get; set; }

        public virtual ExchangeRate? SohExchangeRateNavigation { get; set; }

        public virtual LegalEntity SohLegalEntity { get; set; } = null!;

        public virtual SalesOrder? SohParent { get; set; }

        public virtual PaymentCondition? SohPaymentCondition { get; set; }

        public virtual SalesOrderType? SohSalesOrderType { get; set; }

        public virtual Tenant? SohTenant { get; set; }
    }
}