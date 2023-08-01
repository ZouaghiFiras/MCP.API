namespace CED.Data.Entities
{
    public class SalesOrderLineCoveragesView
    {
        public Guid Id { get; set; }

        public Guid SalesOrderId { get; set; }

        public bool IsFee { get; set; }

        public Guid AssistancePlanId { get; set; }

        public Guid AssistancePlanLineId { get; set; }

        public Guid AssistancePlanCoverageId { get; set; }

        public string? SalesOrderIsCostOfSales { get; set; }

        public bool IsCostOfSales { get; set; }

        public Guid InvolvedCoverageId { get; set; }

        public Guid? InsurancePolicyId { get; set; }

        public Guid DossierId { get; set; }

        public string? EntrySystem { get; set; }

        public Guid? InsurancePolicyClientId { get; set; }

        public Guid SalesOrderClientId { get; set; }

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public Guid? FeeInvoiceRecipientId { get; set; }

        public string? SalesOrderTotalAssistancePlanCoverageGrossAmount { get; set; }

        public decimal? AssistancePlanCoverageGrossAmount { get; set; }

        public Guid? SalesOrderProductId { get; set; }

        public Guid DossierProductId { get; set; }

        public string? SalesOrderWorkActivityId { get; set; }

        public Guid? WorkActivityId { get; set; }

        public string? SalesOrderActivityOptionId { get; set; }

        public Guid? ActivityOptionId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}