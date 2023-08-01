﻿namespace CED.Data.Entities
{
    public class SalesOrderLineChangesWithInvalidSalesInvoicesView
    {
        public Guid Id { get; set; }

        public Guid SalesOrderId { get; set; }

        public string SalesOrderNumber { get; set; } = null!;

        public decimal SalesOrderGrossAmount { get; set; }

        public int SalesOrderLineNumber { get; set; }

        public decimal SalesOrderLineGrossAmount { get; set; }

        public bool IsFee { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public Guid? AssistancePlanLineId { get; set; }

        public Guid? AssistancePlanCoverageId { get; set; }

        public string? SalesOrderLineIsCostOfSales { get; set; }

        public bool? AssistancePlanLineIsCostOfSales { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public Guid? InsurancePolicyId { get; set; }

        public Guid DossierId { get; set; }

        public string? EntrySystem { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? InsurancePolicyClientId { get; set; }

        public Guid SalesOrderClientId { get; set; }

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public Guid? FeeInvoiceRecipientId { get; set; }

        public string? SalesOrderLineTotalAssistancePlanCoverageGrossAmount { get; set; }

        public decimal? AssistancePlanCoverageGrossAmount { get; set; }

        public string? SalesOrderProductId { get; set; }

        public Guid DossierProductId { get; set; }

        public string? SalesOrderWorkActivityId { get; set; }

        public Guid? WorkActivityId { get; set; }

        public string? SalesOrderActivityOptionId { get; set; }

        public Guid? ActivityOptionId { get; set; }

        public string? SalesOrderLicensePlate { get; set; }

        public string? LicensePlate { get; set; }

        public bool? DossierWorkActivityInactive { get; set; }

        public bool? AssistancePlanCoverageInactive { get; set; }

        public bool? AssistancePlanLineInactive { get; set; }

        public Guid? ServiceId { get; set; }

        public double SalesOrderLineQuantity { get; set; }

        public double? SalesOrderCorrectionLineQuantity { get; set; }

        public decimal? SalesOrderLineUnitPrice { get; set; }

        public decimal? SalesOrderCorrectionLineUnitPrice { get; set; }

        public decimal SalesOrderLineNetAmount { get; set; }

        public decimal? SalesOrderCorrectionLineCostOfSalesAmount { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public Guid SalesInvoiceId { get; set; }

        public string? SalesInvoiceNumber { get; set; }

        public decimal SalesInvoiceGrossAmount { get; set; }

        public int SalesInvoiceLineNumber { get; set; }

        public decimal SalesInvoiceLineGrossAmount { get; set; }

        public string SalesOrderClientCode { get; set; } = null!;

        public string SalesOrderClientName { get; set; } = null!;

        public string? FeeInvoiceRecipientCode { get; set; }

        public string? FeeInvoiceRecipientName { get; set; }

        public string? ChargedExpensesInvoiceRecipientCode { get; set; }

        public string? ChargedExpensesInvoiceRecipientName { get; set; }

        public string? SalesOrderProductName { get; set; }

        public string DossierProductName { get; set; } = null!;

        public string? SalesOrderWorkActivityName { get; set; }

        public string? DossierWorkActivityName { get; set; }

        public string? SalesOrderActivityOptionName { get; set; }

        public string? DossierActivityOptionName { get; set; }
    }
}