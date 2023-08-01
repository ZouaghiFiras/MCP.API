namespace CED.Data.Entities
{
    public class PurchaseInvoiceLineCoveragesView
    {
        public Guid Id { get; set; }

        public Guid PurchaseInvoiceId { get; set; }

        public Guid AssistancePlanId { get; set; }

        public Guid AssistancePlanLineId { get; set; }

        public Guid AssistancePlanCoverageId { get; set; }

        public Guid? InvolvedObjectId { get; set; }

        public bool IsCostOfSales { get; set; }

        public Guid InvolvedCoverageId { get; set; }

        public Guid? InsurancePolicyId { get; set; }

        public Guid DossierId { get; set; }

        public Guid? ClientId { get; set; }

        public string? ClientCode { get; set; }

        public string ClientName { get; set; } = null!;

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public Guid? FeeInvoiceRecipientId { get; set; }

        public decimal PurchaseInvoiceLineGrossAmount { get; set; }

        public decimal? AssistancePlanCoverageGrossAmount { get; set; }

        public decimal PurchaseInvoiceLineNetAmount { get; set; }

        public decimal? AssistancePlanCoverageNetAmount { get; set; }

        public decimal? AssistancePlanCoverageMaxNetAmount { get; set; }

        public decimal? AssistancePlanLineMaxNetAmount { get; set; }

        public double PurchaseInvoiceLineQuantity { get; set; }

        public decimal? PurchaseInvoiceLineUnitPrice { get; set; }

        public decimal CostOfSalesNetAmount { get; set; }

        public double CostOfSalesTaxAmount { get; set; }

        public Guid? PurchaseInvoiceLineServiceId { get; set; }

        public short? Priority { get; set; }

        public bool IsContinuousPost { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}