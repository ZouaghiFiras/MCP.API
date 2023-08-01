namespace CED.Data.Entities
{
    public class SalesOrderLineInsurancePolicyChangesView
    {
        public Guid SalesOrderLineId { get; set; }

        public Guid SalesOrderId { get; set; }

        public string SalesOrderNumber { get; set; } = null!;

        public decimal SalesOrderGrossAmount { get; set; }

        public int SalesOrderLineNumber { get; set; }

        public decimal SalesOrderLineGrossAmount { get; set; }

        public bool IsFee { get; set; }

        public Guid SalesOrderClientId { get; set; }

        public string? SalesOrderCurrentStatusCode { get; set; }

        public double SalesOrderLineQuantity { get; set; }

        public double? SalesOrderCorrectionLineQuantity { get; set; }

        public decimal? SalesOrderLineUnitPrice { get; set; }

        public decimal? SalesOrderCorrectionLineUnitPrice { get; set; }

        public decimal SalesOrderLineNetAmount { get; set; }

        public decimal? SalesOrderCorrectionLineCostOfSalesAmount { get; set; }

        public Guid? WorkingOrderLineId { get; set; }

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public Guid? InsurancePolicyId { get; set; }

        public Guid DossierId { get; set; }

        public string? EntrySystem { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? InsurancePolicyClientId { get; set; }

        public Guid? FeeInvoiceRecipientId { get; set; }

        public string? SalesOrderProductId { get; set; }

        public Guid DossierProductId { get; set; }

        public int? DossierAssignmentProductId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? SalesOrderWorkActivityId { get; set; }

        public Guid? WorkActivityId { get; set; }

        public string? SalesOrderActivityOptionId { get; set; }

        public Guid? ActivityOptionId { get; set; }

        public bool? DossierWorkActivityInactive { get; set; }

        public bool? DossierWorkActivityIsInvoiceable { get; set; }
    }
}