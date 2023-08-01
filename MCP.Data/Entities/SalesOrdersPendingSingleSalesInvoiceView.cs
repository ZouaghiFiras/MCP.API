﻿namespace CED.Data.Entities
{
    public class SalesOrdersPendingSingleSalesInvoiceView
    {
        public Guid SalesOrderId { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public DateTime? DossierClosingDate { get; set; }

        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public DateTime? OrderDate { get; set; }

        public string OrderNumber { get; set; } = null!;

        public decimal NetAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal GrossAmount { get; set; }

        public string? EntrySystem { get; set; }

        public Guid SingleInvoiceRuleLogId { get; set; }

        public bool SalesOrdersCompletedCheck { get; set; }

        public bool FeeCompletedCheck { get; set; }

        public bool PurchaseInvoicesCompletedCheck { get; set; }
    }
}