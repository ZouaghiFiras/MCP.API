namespace CED.Data.Entities
{
    public class ClaimReserveLine
    {
        public Guid CrlId { get; set; }

        public byte[] CrlTimeStamp { get; set; } = null!;

        public Guid CrlClaimReserveId { get; set; }

        public DateTime CrlTransactionDate { get; set; }

        public string CrlCurrencyCode { get; set; } = null!;

        public decimal CrlReservedValue { get; set; }

        public double CrlLeadExchangeRate { get; set; }

        public Guid? CvrLeadExchangeRateId { get; set; }

        public decimal CrlLeadReservedValue { get; set; }

        public double CrlClientExchangeRate { get; set; }

        public Guid? CvrClientExchangeRateId { get; set; }

        public decimal CrlClientReservedValue { get; set; }

        public Guid? CrlAssistancePlanLineId { get; set; }

        public Guid? CrlPurchaseInvoiceId { get; set; }

        public bool CrlIsManualTransaction { get; set; }

        public string? CrlTransactionReason { get; set; }

        public DateTime CrlCreatedDate { get; set; }

        public string? CrlCreatedBy { get; set; }

        public DateTime CrlLastModifiedDate { get; set; }

        public string? CrlLastModifiedBy { get; set; }

        public Guid? CrlDossierAssignmentId { get; set; }

        public Guid? CrlWorkingOrderLineId { get; set; }

        public Guid? CrlWorkingOrderLineCostId { get; set; }

        public Guid? CrlWorkingOrderLineCoverageId { get; set; }

        public virtual AssistancePlanLine? CrlAssistancePlanLine { get; set; }

        public virtual ClaimReserf CrlClaimReserve { get; set; } = null!;

        public virtual DossierAssignment? CrlDossierAssignment { get; set; }

        public virtual PurchaseInvoice? CrlPurchaseInvoice { get; set; }

        public virtual WorkingOrderLine? CrlWorkingOrderLine { get; set; }

        public virtual WorkingOrderLineCost? CrlWorkingOrderLineCost { get; set; }

        public virtual WorkingOrderLineCoverage? CrlWorkingOrderLineCoverage { get; set; }
    }
}