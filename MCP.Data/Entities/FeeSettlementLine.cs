namespace CED.Data.Entities
{
    public class FeeSettlementLine
    {
        public Guid FslId { get; set; }

        public byte[] FslTimeStamp { get; set; } = null!;

        public Guid FslFeeSettlementId { get; set; }

        public int FslLineNumber { get; set; }

        public Guid FslProductId { get; set; }

        public Guid? FslInsuranceCoverageId { get; set; }

        public Guid? FslWorkActivityId { get; set; }

        public Guid? FslActivityExecutionId { get; set; }

        public Guid? FslActivityOptionId { get; set; }

        public Guid FslFeeAgreementId { get; set; }

        public string? FslDossierFeeDateRuleId { get; set; }

        public string? FslSubDossierFeeDateRuleId { get; set; }

        public string? FslTaxDateRuleId { get; set; }

        public DateTime FslCreatedDate { get; set; }

        public string? FslCreatedBy { get; set; }

        public DateTime FslLastModifiedDate { get; set; }

        public string? FslLastModifiedBy { get; set; }

        public string? FslDescription { get; set; }

        public string? FslCountryCode { get; set; }

        public Guid? FslDeliveryMethodProductId { get; set; }

        public Guid? FslReportingFormProductId { get; set; }

        public virtual ICollection<FeeSettlementLineOperationalClient> FeeSettlementLineOperationalClients { get; } =
            new List<FeeSettlementLineOperationalClient>();

        public virtual ActivityExecution? FslActivityExecution { get; set; }

        public virtual ActivityOption? FslActivityOption { get; set; }

        public virtual FeeAgreement FslFeeAgreement { get; set; } = null!;

        public virtual FeeSettlement FslFeeSettlement { get; set; } = null!;

        public virtual InsuranceCoverage? FslInsuranceCoverage { get; set; }

        public virtual Product FslProduct { get; set; } = null!;

        public virtual WorkActivity? FslWorkActivity { get; set; }

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();
    }
}