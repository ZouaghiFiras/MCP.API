namespace CED.Data.Entities
{
    public class FeeSettlement
    {
        public Guid FesId { get; set; }

        public byte[] FesTimeStamp { get; set; } = null!;

        public string FesSettlementName { get; set; } = null!;

        public Guid? FesLegalEntityId { get; set; }

        public Guid? FesClientId { get; set; }

        public string? FesInvoiceDeliveryMethodId { get; set; }

        public string? FesInvoiceRuleTypeId { get; set; }

        public Guid? FesExchangeRateProviderId { get; set; }

        public string? FesExchangeRateTypeId { get; set; }

        public string? FesEntrySystem { get; set; }

        public string? FesDossierFeeDateRuleId { get; set; }

        public string? FesSubDossierFeeDateRuleId { get; set; }

        public string? FesTaxDateRuleId { get; set; }

        public DateTime FesCreatedDate { get; set; }

        public string? FesCreatedBy { get; set; }

        public DateTime FesLastModifiedDate { get; set; }

        public string? FesLastModifiedBy { get; set; }

        public DateTime? FesTerminationDate { get; set; }

        public DateTime FesEffectiveDate { get; set; }

        public virtual ICollection<ClientMandateContractRelation> ClientMandateContractRelations { get; } =
            new List<ClientMandateContractRelation>();

        public virtual ICollection<FeeSettlementLine> FeeSettlementLines { get; } = new List<FeeSettlementLine>();

        public virtual ICollection<FeeSettlementReportingFormOption> FeeSettlementReportingFormOptions { get; } =
            new List<FeeSettlementReportingFormOption>();

        public virtual ICollection<FeeSettlementStatusHistory> FeeSettlementStatusHistories { get; } =
            new List<FeeSettlementStatusHistory>();

        public virtual Client? FesClient { get; set; }

        public virtual ExchangeRateProvider? FesExchangeRateProvider { get; set; }

        public virtual ExchangeRateType? FesExchangeRateType { get; set; }

        public virtual InvoiceDeliveryMethod? FesInvoiceDeliveryMethod { get; set; }

        public virtual InvoiceRuleType? FesInvoiceRuleType { get; set; }

        public virtual LegalEntity? FesLegalEntity { get; set; }
    }
}